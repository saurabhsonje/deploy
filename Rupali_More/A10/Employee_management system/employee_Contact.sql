use Employee_Management_System;

-----------------creating Employee table--------

CREATE TABLE Employee_Contact (
    Emp_Cont_Id int NOT NULL PRIMARY KEY,
    Street varchar(255) NOT NULL,
    City varchar(255) NOT null,
	Country varchar(255) ,
	phone_no int,
	email varchar(255),
    Emp_ID int FOREIGN KEY REFERENCES Employee(Emp_ID)
);

------insert data into table ----------
insert into Employee_Contact  values(1,'More','Mandane','India',1234567,'rupali@gmail.com',1);
insert into Employee_Contact  values(2,'Yerva','Solapur','India',1234567,'pooja@gmail.com',3);
insert into Employee_Contact  values(3,'Jha','Surat','UK',543767,'mukesh@gmail.com',2);
insert into Employee_Contact  values(4,'Yadav','Latur','USA',65437,'shubham@gmail.com',4);

----------Display all data----------
select * from Employee_Contact;