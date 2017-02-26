namespace IPTM.WebApp.app.models.repository
{
    using System.Data.Entity;

    public class Recipes : Repository<Recipe>
    {
        public Recipes(DbContext dataContext) : base(dataContext)
        {
        }
    }
}