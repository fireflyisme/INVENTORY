CREATE TABLE StockManagement (    
    ProductName NVARCHAR(255) NOT NULL,
    ProductCategory VARCHAR(100) NOT NULL,
    ProductQuantity INT NOT NULL CHECK (ProductQuantity >= 0),
    ProductMonthlySales INT NOT NULL CHECK (ProductMonthlySales >= 0),
    ProductDescription TEXT
);