using System;
using System.IO;
using System.Collections.Generic;
using ExercicioDictionary.Entities;

namespace ExercicioDictionary.Services
{
    class VotingService
    {
        public Dictionary<string, int> GetResult(string path)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream == false)
                    {
                        string[] values = sr.ReadLine().Split(',');
                        Candidate candidate = new Candidate(values);

                        if (result.ContainsKey(candidate.Name))
                        {
                            result[candidate.Name] += candidate.Votes;
                        }
                        else
                        {
                            result.Add(candidate.Name, candidate.Votes);
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
