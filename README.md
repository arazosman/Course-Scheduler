# Course-Scheduler
A course scheduler tool which written and designed in C# / Windows Form Application. It uses MySQL as database system.
Contributors: Osman Araz, Görkem Timur, Kıymet Çelebi, Muhammet Çeneli, Furkan Zerey, Seyfullah Eraslan.

## Prerequisites
MySQL Community Server and Visual Studio needs to be installed on your computer. You can get these here: https://dev.mysql.com/downloads/mysql/ and https://visualstudio.microsoft.com/vs/

## Database Creation
Before build the program, you need to create the database in MySQL. Open up the MySQL Community Server and import the *DATABASE.SQL* file into it.

## Installation
Open up the *YM.sln* file on Visual Studio and specify the server information on the *Helper.cs* file. Open up the file and edit the *connectionString* by changing the capitalized words. Note that the database name you created must be same in the *connectionString*. Then build it.

## Screenshots

- Login Page:

  ![Login Page](/screenshots/login.png)
  
  Note: To login as admin, type *admin* for both of user ID and password.
  
- Signup Page:

  ![Signup Page](/screenshots/signup.png)

- Courses Page:

  ![Courses Page](/screenshots/courses.png)

- Classes Page:

  ![Classes Page](/screenshots/classes.png)

- Students Page:

  ![Students Page](/screenshots/students.png)
  
- Student Courses:

  ![Student Courses](/screenshots/student_courses.png)
  
- Teachers Page:

  ![Teachers Page](/screenshots/teachers.png)
  
- Teacher Classes:

  ![Teacher Classes](/screenshots/teacher_classes.png)
