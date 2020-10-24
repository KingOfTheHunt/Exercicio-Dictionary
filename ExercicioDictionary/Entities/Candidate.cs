namespace ExercicioDictionary.Entities
{
    class Candidate
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Candidate(string[] values)
        {
            Name = values[0];
            Votes = int.Parse(values[1]);
        }
    }
}
