// using _2023_0528_191114_21397_noname;

// IHost host = Host.CreateDefaultBuilder(args)
//     .ConfigureServices(services =>
//     {
//         services.AddHostedService<Worker>();
//     })
//     .Build();

// host.Run();
ConsoleApp.Run(args, (IConfiguration config, string name) =>
{
    Console.WriteLine($"Hello {name}, DATE/TIME:" + DateTime.Now);
    Console.WriteLine($"env1: {config["env1"]}");
});