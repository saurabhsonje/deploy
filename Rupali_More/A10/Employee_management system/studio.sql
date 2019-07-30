use Employee_Management_System;

---------------creating table here---------------
CREATE TABLE Studio(
    studio_Id int NOT NULL PRIMARY KEY,
    Studio_name varchar(255) NOT NULL,
    studio_head varchar(255) NOT null,
	Emp_ID int FOREIGN KEY REFERENCES Employee(Emp_ID),
	Emp_project_Id int FOREIGN KEY REFERENCES Employee_Project(Emp_project_Id)
);


--------insert data in table-------------------
insert into Studio  values(1,'process automation','Gole sir',1,2);
insert into Studio  values(2,'Digital','xyz',2,3);
insert into Studio  values(3,'dot net ','Anil',1,2);

------------display all data-----------
select * from Studio