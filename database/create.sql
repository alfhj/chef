CREATE TABLE Ingredients (
    Id INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Description VARCHAR(255),
    ImageUrl VARCHAR(255)
);

CREATE TABLE Recipes (
    Id INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Description VARCHAR(255),
    URL VARCHAR(255),
    ImageId UNIQUEIDENTIFIER,
    CONSTRAINT FK_Recipes_ImageId FOREIGN KEY (ImageId) REFERENCES Images(Id)
);

CREATE TABLE RecipeIngredients (
    RecipeId INT,
    IngredientId INT,
    Amount FLOAT,
    CONSTRAINT PK_RecipeIngredients PRIMARY KEY (RecipeId, IngredientId),
    CONSTRAINT FK_RecipeIngredients_RecipeId FOREIGN KEY (RecipeId) REFERENCES Recipes(Id),
    CONSTRAINT FK_RecipeIngredients_IngredientId FOREIGN KEY (IngredientId) REFERENCES Ingredients(Id)
);
