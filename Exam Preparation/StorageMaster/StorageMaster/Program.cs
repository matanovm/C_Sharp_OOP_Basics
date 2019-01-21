namespace StorageMaster
{
    using Core;

    public class Program
    {
        public static void Main()
        {
            Engine engine = new Engine(new StorageMaster());
            engine.Run();
        }
    }
}