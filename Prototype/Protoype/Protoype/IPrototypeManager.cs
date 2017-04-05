namespace Protoype
{
    public interface IPrototypeManager
    {
        IPrototype GetClone(string TypeName);
        void LoadConfig();
    }
}