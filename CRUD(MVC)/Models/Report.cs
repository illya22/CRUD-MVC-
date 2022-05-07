namespace CRUD_MVC_.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Keywords { get; set; }
        public int Pages { get; set; }
        public  DateTime Date { get; set; }
    }
}
