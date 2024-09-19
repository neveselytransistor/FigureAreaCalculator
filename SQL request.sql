SELECT p.Name as ProductName, c.Name as CategoryName
FROM Product p
    LEFT JOIN ProductCategory pc on p.Id = pc.ProductId
    LEFT JOIN Category c on pc.CategoryId = C.Id
