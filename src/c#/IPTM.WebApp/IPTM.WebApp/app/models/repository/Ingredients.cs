namespace IPTM.WebApp.app.models.repository
{
    using System.Data.Entity;

    public class Ingredients : Repository<Ingredient>
    {
        public Ingredients(DbContext dataContext) : base(dataContext)
        {
        }
    }
}