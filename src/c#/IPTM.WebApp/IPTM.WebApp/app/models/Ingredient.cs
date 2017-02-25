namespace IPTM.WebApp.app.models
{
    using System.Data.Entity;
    using repository;

    public class Ingredient : Repository<Ingredient>
    {
        public Ingredient(DbContext dataContext) : base(dataContext)
        {
        }

        private int _id;
        public int Id {
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

        private int _ingredientTypeId;
        public int IngredientTypeId
        {
            get { return _ingredientTypeId; }
            private set { _ingredientTypeId = value; }
        }

        private IngredientType _ingredientType;
        public IngredientType IngredientType
        {
            get { return _ingredientType; }
            set { _ingredientType = value; }
        }

        private int _proof;
        public int Proof
        {
            get { return _proof; }
            set { _proof = value; }
        }
    }
}