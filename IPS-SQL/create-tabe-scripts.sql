/** SQL Scripts for table creation and constraints. **/

CREATE TABLE Engineer (
    EngineerNo INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    Forename VARCHAR(32) NOT NULL,
    Surname VARCHAR(32) NOT NULL,
    Phone VARCHAR(10) NOT NULL,
    Email VARCHAR(64) NULL,
    HomeAddress VARCHAR(128) NOT NULL,
    City VARCHAR(32) NOT NULL,
    Postcode VARCHAR(10) NOT NULL
);

INSERT INTO Engineer(Forename,Surname,Phone,Email,HomeAddress,City,Postcode) VALUES 
('Ian','Adair','07899665921','ijadair@btinternet.com','21 Houston Drive','Belfast','BT5 6AZ');

CREATE TABLE CustomerType(
    TypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    TypeDescription VARCHAR(64)
);

INSERT INTO CustomerType(TypeDescription) VALUES 
('Winemark'),
('Russels Shop 4 You'),
('Restaurant/Bar'),
('Head Office'),
('Other');

CREATE TABLE Customer(
    CustomerNo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(128) NOT NULL,
    Phone VARCHAR(10) NOT NULL,
    Email VARCHAR(64) NULL, 
    SiteAddress VARCHAR(128) NOT NULL,
    City VARCHAR(32) NOT NULL,
    Postcode VARCHAR(10) NOT NULL,
    TypeID INT NOT NULL,
    CONSTRAINT FK_CustomerType FOREIGN KEY(TypeID) REFERENCES CustomerType(TypeID)
);


CREATE TABLE Visit(
    VisitNo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Travel FLOAT,
    TimeOnSite FLOAT,
    Milage FLOAT,
    DoubleTime BOOLEAN NOT NULL,
    TimeAndHalf BOOLEAN NOT NULL,
    VisitDate DATE,
    Engineer INT NOT NULL,
    CONSTRAINT FK_Engineer FOREIGN KEY(Engineer) REFERENCES Engineer(EngineerNo)
);

CREATE TABLE Job(
    JobNo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CustomerNo INT NOT NULL,
    MaterialCost FLOAT NULL,
    CONSTRAINT FK_Customer FOREIGN KEY(CustomerNo) REFERENCES Customer(CustomerNo)
);

CREATE TABLE JobVisit(
    JobNo INT NOT NULL,
    VisitNo INT NOT NULL,
    PRIMARY KEY (JobNo, VisitNo),
    CONSTRAINT FK_Job FOREIGN KEY(JobNo) REFERENCES Job(JobNo),
    CONSTRAINT FK_Visit FOREIGN KEY (VisitNo) REFERENCES Visit(VisitNo)

)

CREATE TABLE Invoice(
    InvoiceNo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    JobNo INT NOT NULL,
    InvoiceDate DATE NOT NULL,
    CONSTRAINT FK_Job FOREIGN KEY(JobNo) REFERENCES Job(JobNo)
);