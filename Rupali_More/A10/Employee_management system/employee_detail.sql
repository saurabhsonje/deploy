use Employee_Management_System;

--------creating table here--------------

CREATE TABLE Employee_Attendence_Detail (
   Emp_Attendence_id int NOT NULL PRIMARY KEY,
    AStatus varchar(255) NOT NULL,
    City varchar(255) NOT null,
	InTime Time ,
	OutTime Time,
	Emp_ID int FOREIGN KEY REFERENCES Employee(Emp_ID)
);

---------alter table---------
ALTER TABLE Employee_Attendence_Detail
DROP COLUMN City;

-----------------insert data here-------------
insert into Employee_Attendence_Detail  values(1,'p','10am','5pm',1);
insert into Employee_Attendence_Detail  values(2,'p','11am','4pm',2);
insert into Employee_Attendence_Detail  values(3,'A','10am','5pm',4);
insert into Employee_Attendence_Detail  values(4,'p','10am','5pm',3);

--------display all data --------------------

select * from Employee_Attendence_Detail