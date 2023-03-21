namespace ReviewApp.Model
{
    public class Review
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public int Rating { get; set; }
        public Reviewer Reviewer { get; internal set; }

        public Pokemon Pokemon { get; set; }
    }
}
