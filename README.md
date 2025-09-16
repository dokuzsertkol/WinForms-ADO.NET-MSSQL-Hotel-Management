# C#-WinForms-ADO.NET-MSSQL Hotel Management System
18 Jan 2024

The hotel management system was created using SQL Server and C# Windows Forms. It is intended to manage staff, reservations, and customer loyalty programs. With an emphasis on user roles, database integration, and business logic, this project showcases full-stack desktop application development.

## Project

Three user types are supported by the system, each with role-specific features:

### Guest
- Create an account and log in.
- Choose a room and the dates of check-in and check-out to make a reservation.
- With every reservation, you can accrue loyalty points.
- See both current and previous reservations.
- Exchange loyalty points for complimentary services.
- Access personal profile data.

### Staff
- Designate rooms as either maintenance or available.

### Manager
- Access the list of employees.
- See the list of clients.
- A user registration-style interface is used to add new employees.

## Utilized Technologies
- **C#** - GUI development for Windows Forms.
- Relational databases for users, rooms, reservations, and rewards are stored on a **SQL Server**.
- Database connectivity and queries are handled by **ADO.NET**.
- **Stored Procedures & Triggers** - Automate updates to loyalty points and increments to reservation IDs.

## Database Organization

- **User**: Holds user information and roles (Manager, Staff, Guest).
- **RoomInventory**: Lists room types, capacities, rates, and availability status.
- **Reservation**: Keeps track of reservations associated with rooms and users.
- **ReservationIDCounter**: Produces distinct reservation IDs.
- **RewardLoyalty**: Keeps track of each visitor's loyalty points.
- **Rewards**: Maintains track of rewards that have been claimed.
- Automates the creation of IDs and the distribution of loyalty points.
