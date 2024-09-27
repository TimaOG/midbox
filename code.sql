SELECT
    p.ProductName, 
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.FkProductID
LEFT JOIN 
    Categories c ON pc.FkCategoryID = c.CategoryID;