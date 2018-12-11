using Topshelf;

namespace TopshelfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<TopshelfService>(s =>
                {
                    s.ConstructUsing(name => new TopshelfService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Top shelf service.");
                x.SetDisplayName("Top shelf service.");
                x.SetServiceName("Top shelf service.");
            });
        }
    }
}
