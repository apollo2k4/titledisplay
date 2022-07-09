// This is a generated file!
// Do not edit manually, changes will be overwritten.

using System;
using System.Collections.Generic;

namespace TitleDisplay.Resources
{
	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	public static class TDRes
	{
		private static string TryGetEx(Dictionary<string, string> dictNew,
			string strName, string strDefault)
		{
			string strTemp;

			if(dictNew.TryGetValue(strName, out strTemp))
				return strTemp;

			return strDefault;
		}

		public static void SetTranslatedStrings(Dictionary<string, string> dictNew)
		{
			if(dictNew == null) throw new ArgumentNullException("dictNew");

			m_strDesc = TryGetEx(dictNew, "Desc", m_strDesc);
			m_strMaxTitleLen = TryGetEx(dictNew, "MaxTitleLen", m_strMaxTitleLen);
			m_strNote = TryGetEx(dictNew, "Note", m_strNote);
			m_strOption1 = TryGetEx(dictNew, "Option1", m_strOption1);
			m_strOption2 = TryGetEx(dictNew, "Option2", m_strOption2);
			m_strOption3 = TryGetEx(dictNew, "Option3", m_strOption3);
			m_strOption4 = TryGetEx(dictNew, "Option4", m_strOption4);
			m_strOption5 = TryGetEx(dictNew, "Option5", m_strOption5);
			m_strOption6 = TryGetEx(dictNew, "Option6", m_strOption6);
			m_strOption7 = TryGetEx(dictNew, "Option7", m_strOption7);
			m_strShowProductName = TryGetEx(dictNew, "ShowProductName", m_strShowProductName);
            m_strShowModifyDate = TryGetEx(dictNew, "ShowModifyDate", m_strShowModifyDate);
            m_strTitle = TryGetEx(dictNew, "Title", m_strTitle);
			m_strExample = TryGetEx(dictNew, "Example", m_strExample);
			
		}

		private static readonly string[] m_vKeyNames = {
			"Desc",
			"MaxTitleLen",
			"Note",
			"Option1",
			"Option2",
			"Option3",
			"Option4",
			"Option5",
			"Option6",
			"Option7",
			"ShowProductName",
            "ShowModifyDate",
            "Title"
			
		};

		public static string[] GetKeyNames()
		{
			return m_vKeyNames;
		}

		private static string m_strDesc =
			@"Configure KeePass Title Display.";
		public static string Desc
		{
			get { return m_strDesc; }
		}
		private static string m_strMaxTitleLen =
			@"Maximum Title Length";
		public static string MaxTitleLen
		{
			get { return m_strMaxTitleLen; }
		}
		
		private static string m_strNote =
			@"*Please note that these settings overide any set by KeePass options.";
		public static string Note
		{
			get { return m_strNote; }
		}

		private static string m_strOption1 =
			@"Database Name";
		public static string Option1
		{
			get { return m_strOption1; }
		}

		private static string m_strOption2 =
			@"Database File Name";
		public static string Option2
		{
			get { return m_strOption2; }
		}
		
		private static string m_strOption3 =
			@"Custom";
		public static string Option3
		{
			get { return m_strOption3; }
		}

		private static string m_strOption4 =
			@"Default User Name";
		public static string Option4
		{
			get { return m_strOption4; }
		}

		private static string m_strOption5 =
			@"Database Description";
		public static string Option5
		{
			get { return m_strOption5; }
		}		

		private static string m_strOption6 =
			@"Database Root Group Name";
		public static string Option6
		{
			get { return m_strOption6; }
		}
	
		private static string m_strOption7 =
			@"Database File Path";
		public static string Option7
		{
			get { return m_strOption7; }
		}

		private static string m_strShowProductName =
			@"Show Product Name";
		public static string ShowProductName
		{
			get { return m_strShowProductName; }
		}

        private static string m_strShowModifyDate =
        @"Show Modify Date";
        public static string ShowModifyDate
        {
            get { return m_strShowModifyDate; }
        }

        private static string m_strTitle =
			@"Title Display";
		public static string Title
		{
			get { return m_strTitle; }
		}	
		
		private static string m_strExample =
			@"Example";
		public static string Example
		{
			get { return m_strExample; }
		}	
	}
}
