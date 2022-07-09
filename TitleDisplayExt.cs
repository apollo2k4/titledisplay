/*
  Title Display plugin for KeePass Password Safe
  Copyright (C) 2009-2010 SEG Tech <me@gogogadgetscott.info>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using KeePass.Plugins;
using KeePass.Resources;
using KeePass.App.Configuration;

using KeePassLib;

using TitleDisplay.Resources;
	
namespace TitleDisplay
{
	/// <summary>
	/// This is the main plugin class. It must be named exactly
	/// like the namespace and must be derived from
	/// <c>KeePassPlugin</c>.
	/// </summary>
	public sealed class TitleDisplayExt : Plugin
	{
		
		private Resources.PluginFunctions m_funcs = null;
		private System.Windows.Forms.ToolStripMenuItem m_tsmlOptions = null;

        public override string UpdateUrl
        {
            get
            {
                return "http://gogogadgetscott.info/keepass/titledisplay/keepass.version";
            }
        }

        /// <summary>
        /// The <c>Initialize</c> function is called by KeePass when
        /// you should initialize your plugin (create menu items, etc.).
        /// </summary>
        /// <param name="host">Plugin host interface. By using this
        /// interface, you can access the KeePass main window and the
        /// currently opened database.</param>
        /// <returns>You must return <c>true</c> in order to signal
        /// successful initialization. If you return <c>false</c>,
        /// KeePass unloads your plugin (without calling the
        /// <c>Terminate</c> function of your plugin).</returns>
        public override bool Initialize(IPluginHost host)
		{
			Debug.Assert(host != null);
			if(host == null) return false;
			
			m_funcs = new TitleDisplay.Resources.PluginFunctions(host);
			m_funcs.UpdateTitleDisplay();
			
			// We want a notification when main windows title changes and when
			// hover over Notify Icon. Must do both as the Notify Icon text is set after
			// the main window.
			m_funcs.Host.MainWindow.TextChanged +=  new EventHandler(UpdateTitle);
			m_funcs.Host.MainWindow.MainNotifyIcon.MouseMove += new MouseEventHandler(UpdateTitle);
                        
			// Get a reference to the 'Tools' menu item container
			ToolStripItemCollection tsMenu = m_funcs.Host.MainWindow.ToolsMenu.DropDownItems;

			// Add menu item for options
            m_tsmlOptions = new ToolStripMenuItem();
            m_tsmlOptions.Text = "Title Display...";
            m_tsmlOptions.Image = TitleDisplay.Properties.Resources.B16x16_TitleDisplay;
            m_tsmlOptions.Click += OnToolsOptions;
            m_tsmlOptions.Enabled = true;
            tsMenu.Add(m_tsmlOptions);

            TDRes.SetTranslatedStrings(
				KeePass.Program.Translation.SafeGetStringTableDictionary(
            	"TitleDisplay.Resources.TDRes"));
            
            return true; // Initialization successful
		}

		/// <summary>
		/// The <c>Terminate</c> function is called by KeePass when
		/// you should free all resources, close open files/streams,
		/// etc. It is also recommended that you remove all your
		/// plugin menu items from the KeePass menu.
		/// </summary>
		public override void Terminate()
		{
			// Remove all of our menu items
			ToolStripItemCollection tsMenu = m_funcs.Host.MainWindow.ToolsMenu.DropDownItems;
			tsMenu.Remove(m_tsmlOptions);
			
			// Important! Remove event handlers!
			m_funcs.Host.MainWindow.TextChanged -= UpdateTitle;
			m_funcs.Host.MainWindow.MainNotifyIcon.MouseMove -= UpdateTitle;
			
		}

		private void UpdateTitle(object sender, EventArgs e)
		{						
			m_funcs.UpdateTitleDisplay();
		}
		
		private void OnToolsOptions(object sender, EventArgs e)
		{
			TitleDisplay.Forms.OptionsForm ofDlg = new TitleDisplay.Forms.OptionsForm();
			ofDlg.InitEx(m_funcs.Host);
			
			if(ofDlg.ShowDialog() == DialogResult.OK)
			{
				m_funcs.SetupOptions();
				m_funcs.UpdateTitleDisplay();
			}

		}
		
	}
}
