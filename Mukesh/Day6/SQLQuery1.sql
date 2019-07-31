create database glb_emp_system;

use glb_emp_system

CREATE TABLE studio(s_ID int NOT NULL PRIMARY KEY, s_name nvarchar(30) NOT NULL, s_details nvarchar(50))

CREATE TABLE employee(e_ID int NOT NULL PRIMARY KEY, e_name nvarchar(30)NOT NULL,e_email nvarchar(30) NOT NULL,fk_ID int FOREIGN KEY REFERENCES studio(s_ID) NOT NULL)

CREATE TABLE Projects(p_ID int NOT NULL PRIMARY KEY, p_name nvarchar(30) NOT NULL, p_client nvarchar(50))

ALTER TABLE projects ADD PK_s_ID int

ALTER TABLE projects add constraint project_pkID_FK
FOREIGN KEY(PK_s_ID) REFERENCES studio(s_ID)

CREATE TABLE mapEmpPro(emp_ID int NOT NULL foreign key references employee(e_ID), pro_ID int NOT NULL foreign key references projects(p_ID))

insert into studio values('1','DC','DC Studio')
insert into studio values('2','UI','UI Studio')
insert into studio values('3','PA','PA Studio')
insert into studio(s_ID,s_name) values('4','AI')

insert into employee values('1','Rajesh','r@rj.com','1')
insert into employee values('2','Jiky','j@rj.com','1')
insert into employee values('3','Jraj','r@rr.com','2')
insert into employee values('4','Jak','jk@rj.com','3')

insert into projects(p_ID,p_name,p_client) values('1','pro1','client1')
insert into projects(p_ID,p_name,p_client) values('2','pro2','client2')
insert into projects(p_ID,p_name,p_client) values('3','pro3',null)
insert into projects(p_ID,p_name,p_client) values('4','pro4','client3')

insert into mapEmpPro values('1','1')
insert into mapEmpPro values('2','1')
insert into mapEmpPro values('1','2')
insert into mapEmpPro values('3','4')
insert into mapEmpPro values('4','1')

select * from studio
select * from Projects
select * from employee
select * from mapEmpPro

UPDATE employee 
SET e_name='Rakesh', e_email='rak@rrc.com'
where e_ID=1;

DELETE FROM studio WHERE s_ID=4

select * from studio