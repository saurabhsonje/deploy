
create database Sample;

use Sample;

create table studio (SId int NOT NULL,SName varchar(20) NOT NULL , Primary Key (SId));


insert into Studio values(1,'PROCESS AUTOMATION');
insert into Studio values(2,'SCALABLE');


----------------------------------------------------------------------------------------------
create table employee(EId int NOT NULL,FirstName varchar(20) NOT NULL,
 LastName varchar(20) , SId int , Primary Key (EId) , Foreign Key (SId) references studio(SId))

insert into Employee values(1,'ASD','QWE',1);
insert into Employee values(2,'ABC','XYZ',1);
insert into Employee values(3,'JKL','MNO',2);

delete from employee where EID =3;
update employee set FirstName ='BBD',LastName='DFG' where EID=1;
---------------------------------------------------------------------------------------------
create table project (PId int NOT NULL ,PName varchar(20) NOT NULL,Primary Key (PID));

insert into project values(1,'IQMS')
insert into project values(2,'DISNEY')

------------------------------------------------------------------------------------------------
create table employee_project__mapping(Id int NOT NULL, EId int NOT NULL, PId int NOT NULL, Primary Key (Id) ,
 Foreign Key (EId) references employee(EID) ,  Foreign Key (PId) references project(PId));

insert into employee_project__mapping values (1,1,1);
----------------------------------------------------------------------------------------------
create table project_studio_mapping(Id int , PId int , SId int , Primary Key (Id) ,
 Foreign Key (PId) references project(PID) ,  Foreign Key (SId) references studio(SID));

insert into project_studio_mapping values(1,1,1);
---------------------------------------------------------------------------------------------->


--	QUERY WHICH GIVES ALL DETAIL OF EMPLOYEES
select employee.FirstName , project.PName as ProjectName,studio.SName as StudioName from employee JOIN employee_project__mapping on 
employee.EId = employee_project__mapping.EId JOIN project on employee_project__mapping.PId = project.PId JOIN studio
on employee.SId = studio.SId;






















