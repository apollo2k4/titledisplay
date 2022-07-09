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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

using KeePass;
using KeePass.UI;
using KeePass.Plugins;

using TitleDisplay.Resources;

namespace TitleDisplay.Forms
{
	// <summary>
	/// Options dialog. In this dialog, global program options can be configured.
	/// </summary>
	public partial class OptionsForm : Form
    {
		private Resources.PluginFunctions m_Funcs = null;
		private bool m_bLoadingSettings = false;
		
		/// <summary>
		/// Default constructor.
		/// </summary>
		public OptionsForm()
		{
			InitializeComponent();
			
			/// <summary>
			/// @todo: Not sure how this works
			/// Do manually for now.
			/// </summary>
			Program.Translation.ApplyTo(this);
			this.lblMaxTitleLen.Text = TDRes.MaxTitleLen;
			this.label1.Text = TDRes.Note;
			this.Option1.Text = TDRes.Option1;
			this.Option2.Text = TDRes.Option2;
			this.Option3.Text = TDRes.Option3;
			this.Option4.Text = TDRes.Option4;
			this.Option5.Text = TDRes.Option5;
			this.Option6.Text = TDRes.Option6;
			this.Option7.Text = TDRes.Option7;
			this.ShowProductName.Text = TDRes.ShowProductName;
            this.ShowModifyDate.Text = TDRes.ShowModifyDate;
			this.Text = TDRes.Title;
			this.Icon = Properties.Resources.I16x16_TitleDisplay;	
							
		}
		
		/// <summary>
		/// Initialize the dialog. This function must be called before the dialog
		/// is displayed.
		/// </summary>
		/// <param name="ilIcons">Image list to use for displaying images.</param>
		public void InitEx(IPluginHost host)
		{
			Debug.Assert(host != null);
			m_Funcs = new TitleDisplay.Resources.PluginFunctions(host);
		}
		
		private void CreateDialogBanner(BannerStyle bsStyle)
		{
			
			m_bannerImage.Image = BannerFactory.CreateBanner(m_bannerImage.Width,
				m_bannerImage.Height, bsStyle,
				Properties.Resources.B48x48_TitleDisplay, TDRes.Title,
				TDRes.Desc);

		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			GlobalWindowManager.AddWindow(this);
			
			CreateDialogBanner(BannerStyle.Default);			
			LoadOptions();

		}

		private void LoadOptions()
		{
			m_bLoadingSettings = true;
			
//
//			m_cdxGuiOptions.CreateItem(Program.Config.MainWindow, "ShowFullPathInTitle",
//				m_lvGuiOptions, lvg, KPRes.ShowFullPathInTitleBar);
//
			this.txtCustom.Enabled = false;
					
			switch (m_Funcs.Options.Option)
			{
				case 1:
					this.Option1.Checked = true;
					break;
					
				case 2:
					this.Option2.Checked = true;
					break;
					
				case 3:
					this.Option3.Checked = true;
					this.txtCustom.Enabled = true;
					break;
				
				case 4:
					this.Option4.Checked = true;
					break;
					
				case 5:
					this.Option5.Checked = true;
					break;
					
				case 6:
					this.Option6.Checked = true;
					break;
				
				case 7:
					this.Option7.Checked = true;
					break;
					
				default:
					break;
			} 
			
			this.MaxTitleLen.Value = m_Funcs.Options.MaxTitleLen;
			this.txtCustom.Text = m_Funcs.Options.Custom;		
			this.ShowProductName.Checked = m_Funcs.Options.ShowProductName;
            this.ShowModifyDate.Checked = m_Funcs.Options.ShowModifyDate;

            m_bLoadingSettings = false;
			
			SaveOptions();
				
		}
		
		private void SaveOptions()
		{
			if(m_bLoadingSettings) return;
			
			if (this.Option1.Checked)
			{
				m_Funcs.Options.Option = 1;
			}
			else if (this.Option2.Checked)
			{
				m_Funcs.Options.Option = 2;
			}
			else if (this.Option3.Checked)
			{
				m_Funcs.Options.Option = 3;
			} 
			else if (this.Option4.Checked)
			{
				m_Funcs.Options.Option = 4;
			}
			else if (this.Option5.Checked)
			{
				m_Funcs.Options.Option = 5;
			}
			else if (this.Option6.Checked)
			{
				m_Funcs.Options.Option = 6;
			}
			else if (this.Option7.Checked)
			{
				m_Funcs.Options.Option = 7;
			}
			
			m_Funcs.Options.MaxTitleLen = Convert.ToInt32(this.MaxTitleLen.Value);
			m_Funcs.Options.ShowProductName = this.ShowProductName.Checked;
            m_Funcs.Options.ShowModifyDate = this.ShowModifyDate.Checked;
            m_Funcs.Options.Custom = this.txtCustom.Text;
			
			/// <summary>
			/// Update example box.
			/// </summary>
			this.txtExample.Text = m_Funcs.GetTitleDisplay();
		}
        
		private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void OnBtnOK(object sender, EventArgs e)
		{
			SaveOptions();
			m_Funcs.Options.Save();
		}
		
		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			GlobalWindowManager.RemoveWindow(this);
		}
        
        private void SomethingChanged(object sender, EventArgs e)
        {
        	txtCustom.Enabled = Option3.Checked;
        	SaveOptions();
        }
              
    }
}
