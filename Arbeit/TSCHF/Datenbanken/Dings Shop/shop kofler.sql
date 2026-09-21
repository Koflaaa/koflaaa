CREATE TABLE Suppliers (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName VARCHAR(100),
    ContactName VARCHAR(100),
    Address VARCHAR(255),
    City VARCHAR(100),
    PostalCode VARCHAR(20),
    Country VARCHAR(50),
    Phone VARCHAR(50)
);

CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(100),
    Description TEXT
);

CREATE TABLE Shippers (
    ShipperID INT IDENTITY(1,1) PRIMARY KEY,
    ShipperName VARCHAR(100),
    Phone VARCHAR(50)
);

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    LastName VARCHAR(100),
    FirstName VARCHAR(100),
    BirthDate DATE,
    Notes TEXT
);

CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(100),
    ContactName VARCHAR(100),
    Address VARCHAR(255),
    City VARCHAR(100),
    PostalCode VARCHAR(20),
    Country VARCHAR(50)
);

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    SupplierID INT,
    CategoryID INT,
    Unit VARCHAR(50),
    Price DECIMAL(10, 2),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT,
    EmployeeID INT,
    OrderDate DATE,
    ShipperID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ShipperID) REFERENCES Shippers(ShipperID)
);

CREATE TABLE OrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES
('Musterfirma GmbH', 'Max Mustermann', 'Musterstraße 1', 'Berlin', '10115', 'Deutschland'),
('Tech World', 'Anna Schmidt', 'Technologieweg 2', 'Hamburg', '20095', 'Deutschland'),
('Global Electronics', 'John Doe', 'Elektrostraße 10', 'München', '80331', 'Deutschland'),
('Innovative Solutions', 'Peter Müller', 'Innovationstraße 5', 'Frankfurt', '60311', 'Deutschland'),
('Creative Labs', 'Maria Meier', 'Kreativweg 7', 'Stuttgart', '70173', 'Deutschland');

INSERT INTO Categories (CategoryName, Description)
VALUES
('Elektronik', 'Elektronische Geräte und Zubehör'),
('Bücher', 'Gedruckte und digitale Bücher'),
('Möbel', 'Haus- und Büroeinrichtungen'),
('Lebensmittel', 'Frische und verpackte Lebensmittel'),
('Kleidung', 'Bekleidung und Modeartikel');

INSERT INTO Employees (LastName, FirstName, BirthDate, Notes)
VALUES
('Schneider', 'Julia', '1985-06-15', 'Verkaufsexpertin'),
('Meier', 'Markus', '1990-11-10', 'Logistikmanagement'),
('Becker', 'Sven', '1982-03-22', 'Lagerleiter'),
('Koch', 'Lena', '1995-02-18', 'Kundenbetreuung'),
('Zimmermann', 'Thomas', '1987-09-30', 'Vertrieb');

INSERT INTO OrderDetails (Quantity)
VALUES
(5),
(3),
(2),
(6),
(4);

INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, ShipperID)
VALUES
(1, 1, '2025-02-01', 1),
(2, 2, '2025-02-02', 2),
(3, 3, '2025-02-03', 3),
(4, 4, '2025-02-04', 1),
(5, 5, '2025-02-05', 2);

INSERT INTO Products (ProductName, SupplierID, CategoryID, Unit, Price)
VALUES
('Laptop', 1, 1, 'Stück', 1200.00),
('Tablet', 2, 1, 'Stück', 450.00),
('Buch: Technologie', 3, 2, 'Stück', 20.00),
('Schreibtisch', 4, 3, 'Stück', 150.00),
('T-Shirt', 5, 5, 'Stück', 15.00);

INSERT INTO Shippers (ShipperName, Phone)
VALUES
('DHL', '0800-123456'),
('Hermes', '0800-654321'),
('UPS', '0800-112233');

INSERT INTO Suppliers (SupplierName, ContactName, Address, City, PostalCode, Country, Phone)
VALUES
('Tech Supplies', 'Hans Weber', 'Techstraße 3', 'Berlin', '10115', 'Deutschland', '030-1234567'),
('GadgetCo', 'Maria Fischer', 'Gadgetweg 1', 'Hamburg', '20095', 'Deutschland', '040-2345678'),
('Books Online', 'Stefan Müller', 'Buchstraße 12', 'München', '80331', 'Deutschland', '089-3456789'),
('Furniture World', 'Claudia Lange', 'Möbelweg 7', 'Frankfurt', '60311', 'Deutschland', '069-4567890'),
('Fashion Hub', 'Julia Beck', 'Modenstraße 8', 'Stuttgart', '70173', 'Deutschland', '0711-5678901');




select * from Categories
select*from Customers
select*from Employees
select*from OrderDetails
select*from Orders
select*from Products
select*from Shippers
select*from Suppliers