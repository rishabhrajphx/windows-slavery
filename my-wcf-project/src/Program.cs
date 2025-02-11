using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MyWcfProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Services.MyService)))
            {
                try
                {
                    host.Open();
                    Console.WriteLine("Service is running...");
                    Console.WriteLine("Press <Enter> to terminate the service.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    host.Close();
                }
            }
        }
    }
}