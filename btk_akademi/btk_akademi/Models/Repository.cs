namespace btk_akademi.Models
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Application => applications;/*listeye bakarak bana bilgi dondercek */
        public static  void Add(Candidate candidate)/* formdan gelen elemanları ekler*/
        {
            applications.Add(candidate);
        }
    }
}
