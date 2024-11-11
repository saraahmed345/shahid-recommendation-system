-- Create sequence and trigger to auto increment ContentID
CREATE SEQUENCE CONTENT_ID;

create or replace TRIGGER new_content 
BEFORE INSERT ON Content
FOR EACH ROW

BEGIN
  SELECT CONTENT_ID.NEXTVAL
  INTO   :new.CONTENTID
  FROM   dual;
END;

-- Insert initial users
INSERT INTO User_Info (UserID, Username, Email, Password, RegistrationDate)
VALUES (0, 'admin', 'admin@shahid.com', 'root', SYSDATE);

INSERT INTO User_Info (UserID, Username, Email, Password, RegistrationDate)
VALUES (1, 'test', 'test@shahid.com', 'test', SYSDATE);

-- Insert data into Content table
INSERT INTO Content (title, type_content, con_description, genre, tags, releaseyear)
VALUES ('Central Intelligence', 'movie', 'After he reconnects with an awkward pal from high school through Facebook, a mild-mannered accountant is lured into the world of international espionage.', 'Crime', 'Crime, Action, Comedy', 2016);

-- Insert data into Content table
INSERT INTO Content (title, type_content, con_description, genre, tags, releaseyear)
VALUES ('The Shawshank Redemption', 'movie', 'Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.', 'Drama', 'Drama, Crime', 1994);

-- Insert data into Content table
INSERT INTO Content (title, type_content, con_description, genre, tags, releaseyear)
VALUES ('The office', 'tv show', 'A mockumentary on a group of typical office workers, where the workday consists of ego clashes, inappropriate behavior, and tedium.', 'Comedy', 'Comedy, Romance', 2005);

-- Insert data into Content table
INSERT INTO Content (title, type_content, con_description, genre, tags, releaseyear)
VALUES ('The Godfather', 'movie', 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', 'Crime', 'Crime, Drama', 1972);

-- Insert data into Watchlist_Info table
INSERT INTO Watchlist_Info (WatchlistID, UserID, ContentID)
VALUES (1, 1, 1);

-- Insert data into Watchlist_Info table
INSERT INTO Watchlist_Info (WatchlistID, UserID, ContentID)
VALUES (1, 1, 2);