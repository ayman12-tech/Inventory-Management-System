create procedure st_getLoginDetails
@user varchar(30),
@pass varchar(30)
as
select u.u_username as 'Username',u.u_password as 'Password' from users u where u.u_username=@user and u.u_password=@pass