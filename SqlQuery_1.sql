SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM Products
LEFT JOIN Categories ON Products.CategoryID = Categories.CategoryID