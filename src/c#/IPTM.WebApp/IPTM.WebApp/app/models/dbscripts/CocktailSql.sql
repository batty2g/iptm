CREATE TABLE IngredientTypes (
  Id INT NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Description VARCHAR(250) NULL
);

CREATE TABLE Ingredients (
  Id INT NOT NULL IDENTITY(1,1),
  Name VARCHAR(100) NOT NULL,
  Description VARCHAR(250) NULL,
  IngredientTypeId INT NOT NULL,
  Proof INT NULL
);

CREATE TABLE Recipes (
  Id INT NOT NULL IDENTITY(1,1),
  Name VARCHAR(50) NOT NULL,
  Description VARCHAR(250) NULL,
  Instructions VARCHAR(250) NULL
);

CREATE TABLE QuantityTypes (
  Id INT NOT NULL,
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE RecipesIngredients (
  RecipeId INT NOT NULL,
  IngredientId INT NOT NULL,
  Quantity INT NOT NULL,
  QuantityTypeId INT NOT NULL
);

ALTER TABLE IngredientTypes ADD CONSTRAINT PK_IngredientTypes 
	PRIMARY KEY CLUSTERED (Id)
;

ALTER TABLE Ingredients ADD CONSTRAINT PK_Ingredients 
	PRIMARY KEY CLUSTERED (Id)
;

ALTER TABLE Ingredients
	ADD CONSTRAINT UQ_Ingredients_Name UNIQUE (Id)
;

ALTER TABLE Ingredients ADD CONSTRAINT FK_Ingredients_IngredientTypes 
	FOREIGN KEY (IngredientTypeId) REFERENCES IngredientTypes (Id)
;

CREATE INDEX FK_Ingredients_IngredientsTypeId_idx
	ON Ingredients (IngredientTypeId ASC)
;

ALTER TABLE Recipes ADD CONSTRAINT PK_Recipes
	PRIMARY KEY CLUSTERED (Id)
;

ALTER TABLE Recipes
	ADD CONSTRAINT UQ_Recipes_Name UNIQUE (Id)
;

ALTER TABLE RecipesIngredients ADD CONSTRAINT PK_RecipesIngredients 
	PRIMARY KEY CLUSTERED (RecipeId, IngredientId)
;

ALTER TABLE RecipesIngredients ADD CONSTRAINT FK_RecipesIngredients_Recipes 
	FOREIGN KEY (RecipeId) REFERENCES Recipes (Id)
;

ALTER TABLE RecipesIngredients ADD CONSTRAINT FK_RecipesIngredients_Ingredients 
	FOREIGN KEY (IngredientId) REFERENCES Ingredients (Id)
;

ALTER TABLE RecipesIngredients ADD CONSTRAINT FK_RecipesIngredients_QuantityTypes 
	FOREIGN KEY (QuantityTypeId) REFERENCES QuantityTypes (Id)
;

CREATE INDEX FK_RecipesIngredients_Ingredients_idx
	ON RecipesIngredients (IngredientId ASC)
;

CREATE INDEX FK_RecipesIngredients_QuantityTypes_idx
	ON RecipesIngredients (QuantityTypeId ASC)
;