SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    Product_Category pc ON p.ID = pc.ID
LEFT JOIN 
    Categories c ON pc.ID = c.ID