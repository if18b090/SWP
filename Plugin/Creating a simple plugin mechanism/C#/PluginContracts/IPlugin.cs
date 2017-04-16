namespace PluginInterfaces
{
	public interface IPlugin
	{
		string Name { get; }
		string Do();
	}
}
