CREATE DATABASE ASS2
USE ASS2

 create table EMPY(empno int primary key,ename varchar(10),job varchar(10),mgr_id int,hiredate date,salary bigint,comm int,deptno int foreign key references Dep(deptno))

 insert into EMPY(empno,ename,job,mgr_id,hiredate,salary,comm,deptno)
 values(7369,'SMITH','CLERK',7902 ,'17-DEC-80 ', 800,null, 20)
  insert into EMPY(empno,ename,job,mgr_id,hiredate,salary,comm,deptno)
   values(7499,'ALLEN ','SALESMAN',7698 ,'20-FEB-81 ', 1600,300, 30),
         (7521,'WARD','SALESMAN',7698 ,'22-FEB-81 ',  1250 ,500, 30),
		 (7566,'JONES','MANAGER',7839 ,'02-APR-81 ',   2975 ,null, 20),
		 (7654,'MARTIN','SALESMAN',7698 ,'28-SEP-81 ',  1250 ,1400, 30),
		 (7698,'BLAKE','MANAGER',7839 ,'01-MAY-81  ',  2850,null, 30),
		 (7782,'CLARK','MANAGER',7839 ,'09-JUN-81 ',2450 ,null, 10),
		 (7788,'SCOTT',' ANALYST ',7566 ,' 19-APR-87',3000,null, 20),
		 (7839,'KING','PRESIDENT',null ,'17-NOV-81  ', 5000,null, 10),
		 (7844 ,'TURNER','SALESMAN',7698 ,'08-SEP-81 ', 1500,0, 30),
		 (7876,' ADAMS ','CLERK',7788 ,'23-MAY-87 ', 1100 ,null, 20),
		 (7900,'JAMES','CLERK',7698 ,' 03-DEC-81 ', 950 ,null, 30),
		  (7902 ,' FORD',' ANALYST ',7566 ,'03-DEC-81 ', 3000,null, 20),
		 (7934,'MILLER','CLERK',7782 ,'23-JAN-82 ',  1300,null, 10)
		
		select *from EMPY


 create table DEP(deptno int primary key,dname varchar(10),loc varchar(20))
 insert into  DEP values(10,'accounting','new york')
 insert into  DEP values(20,'research','dallas')
 insert into  DEP values(30,'sales','chicago')
 insert into  DEP values(40,'operations','boston')
 select * from DEP
 1)
 select  ENAME
 from EMPY
 where ename LIKE 'A%'
 2)
 SELECT ENAME 
 FROM EMPY 
 WHERE not  job='manager'
 3)
 select ename,empno,salary
 from EMPY
 where salary between 1200 and 1400
 4)
 --10 % rise problem
update EMPY
set salary=salary*1.1
where deptno=20
select *from EMPY
where deptno=20
5)
 select count(*) as 'number of clerks employeed'
 from EMPY
 where job='clerk'
 6)
 SELECT JOB, AVG(salary) AS "Average Salary", COUNT(*) AS "Number of Employees"
FROM EMPY
GROUP BY JOB
 7)
 SELECT *
FROM EMPY
WHERE salary IN (SELECT MIN(salary) FROM EMPY) OR salary IN (SELECT MAX(salary) FROM EMPY)
8)
 select * from DEP 
 where deptno not in(select DISTINCT( deptno )from EMPY)
 9)
 select ename,salary
 from EMPY
 where  salary>= 1200 AND job='ANALYST'  and deptno=20
 order by ename asc
 SELECT * FROM EMPY
 10)
 select d.dname,d.deptno,sum(e.salary)as 'total salary'
 from DEP d,EMPY e
 left join EMPY  on e.deptno=e.deptno
 group by d.dname,d.deptno
11)
 select ename ,salary
 from EMPY
 where	ename in('miller','smith')
 12)
 select ename
 from EMPY
 where ename like 'a%' or ename like 'm%'
13)
 select salary * 12 as 'yearly salary',ename
 from EMPY
 where ename='smith'
14)
 select ename,salary
 from EMPY
 where salary not between 1500 and 2850
 15)
 select job,count(*) as 'employess repoting to managers'
 from EMPY
 where job ='manager'
 group by job
 having count(*)>2



 

