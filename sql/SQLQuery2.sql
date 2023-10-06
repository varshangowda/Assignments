CREATE DATABASE ASS2
USE ASS2

 create table EMPY(empno int primary key,ename varchar(10),job varchar(10),mgr_id int,hiredate date,salary bigint,comm int,deptno int foreign key references Dep(deptno))

 insert into EMPY(empno,ename,job,mgr_id,hiredate,salary,comm,deptno)
 values(7369,'SMITH','CLERK',7902 ,'17-DEC-80 ', 800,null, 20)
  insert into EMPY(empno,ename,job,mgr_id,hiredate,salary,comm,deptno)
   values(7499,'ALLEN ','SALESMAN',7698 ,'20-FEB-81 -80 ', 1600,300, 30),
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
		


 create table DEP(deptno int primary key,dname varchar(10),loc varchar(20))
 insert into  DEP values(10,'accounting','new york')
 insert into  DEP values(20,'research','dallas')
 insert into  DEP values(30,'sales','chicago')
 insert into  DEP values(40,'operations','boston')
 select * from DEP

 