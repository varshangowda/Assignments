 use ASS2
 1)
 select empno,ename 
 from EMPY
 where job like 'manager'
 2)
 select ename,salary
 from EMPY
 where salary >1000
 3)
 select ename,salary
 from EMPY
 where ename not like 'james'
 4)
 select  * from EMPY
 where ename like 's%'
 5)
 select ename
 from EMPY
 where ename like '%a%'
 6)
 select ename
 from EMPY
 where  ename like '__l%'
 7)
 select salary/30 as daily_salary
 from EMPY
 where ename='jones'
 8)
 select sum(salary) as monthly_salary
 from empy
 9)
 select avg(salary)*12 as average_salary
 from EMPY

 SELECT avg(salary) as annual_salary
FROM EMPY;

10)select ename,job,salary,deptno
from EMPY
where job not like 'salesman' and  not deptno =30
11)
select distinct deptno
from empy
12)
select ename as employee, salary *12 as monthly_salary
from EMPY
where salary*12 > 1500 and (deptno=10 or deptno=30)

13)
select ename,job,salary
from EMPY
where job= 'manager' or job= 'analyst' and salary not in(1000,3000,5000)
14)
select ename,salary,comm
from EMPY
where comm>salary*1.1
15)
select ename 
from empy
where ename like'%ll% ' and deptno=30 or mgr_id=7782
16))
select count(ename ) 
from EMPY
where DATEDIFF(year,hiredate,10-09-2023)>30 and datediff(year,hiredate,10-09-2023)<40

select ename,hiredate,DATEDIFF(year,hiredate,'10-09-2023') as experience_in_yrs
from EMPY
where DATEDIFF(year,hiredate,'10-09-2023')>30 and DATEDIFF(year,hiredate,'10-09-2023')<40


17)
select e.ename,d.dname
from EMPY as e
join DEP as d on d.deptno=e.deptno
order by d.dname asc,e.ename desc

18)
select ename,hiredate,DATEDIFF(year,hiredate,'10-09-2023') as experience_in_yrs
from EMPY
where ename like'miller'