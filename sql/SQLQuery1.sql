create database assignment
use assignment



create  table Client(
client_id int primary key,
cname varchar(40)not null,
address varchar(30),
email varchar(30) unique,
phone varchar(10) ,
business varchar(20)not null,
)

insert into Client values(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing')
insert into Client values(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant')
insert into Client values(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller')
insert into Client values(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional')
select * from Client
----

create table Employees(empno int primary key,ename varchar(20) not null,job varchar(15),salary decimal(10,0) check (salary>0),
deptno int ,foreign key(deptno) references Departments(deptno))

insert into Employees values(7001,'sandeep','analyst',25000,10)
insert into Employees values(7002,'Rajesh','Designer',30000,10)
insert into Employees values(7003,'Madhav','Developer',40000,20)
insert into Employees values(7004,'Manoj','Developer',40000,20)
insert into Employees values(7005,'Abhay','Designer',35000,10)
insert into Employees values(7006,'Uma','Tester',30000,30)
insert into Employees values(7007,'Gita','TechWriter',30000,40)
insert into Employees values(7008,'Priya','Tester',35000,30)
insert into Employees values(7009,'Nutan','Developer',45000,20)
insert into Employees values(7010,'Smita','analyst',20000,10)
insert into Employees values(7011,'Anand','Project Mgr',65000,10)
select * from Employees

Create table Departments(deptno int primary key,dname varchar(15) not null,loc varchar(20))
insert into Departments values(10,'Design','Pune')
insert into Departments values(20,'Development','Pune')
insert into Departments values(30,'Testing','Mumbai')
insert into Departments values(40,'Document','Mumbai')
SELECT * FROM Departments








create table Project1(project_id int primary key,descr varchar(30)not null, start_date date,planned_end_date date,actual_end_date date,constraint p_end_dates check(actual_end_date>planned_end_date),budget bigint check (budget>0),client_id int foreign key(client_id) references Client(client_id))
insert into Project1 values(401,'inventory','01-APR-11','01-Oct-11','31-Oct-11',150000,1001)
insert into Project1 values(402,'Accounting','01-Aug-11','01-Jan-12',NULL,500000,1002)
insert into Project1 values(403,'Payroll','01-OCT-11','31-Dec-11',NULL,750000,1003)
insert into Project1 values(404,'Contact Mgmt','01-NOV-11','31-Dec-11',NULL,5000,1004)
select *from Project1



create table EmpProjectTasks(project_id int ,empno int,start_date date,end_date date,task varchar(25)not null,status varchar(15)not null, PRIMARY KEY (project_id, empno),
    FOREIGN KEY (project_id) REFERENCES Project1(project_id),
    FOREIGN KEY (Empno) REFERENCES Employees(Empno))

	INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES
    (401, 7001, '01-Apr-11', '20-Apr-11', 'System Analysis', 'Completed'),
    (401, 7002, '21-Apr-11', '30-May-11', 'System Design', 'Completed'),
    (401, 7003, '01-Jun-11', '15-Jul-11', 'Coding', 'Completed'),
    (401, 7004, '18-Jul-11',  '01-Sep-11',  'Coding', 'Completed'),
    (401, 7006,'03-Sep-11', '15-Sep-11',  'Testing', 'Completed'),
    (401, 7009, '18-Sep-11',  '05-Oct-11', 'Code Change', 'Completed'),
    (401, 7008,'06-Oct-11', '16-Oct-11', 'Testing', 'Completed'),
    (401, 7007, '06-Oct-11', '22-Oct-11',  'Documentation', 'Completed'),
    (401, 7011, '22-Oct-11',  '31-Oct-11', 'sign off','Completed'),
	(402, 7010,'01-Aug-11', '20-Aug-11', 'System Analysis', 'Completed'),
    (402, 7002, '22-Aug-11', '30-Aug-11',  'System Design', 'Completed'),
    (402, 7004, '01-Oct-11',  null, 'Coding','In progress')
	select *from EmpProjectTasks