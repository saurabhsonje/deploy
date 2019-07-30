use Employee_Management_System


--------selecting Employee Attendence detail with Employee Name

SELECT Employee_Attendence_Detail.AStatus,Employee_Attendence_Detail.InTime,Employee_Attendence_Detail.OutTime, Employee.Emp_Name
FROM Employee_Attendence_Detail
INNER JOIN Employee ON Employee_Attendence_Detail.Emp_ID=Employee.Emp_ID;


-----------------selecting employee name and Contact detail-----------------

SELECT Employee_Contact.Street,Employee_Contact.City,Employee_Contact.Country, Employee.Emp_Name
FROM Employee_Contact
INNER JOIN Employee on Employee_Contact.Emp_ID=Employee.Emp_ID;




-----------------provide employee phone number who belong to india--------------
SELECT Employee_Contact.phone_no, Employee.Emp_Name
FROM Employee_Contact
INNER JOIN Employee ON Employee_Contact.Country='India';


--------------selecting employee name ,project name and studio Id----------------------------------------

select Studio.Emp_ID ,Employee.Emp_Name,Employee_Project.project_name from Employee_Project Inner Join Studio on Employee_Project.Emp_project_Id=Studio.Emp_project_Id join Employee on Employee.Emp_ID=Studio.Emp_ID
