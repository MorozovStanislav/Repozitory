namespace ShoeStore.Domains
{

    public class Reviews
    {
        public int CommentId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Grade { get; set; }

        public Reviews() { }

        public Reviews(int commentId, string firstname, string secondname, string lastname, int grade)
        {
            CommentId = commentId;
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            Grade = grade;
        }
    }
}