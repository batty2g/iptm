namespace IPTM.WebApp.app.models
{
    public class RecipeIngredient
    {
        private int _recipeId;
        public int RecipeId
        {
            get { return _recipeId; }
            set { _recipeId = value; }
        }

        private int _ingredientId;
        public int IngredientId
        {
            get { return _ingredientId; }
            private set { _ingredientId = value; }
        }

        private Ingredient _ingredient;
        public Ingredient Ingredient
        {
            get { return _ingredient; }
            set { _ingredient = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private int _quantityTypeId;
        public int QuantityTypeId
        {
            get { return _quantityTypeId; }
            private set { _quantityTypeId = value; }
        }

        private QuantityType _quantityType;
        public QuantityType QuantityType
        {
            get { return _quantityType; }
            set { _quantityType = value; }
        }
    }
}