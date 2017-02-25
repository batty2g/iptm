namespace IPTM.WebApp.app.models
{
    using System.Data.Entity;
    using repository;

    public class QuantityType : Repository<QuantityType>
    {
        public QuantityType(DbContext dataContext) : base(dataContext)
        {
        }

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
    }
}