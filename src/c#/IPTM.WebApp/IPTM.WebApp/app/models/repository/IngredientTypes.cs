namespace IPTM.WebApp.app.models.repository
{
    using System.Data.Entity;

    public class IngredientTypes : Repository<IngredientType>
    {
        public IngredientTypes(DbContext dataContext) : base(dataContext)
        {
        }
    }
}