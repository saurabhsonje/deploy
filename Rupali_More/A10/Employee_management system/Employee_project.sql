use Employee_Management_System;

-------------------creating table here-------------

CREATE TABLE Employee_Project (
    Emp_project_Id int NOT NULL PRIMARY KEY,
    project_name varchar(255) NOT NULL,
    project_deadline Date,
	 );

	 -----------inserting data in table here-----------------
	 insert into Employee_Project  values(1,'Iqms','12-3-2020');
	 insert into Employee_Project  values(2,'dot net','11-3-2020');
	 insert into Employee_Project  values(3,'Iqms','11-4-2020');
	 insert into Employee_Project  values(4,'service now','12-3-2020');

	 -----------------displaying all data-------------

	 select * from Employee_Project;