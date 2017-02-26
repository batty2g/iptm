namespace IPTM.WebApp.app.models.repository
{
    using System.Data.Entity;

    public class RecipeIngredients : Repository<RecipeIngredient>
    {
        public RecipeIngredients(DbContext dataContext) : base(dataContext)
        {
        }
    }
}