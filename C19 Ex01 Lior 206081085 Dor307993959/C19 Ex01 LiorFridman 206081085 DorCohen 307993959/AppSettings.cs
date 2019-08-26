using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	public sealed class AppSettings
	{
		private static AppSettings m_AppSettings = null;

		public Point LastWindowLocation { get; set; }

		public Size LastWindowsSize { get; set; }

		public bool RememberUser { get; set; }

		public string AccessToken { get; set; }

		private AppSettings()
		{
			LastWindowLocation = new Point(20, 50);
			LastWindowsSize = new Size(800, 500);
			RememberUser = false;
			AccessToken = null;
		}

		public static AppSettings GetInstance()
		{
			if (m_AppSettings == null)
			{
				m_AppSettings = new AppSettings();
			}

			return m_AppSettings;
		}

		public static AppSettings LoadFromFile()
		{
			try
			{
				using (Stream stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "AppSettings.xml"), FileMode.Open))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
					m_AppSettings = serializer.Deserialize(stream) as AppSettings;
				}
			}
			catch
			{
				m_AppSettings = new AppSettings();
			}

			return m_AppSettings;
		}

		public void SaveToFile()
		{
			using (Stream stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "AppSettings.xml"), FileMode.Create))
			{
				XmlSerializer serializer = new XmlSerializer(this.GetType());
				serializer.Serialize(stream, this);
			}
		}
	}
}