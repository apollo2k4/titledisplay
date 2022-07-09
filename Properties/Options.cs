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
using KeePass.Plugins;

namespace TitleDisplay.Properties
{
	/// <summary>
	/// Description of Options.
	/// </summary>
	public class Options
	{
		private IPluginHost m_host = null;
		private string m_PluginName = "TitleDisplay";
		
		private string m_sCustom = "Secure DB";
		public string Custom
		{
			get { return m_sCustom; }
			set { m_sCustom = value; }
		}
	
		private long m_lMaxTitleLen = 64;
		public long MaxTitleLen
		{
			get { return m_lMaxTitleLen; }
			set { m_lMaxTitleLen = value; }
		}
		
		/// <summary>
		/// 1: Database Name
		/// 2: File Name
		/// 3: Custom
		/// 4: DefaultUserName
		/// 5: Database Description
		/// 6: Database RootGroup Name
		/// 7: File Path
		/// </summary>
		private long m_lOption = 2;
		public long Option
		{
			get { return m_lOption; }
			set { m_lOption = value; }
		}
		
		private bool m_bShowProductName = true;
		public bool ShowProductName
		{
			get { return m_bShowProductName; }
			set { m_bShowProductName = value; }
		}

        private bool m_bShowModifyDate = true;
        public bool ShowModifyDate
        {
            get { return m_bShowModifyDate; }
            set { m_bShowModifyDate = value; }
        }

        public Options(IPluginHost host)
		{
			m_host = host;
			
			m_sCustom = m_host.CustomConfig.GetString(m_PluginName + ".Custom", m_sCustom);
			m_lOption = m_host.CustomConfig.GetLong(m_PluginName + ".Option", m_lOption);		
			m_bShowProductName = m_host.CustomConfig.GetBool(m_PluginName + ".ShowProductName", m_bShowProductName);
            m_bShowModifyDate = m_host.CustomConfig.GetBool(m_PluginName + ".ShowModifyDate", m_bShowModifyDate);
            m_lMaxTitleLen = m_host.CustomConfig.GetLong(m_PluginName + ".MaxTitleLen", m_lMaxTitleLen);
		}
		
		public void Save()
		{
			m_host.CustomConfig.SetString(m_PluginName + ".Custom", m_sCustom);
			m_host.CustomConfig.SetLong(m_PluginName + ".Option", m_lOption);
			m_host.CustomConfig.SetBool(m_PluginName + ".ShowProductName", m_bShowProductName);
            m_host.CustomConfig.SetBool(m_PluginName + ".ShowModifyDate", m_bShowModifyDate);
            m_host.CustomConfig.SetLong(m_PluginName + ".MaxTitleLen", m_lMaxTitleLen);
		}
	}
}
