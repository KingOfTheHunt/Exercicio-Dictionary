using ExercicioDictionary.Services;
using System;
using System.Collections.Generic;

namespace ExercicioDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            VotingService votingService = new VotingService();

            try
            {
                Console.Write("Informe o caminho do arquivo: ");
                string path = @"" + Console.ReadLine();

                Dictionary<string, int> result = votingService.GetResult(path);

                Console.WriteLine("Exibindo os resultados:");
                foreach (var item in result)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
            }
        }
    }
}
