using System;
using System.IO;

namespace RestSharp.Samples.FileUpload.Client
{
    class Program
    {
        static void Main()
        {
            var client = new RestClient("http://localhost:5000");
            
            var request = new RestRequest("/api/upload", Method.POST);

            const string fileName = "ddd_book.jpg";
            var fileContent = File.ReadAllBytes(fileName);
            request.AddFileBytes(fileName, fileContent, fileName);

            var response = client.Execute(request);
            
            Console.WriteLine($"Response: {response.StatusCode}");
        }
    }
}