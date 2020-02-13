namespace FlexiTime.Models
{
    public class Location
    {
        public Location(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }
        private int id;
        public int LocationID
        {
            get
            {
                return this.id;
            }
        }
        public string Name{get;set;}
    }
}