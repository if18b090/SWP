
using Customer;
using PluginInterfaces;
using System.Windows;
using System.Windows.Controls;


namespace FirstPlugin
{
	public class FirstPlugin : IPlugin
	{
		#region IPlugin Members

		public string Name
		{
			get
			{
				return "First Plugin";
			}
		}

		public string Do()
		{
			//TextBox textbox = new TextBox();
			//textbox.Text = "Text";
			Class1 classy = new Class1();
			return classy.Name;
		}

		#endregion
	}
}
