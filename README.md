# .NET-MVC-Project
A project usnig ASP.NET Core MVC.  


<img src="images/home.gif">




# A) About:

## A-1) Topic:
This is a simple Social Application.

## A-2) Technologies Used:
1. ASP.NET Core
2. ASP.NET Core MVC
3. Entity Framework
4. Identity (Individual)





# B) Models:

## B-1) Identity (Individual):
This is used for Authentication.


## B-2) Post:
Users Create Posts

Fields:
- **`PostId`** (integer)
- **`Content`** (string)
- **`AuthorId`** (string) (Relationship with Identity Model)

The AuthorId is id of the user Who Created the Post.


## B-3) Comment:
Users Create Commnets Related to Posts.


Fields:
- **`CommentId`** (integer)
- **`Content`** (string)
- **`PostId`** (string) (Relationship with Post Model)
- **`AuthorId`** (string) (Relationship with Identity Model)

The AuthorId is id of the user Who Created the Comment.





# C) Authentication:

## C-1) Relax:
**This is not custom authentication.**  
It is built in and tested **Identity Authentication**.  


## C-2) Not Logged in User:
If the user is not logged in, then he will see **Login** and **Register**
Buttons.
<img src="images/new_user.gif">





## C-3) Registration:
Now, when clicking the Register button, the user will be taken to the registeration page.
<img src="images/register.gif">




## C-4) Logged In User:
Now, that the user is logged in, the navbar will change.
<img src="images/logged_in_user.gif">




## C-5) Logging Out:
The **Log Out** button will log you out, if you are logged in.
<img src="images/logout.gif">





## C-6) Manage Your Account:


When you click on the **Hello Button**, you will be able to manage your account.

<img src="images/hello.gif">


You can edit you Profile.

<img src="images/manage_profile.gif">

Email, password, 2FA and Personal Data.



















