using PluginInterfaces;
using System.Windows.Controls;

namespace SecondPlugin
{
	public class SecondPlugin : IPlugin
	{
		#region IPlugin Members

		public string Name
		{
			get
			{
				return "Second Plugin";
			}
		}

		public string Do()
		{
			//TextBox textBox = new TextBox();
			//textBox.Text = "Text2";
			//Customer.Customer customer = new Customer.Customer();
			//string customerdetail = customer.FirstName + "\n" + customer.LastName;
			string customerdetail = "test";
			return customerdetail;
		}

		#endregion
	}
}
