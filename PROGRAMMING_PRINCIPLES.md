# PROGRAMMING PRINCIPLES 


### 1. (OOP)

- [FoodItem](ClassLibrary/FoodItem.cs) - клас для представлення продукту з властивостями `Name` і `CaloriesPer100g`
- [Meal](ClassLibrary/Meal.cs) - клас для управління списком продуктів та розрахунку калорій
- [FoodDatabaseManager](ClassLibrary/FoodDatabaseManager.cs) - клас для управління БД продуктів
- [ActivityLevel](ClassLibrary/ActivityLevel.cs) - клас для представлення рівнів активності

### 2. (Encapsulation)

- [FoodDatabaseManager.cs](ClassLibrary/FoodDatabaseManager.cs#L13) - приватне поле `jsonFilePath`
- [FoodItem.cs](ClassLibrary/FoodItem.cs#L5-L6) - Properties для `Name` та `CaloriesPer100g`
- [ActivityLevel.cs](ClassLibrary/ActivityLevel.cs#L13-L14) - read-only Properties

### 3. Single Responsibility Principle

- [FoodDatabaseManager.cs](ClassLibrary/FoodDatabaseManager.cs) - відповідає за завантаження/збереження БД
- [Meal.cs](ClassLibrary/Meal.cs) - відповідає за розрахунок калорій однієї страви

### 4. Exception Handling

- [FoodDatabaseManager.cs](ClassLibrary/FoodDatabaseManager.cs#L19-L43) - try-catch при завантаженні БД
- [FoodDatabaseManager.cs](ClassLibrary/FoodDatabaseManager.cs#L46-L54) - try-catch при збереженні БД
- [UserDataForm/Form1.cs](UserDataForm/Form1.cs#L46-L58) - обробка помилок при розрахунку калорій


