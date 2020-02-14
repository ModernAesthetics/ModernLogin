# ModernLogin
Simple C# Login Form and User Registration Form using MSSQL.

![alt text](https://i.imgur.com/YCZlaTZ.png "Login Form")
![alt text](https://i.imgur.com/l84VhHJ.png "Add User Form")

# MSSQL Procedure
```
USE [testDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_Login]    Script Date: 2/14/2020 10:32:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_Login] (
@email varchar(50)
, @password varchar(100)
)
as
begin
--select the number of users that match the inputted email and password
select count(*) 
from dbo.Users
where email = @email
and password = hashbytes('sha2_512', @password + cast(salt as nvarchar(36)))
end
```

# ToDo
* Finish Add User procedure so "USER REGISTRATION" form works.
* Better Secure MSSQL Connection Info
* Create Admin and User "Groups"
* Change login button function to be smart about user login "group"
* Possibly change MSSQL to MySQL or MariaDB
