namespace IPTM.WebApp.Models
{
    public class Recipe
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _name;
        public int Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _description;
        public int Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _instructions;
        public int Instructions
        {
            get { return _instructions; }
            set { _instructions = value; }
        }
    }
}