namespace LibraryManagementSystem
{
    public class BooKAddClass
    {
       
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher{ get; set; }
        public int Edition { get; set; }
        public int Pages { get; set; }
        public string Isbn { get; set; }
        public int TotalNumber { get; set; }
        public string Library { get; set; }
        public int SelfNumber { get; set; }

    }
    public class BookUpdateClass : BooKAddClass { }
}