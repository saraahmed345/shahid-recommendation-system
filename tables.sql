CREATE TABLE User_Info (
    UserID INT PRIMARY KEY,
    Username VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    RegistrationDate DATE NOT NULL
);

CREATE TABLE Content (
    ContentID INT PRIMARY KEY,
    Title VARCHAR2(255) NOT NULL,
    con_Description CLOB, -- Use CLOB for large text data
    Type_content VARCHAR2(50),
    Tags VARCHAR2(255),
    ReleaseYear INT,
    Genre VARCHAR2(50),
    MeanRating DECIMAL(3,2)
);

CREATE TABLE Watchlist_Info (
    WatchlistID INT NOT NULL,
    UserID INT,
    ContentID INT,
    FOREIGN KEY (UserID) REFERENCES User_Info(UserID),
    FOREIGN KEY (ContentID) REFERENCES Content(ContentID)
);

CREATE TABLE UserInterests (
    UserID INT PRIMARY KEY,
    Genre VARCHAR2(255) NOT NULL, 
    Weight INT
);

CREATE TABLE Rating (
    RatingID INT PRIMARY KEY,
    UserID INT,
    ContentID INT,
    Rating DECIMAL(3, 2),
    Review CLOB, -- Use CLOB for large text data
    Timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES User_Info(UserID),
    FOREIGN KEY (ContentID) REFERENCES Content(ContentID)
);

CREATE TABLE GenreTracking_Info (
    TrackingID INT PRIMARY KEY,
    UserID INT,
    Genre VARCHAR2(50),
    VisitCount INT,
    FOREIGN KEY (UserID) REFERENCES User_Info(UserID)
);

CREATE TABLE Recommendation (
    RecommendationID INT PRIMARY KEY,
    UserID INT,
    ContentID INT,
    RecommendationScore DECIMAL(5, 2),
    FOREIGN KEY (UserID) REFERENCES User_Info(UserID),
    FOREIGN KEY (ContentID) REFERENCES Content(ContentID)
);