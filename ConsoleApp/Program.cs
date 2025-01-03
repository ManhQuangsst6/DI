using Grpc.Net.Client;
using GrpcService;

namespace ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Tạo một kênh gRPC

            using var channel = GrpcChannel.ForAddress("https://localhost:7159");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            var reply2 = await client.SayByeAsync(
                             new ByeRequest { Message = "GreeterClient", Sex = true });
            Console.WriteLine("Greeting: " + reply2.Name);
            Console.WriteLine("Press any key to exit...");
            // Console.ReadKey();

            //using var channel = GrpcChannel.ForAddress("https://localhost:7159");

            //// Tạo stub từ Greeter
            //var client = new Greeter.GreeterClient(channel);

            //// Tạo yêu cầu
            //var request = new HelloRequest
            //{
            //    Name = "sdfg"
            //};

            //// Gửi yêu cầu và nhận phản hồi
            //var reply = await client.SayHelloAsync(request);

            //// Hiển thị kết quả
            //Console.WriteLine($"Greeting: {reply.Message}");
        }
    }
}
