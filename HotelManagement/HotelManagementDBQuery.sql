-- User Table
CREATE TABLE [dbo].[User] (
    [username] NVARCHAR(255) PRIMARY KEY,
    [password] NVARCHAR(255) NOT NULL,
    [name] NVARCHAR(255) NOT NULL,
    [surname] NVARCHAR(255) NOT NULL,
    [gender] NVARCHAR(255) NOT NULL,
    [email] NVARCHAR(255) NOT NULL,
    [birthday] DATE NOT NULL,
    [role] NVARCHAR(50) NOT NULL
);
INSERT INTO [User] (username, password, name, surname, gender, email, birthday, role) values ('admin','admin','admin','admin','admin','admin','2001-01-01','Manager')
INSERT INTO [User] (username, password, name, surname, gender, email, birthday, role) values ('staff','staff','staff','staff','staff','staff','2001-01-01','Staff')
INSERT INTO [User] (username, password, name, surname, gender, email, birthday, role) values ('guest','guest','guest','guest','guest','guest','2001-01-01','Guest')
-- Room Inventory Table
CREATE TABLE [dbo].[RoomInventory] (
    [room_id] INT PRIMARY KEY,
    [room_type] NVARCHAR(100) NOT NULL,
    [capacity] INT NOT NULL,
    [amenities] NVARCHAR(255) NOT NULL,
    [price] DECIMAL(10, 2) NOT NULL,
    [status] BIT NOT NULL
);
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(0, '3 Bed #1', 3, '', '2400', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(1, '3 Bed #2', 3, '', '2400', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(2, '2 Bed #1', 2, '', '1500', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(3, '2 Bed #2', 2, '', '1500', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(4, '2 Bed #3', 2, '', '1500', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(5, '2 Bed #4', 2, '', '1500', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(6, '2 Bed #5', 2, '', '1500', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(7, '1 Bed #1', 1, '', '1000', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(8, '1 Bed #2', 1, '', '1000', 1)
INSERT INTO [RoomInventory](room_id, room_type, capacity, amenities, price,status) values(9, '1 Bed #3', 1, '', '1000', 1)

-- Reservation Table
CREATE TABLE [dbo].[Reservation] (
    [reservation_id] INT PRIMARY KEY,
    [guestname] NVARCHAR(255) NOT NULL,
    [room_id] INT NOT NULL,
    [check_in_date] DATE NOT NULL,
    [check_out_date] DATE NOT NULL,
    FOREIGN KEY ([guestname]) REFERENCES [dbo].[User]([username]) ON DELETE CASCADE,
    FOREIGN KEY ([room_id]) REFERENCES [dbo].[RoomInventory]([room_id]) ON DELETE CASCADE
);
--Reservation ID Counter
CREATE TABLE [dbo].[ReservationIDCounter] (
    [id] INT
);
INSERT INTO [ReservationIDCounter](id) values (0);

-- Reward Programs and Loyalty Points Table
CREATE TABLE [dbo].[RewardLoyalty] (
    [guestname] NVARCHAR(255),
    [loyalty_points] INT NOT NULL
    FOREIGN KEY ([guestname]) REFERENCES [dbo].[User]([username]) ON DELETE CASCADE
);

-- Claimed Rewards
CREATE TABLE [dbo].[Rewards] (
    [guestname] NVARCHAR(255) NOT NULL,
    [prize] NVARCHAR(255) NOT NULL,
    [count] INT NOT NULL,
    FOREIGN KEY ([guestname]) REFERENCES [dbo].[User]([username]) ON DELETE CASCADE,
);

-- Stored Procedure for New IDs for Reservations
CREATE PROCEDURE NewID
AS
DECLARE @old INT
SELECT @old = id FROM [dbo].[ReservationIDCounter]
SET @old = @old + 1
UPDATE [dbo].[ReservationIDCounter] SET id = @old
GO

-- Trigger for Adding Points to Users who Made Reservations
CREATE TRIGGER AddPoints
ON Reservation
AFTER INSERT
AS
BEGIN
    DECLARE @user NVARCHAR(255)
    DECLARE @point INT
    SELECT @user = guestname FROM inserted
    SELECT @point = loyalty_points FROM [RewardLoyalty] WHERE guestname = @user

    IF (NOT EXISTS(SELECT loyalty_points FROM [RewardLoyalty] WHERE guestname = @user)) BEGIN
        INSERT INTO [RewardLoyalty](guestname, loyalty_points) VALUES (@user, 5)
    END
    ELSE BEGIN
        SET @point = @point + 5
        UPDATE [RewardLoyalty] SET loyalty_points = @point WHERE guestname = @user
    END
END