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
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using KeePass.Plugins;
using KeePass.Resources;
using KeePass.Util;

using KeePassLib;
using KeePassLib.Security;
using KeePassLib.Utility;

namespace TitleDisplay.Resources
{
	/// <summary>
	/// Description of PluginFunctions.
	/// </summary>
	public class PluginFunctions
	{
		private IPluginHost m_host = null;
		private Properties.Options m_Options = null;
		
		private string m_WindowText = string.Empty;
		private string m_NtfText = string.Empty;
		private string m_LastTitle = string.Empty;

			
		public IPluginHost Host
		{
			get { return m_host; }
		}
		
		public Properties.Options Options
		{
			get { return m_Options; }
		}

		public PluginFunctions(IPluginHost host)
		{
			m_host = host;
			SetupOptions();
		}

		public void SetupOptions()
		{
			m_Options = new TitleDisplay.Properties.Options(m_host);
		}
		
		public void UpdateTitleDisplay()
		{
			string strWindowText = string.Empty;
			
			strWindowText = GetTitleDisplay();
			
			m_host.MainWindow.Text = m_WindowText;
			m_host.MainWindow.MainNotifyIcon.Text = m_NtfText;
		}
		
		public string GetTitleDisplay()
		{
			string WindowText = string.Empty;
			string NtfText = string.Empty;
			
			bool bDatabaseOpened = m_host.Database.IsOpen;
			bool bFileLocked = false;
			long lMaxTitleLen = m_Options.MaxTitleLen;
			
			// @todo: not sure how to check if db is locked
			if(m_host.MainWindow.DocumentManager.ActiveDocument.LockedIoc.Path.Length != 0)
			{
				bFileLocked = true;
			}
			else
			{
				bFileLocked = false;
			}
			
			if(bDatabaseOpened == false && bFileLocked == false)
			{
				if(m_Options.ShowProductName) WindowText = PwDefs.ProductName;
				NtfText = WindowText;
				m_LastTitle = string.Empty;
			}
			else
			{
				if(bFileLocked)
				{
					WindowText = " [" + KPRes.Locked + "]";
					lMaxTitleLen = lMaxTitleLen - WindowText.Length;
					WindowText = WinUtil.CompactPath(m_LastTitle, Convert.ToInt32(lMaxTitleLen)) + WindowText;
				}
				else
				{
					switch (m_Options.Option)
					{
						case 1:
							WindowText = m_host.Database.Name;
							break;
							
						case 2:
							WindowText = UrlUtil.GetFileName(m_host.Database.IOConnectionInfo.Path);
							break;
							
						case 3:
							WindowText = m_Options.Custom;
							break;
							
						case 4:
							WindowText = m_host.Database.DefaultUserName;
							break;
							
						case 5:
							WindowText = m_host.Database.Description;
							break;
							
						case 6:
							WindowText = m_host.Database.RootGroup.Name;
							break;
							
						case 7:
							WindowText = m_host.Database.IOConnectionInfo.GetDisplayName();
							break;
							
						default:
							break;
					} 
					
					// Remove line breaks
					WindowText = WindowText.Replace("\n", "");
					WindowText = WindowText.Replace("\r", "");

                    if (m_Options.ShowModifyDate)
                    {
                        var lastModified = System.IO.File.GetLastWriteTime(m_host.Database.IOConnectionInfo.Path);
                        WindowText = WindowText + " (" + lastModified.ToString("dd/MM/yyyy HH:mm:ss") + ")";
                    }

                    if (m_host.Database.Modified) lMaxTitleLen = lMaxTitleLen - 1;
					if(m_Options.ShowProductName) lMaxTitleLen = lMaxTitleLen - PwDefs.ProductName.Length - 3;
					if(lMaxTitleLen < 1) lMaxTitleLen = 1;
					WindowText = WinUtil.CompactPath(WindowText, Convert.ToInt32(lMaxTitleLen));
					
					m_LastTitle = WindowText;
					
					if(m_host.Database.Modified) WindowText = WindowText + "*";
					
				}
				
				NtfText = WindowText;
				
				if(m_Options.ShowProductName)
				{
					NtfText = PwDefs.ProductName + MessageService.NewLine + WindowText;					
					WindowText = WindowText + " - " + PwDefs.ProductName;					
				}
				
				// NtfText is limited to a max lenth of less then 64.
				int NtfMaxLenth = 63;
				if(Convert.ToInt32(m_Options.MaxTitleLen) < NtfMaxLenth) 
				{
					NtfMaxLenth = Convert.ToInt32(m_Options.MaxTitleLen);
				}
				NtfText = StrUtil.CompactString3Dots(NtfText, NtfMaxLenth);
			
				// Here max lenth is user defined.
				WindowText = StrUtil.CompactString3Dots(WindowText, Convert.ToInt32(m_Options.MaxTitleLen));
								
			}
			
			m_WindowText = WindowText;
			m_NtfText = NtfText;
			
			return m_WindowText;
			
		}
		

	}
}
