namespace IPTM.WebApp.app.models.repository
{
    using System.Data.Entity;

    public class QuantityTypes : Repository<QuantityType>
    {
        public QuantityTypes(DbContext dataContext) : base(dataContext)
        {
        }
    }
}