

-- USERS TABLE
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    FullName VARCHAR(100),
    PasswordHash VARCHAR(255),
    Role VARCHAR(20) CHECK (Role IN ('Adopter', 'FosterParent', 'Admin', 'ShelterStaff')),
    PhoneNumber VARCHAR(20),
    Address VARCHAR(255),
    EmailID VARCHAR(70)
);

-- MEDICAL HISTORY TABLE
CREATE TABLE MedicalHistory (
    HistoryID INT PRIMARY KEY,
    PetID INT UNIQUE,
    VaccinationRecords VARCHAR(255),
    Allergies VARCHAR(255),
    ChronicIllness VARCHAR(255),
    LastCheckupDate DATE
);

-- PETS TABLE
CREATE TABLE Pets (
    PetID INT PRIMARY KEY,
    Name VARCHAR(50),
    Species VARCHAR(30),
    Breed VARCHAR(50),
    Age INT,
    Gender VARCHAR(10),
    MedicalDetails VARCHAR(255),
    Status VARCHAR(20) CHECK (Status IN ('Available', 'Adopted', 'Fostered')),
    MedicalHistoryID INT UNIQUE,
    FOREIGN KEY (MedicalHistoryID) REFERENCES MedicalHistory(HistoryID) ON DELETE CASCADE
);

-- ADOPTION RECORDS TABLE
CREATE TABLE AdoptionRecords (
    AdoptionID INT PRIMARY KEY,
    PetID INT,
    UserID INT,
    AdoptionDate DATE,
    FollowUpDate DATE,
    FOREIGN KEY (PetID) REFERENCES Pets(PetID) ON DELETE CASCADE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- FOSTER CARE TABLE
CREATE TABLE FosterCare (
    FosterID INT PRIMARY KEY,
    PetID INT,
    UserID INT,
    StartDate DATE,
    EndDate DATE NULL,
    BehaviorNotes VARCHAR(255),
    FOREIGN KEY (PetID) REFERENCES Pets(PetID) ON DELETE CASCADE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE

);

-- REVIEWS TABLE
CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY,
    UserID INT,
    PetID INT,
    Rating INT CHECK (Rating BETWEEN 1 AND 5),
    Comments VARCHAR(255),
    ReviewDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (PetID) REFERENCES Pets(PetID) ON DELETE CASCADE
);

-- ANALYTICS TABLE (UPDATED: NO VIEWS COLUMN)
CREATE TABLE Analytics (
    AnalyticsID INT PRIMARY KEY,
    PetID INT,
    Inquiries INT DEFAULT 0,
    FOREIGN KEY (PetID) REFERENCES Pets(PetID) ON DELETE CASCADE
);

-- ADOPTION REQUESTS TABLE
CREATE TABLE AdoptionRequests (
    RequestID INT PRIMARY KEY,
    PetID INT,
    UserID INT,
    RequestDate DATE,
    Status VARCHAR(20) CHECK (Status IN ('Pending', 'Approved', 'Rejected')),
    FOREIGN KEY (PetID) REFERENCES Pets(PetID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- SEQUENCES
CREATE SEQUENCE MedicalHistorySeq
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;

CREATE SEQUENCE AnalyticsSeq
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;

-- TRIGGER: INSERT ANALYTICS RECORD ON NEW PET
CREATE OR REPLACE TRIGGER trg_InsertAnalyticsRecord
AFTER INSERT ON Pets
FOR EACH ROW
BEGIN
    INSERT INTO Analytics (AnalyticsID, PetID, Inquiries)
    VALUES (AnalyticsSeq.NEXTVAL, :NEW.PetID, 0);
END;
/

-- TRIGGER: AUTO-ASSIGN MEDICAL HISTORY ID IF NULL
CREATE OR REPLACE TRIGGER trg_AutoAssignMedicalHistory
BEFORE INSERT ON Pets
FOR EACH ROW
BEGIN
    IF :NEW.MedicalHistoryID IS NULL THEN
        SELECT MedicalHistorySeq.NEXTVAL
        INTO :NEW.MedicalHistoryID
        FROM dual;
    END IF;
END;
/

-- TRIGGER: UPDATE PET STATUS TO 'Adopted' ON ADOPTION
CREATE OR REPLACE TRIGGER trg_UpdatePetStatusOnAdoption
AFTER INSERT ON AdoptionRecords
FOR EACH ROW
BEGIN
    UPDATE Pets
    SET Status = 'Adopted'
    WHERE PetID = :NEW.PetID;
END;
/

-- TRIGGER: UPDATE PET STATUS TO 'Fostered' ON FOSTER CARE
CREATE OR REPLACE TRIGGER trg_UpdatePetStatusOnFoster
AFTER INSERT ON FosterCare
FOR EACH ROW
BEGIN
    UPDATE Pets
    SET Status = 'Fostered'
    WHERE PetID = :NEW.PetID;
END;
/

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (1, 'Buddy', 'Dog', 'Labrador', 3, 'Male', 'Healthy, vaccinated', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (2, 'Misty', 'Cat', 'Persian', 2, 'Female', 'Allergic to chicken', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (3, 'Charlie', 'Dog', 'Golden Retriever', 5, 'Male', 'Minor skin issue', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (4, 'Luna', 'Cat', 'Bengal', 1, 'Female', 'Healthy, spayed', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (5, 'Tweety', 'Bird', 'Canary', 2, 'Female', 'Recovered from leg injury', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (6, 'Max', 'Dog', 'German Shepherd', 4, 'Male', 'Vaccinated, slight limp', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (7, 'Snowy', 'Cat', 'Siamese', 3, 'Male', 'Healthy', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (8, 'Goldie', 'Fish', 'Goldfish', 1, 'Female', 'Healthy, active', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (9, 'Sky', 'Bird', 'Macaw', 5, 'Male', 'Recently vaccinated', 'Available', NULL);

INSERT INTO Pets (PetID, Name, Species, Breed, Age, Gender, MedicalDetails, Status, MedicalHistoryID)
VALUES (10, 'Spark', 'Dog', 'Poodle', 2, 'Female', 'Has anxiety issues', 'Available', NULL);


ALTER TABLE Pets
ADD Inquiries NUMBER(38) DEFAULT 0;

CREATE TABLE FosterRequests (
    RequestID INT PRIMARY KEY,
    PetID INT,
    UserID INT,
    RequestDate DATE,
    Status VARCHAR(20) CHECK (Status IN ('Pending', 'Approved', 'Rejected')),
    FOREIGN KEY (PetID) REFERENCES Pets(PetID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);


CREATE SEQUENCE FosterRequestsSeq
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;


CREATE OR REPLACE PACKAGE PetPkg AS
    PROCEDURE GetAdoptedPetsByUser(
        p_UserID    IN NUMBER,
        out_cursor  OUT SYS_REFCURSOR
    );
END PetPkg;
/

CREATE OR REPLACE PACKAGE BODY PetPkg AS
    PROCEDURE GetAdoptedPetsByUser(
        p_UserID    IN NUMBER,
        out_cursor  OUT SYS_REFCURSOR
    ) 
    IS
    BEGIN
        OPEN out_cursor FOR
            SELECT p.PetID, p.Name, p.Species, p.Breed, p.Age, p.Gender, ar.AdoptionDate
            FROM Pets p
            JOIN AdoptionRecords ar ON p.PetID = ar.PetID
            WHERE ar.UserID = p_UserID;
    END;
END PetPkg;
/

