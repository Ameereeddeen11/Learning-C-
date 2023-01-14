namespace MyWebApp.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
