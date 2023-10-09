CREATE  DATABASE TEST 
use test

create table books1(id int primary key ,title varchar(20),author varchar(20),isbn  bigint not null unique,published_date datetime)
insert into books1 values(1,'my first sql book','mary parker',981483029127,'2012-02-22 12:08:17')
insert into books1 values(2,'my second sql book','john mayer',857300923713,'1972-07-03 09:22:45')
insert into books1 values(3,'my third sql book','cary flint',523120967812,'2015-10-18 14:05:44')
select * from books1


Q1)
select * 
from books1
where author like '%er'


Q2)
create table reviews1(id int foreign key references books1(id),book_id int,reviewer_name varchar(20),content varchar(20),rating int,published_date datetime)
insert into reviews1 values(1,1,'john smith','my first review',4,'2017-12-10 05:50:11')
insert into reviews1 values(2,2,'john smith','my second review',5,'2017-10-13 15:05:12')
insert into reviews1 values(3,2,'alice walker','another review',1,'2017-12-22 23:47:10')
select * from reviews1

SELECT title,author,reviewer_name
from books1 INNER JOIN reviews1
ON books1.id = reviews1.id;

Q3)
 select reviewer_name 
 from books1 
 inner join reviews1 on books1.id=reviews1.id 
 group by reviews1.reviewer_name
 having count(books1.id)>1

 create table customer(cust_id int primary key,name varchar(20),age int,address varchar(20),salary decimal(10,0))
 insert into customer values(1,'ramesh',32,'ahmedabad',2000.00)
  insert into customer values(2,'khilan',25,'delhi',1500.00)
   insert into customer values(3,'kaushik',23,'kota',2000.00)
    insert into customer values(4,'chaitali',25,'mumbai',6500.00)
	 insert into customer values(5,'hardik',27,'bhopal',8500.00)
	  insert into customer values(6,'komal',22,'mp',4500.00)
	   insert into customer values(7,'muffy',24,'indore',10000.00)
	   select * from customer

	   create table  orders(oid int primary key,datetiming datetime,cust_id int foreign key references customer(cust_id),amount bigint)
	   insert into orders values(104,'2009-10-08 00:00:00',3,3000)
	   	   insert into orders values(100,'2009-10-08 00:00:00',3,1500)
		   	   insert into orders values(101,'2009-11-20 00:00:00',2,1560)
			   	   insert into orders values(103,'2008-05-20 00:00:00',4,2060)
				  
 select * from orders
				   select address
				   from customer as c inner join orders as o  on c.cust_id=o.cust_id
				   where c.address like '%o%'
				   select * from customer where address like '%o%

				   SELECT
    o.datetiming AS Date,
    COUNT(DISTINCT c.cust_id) AS "Total no of customers"
FROM
    customer AS c
INNER JOIN
    "orders" AS o
ON
    c.cust_id = o.cust_id
WHERE
    c.Address LIKE '%o%'
GROUP BY
    o.datetiming
HAVING
    COUNT(DISTINCT c.cust_id) > 1;

	create table employee(id int primary key,name varchar(20),age int,address varchar(20),salary decimal(10,0))
	insert into employee values(1,'ramesh',32,'ahmedabad',2000.00)
	  insert into employee values(2,'khilan',25,'delhi',1500.00)
   insert into employee values(3,'kaushik',23,'kota',2000.00)
    insert into employee values(4,'chaitali',25,'mumbai',6500.00)
	 insert into employee values(5,'hardik',27,'bhopal',8500.00)
	   insert into customer values(7,'komal',22,'mp',null)
	  insert into customer values(8,'muffy',24,'indore',null)
	  select * from employee
	 
	select name 
	from employee
	where salary is null


		




		create table studentdetail(registerno int,name varchar(10),age int,qua varchar(10),mobileno bigint,mailid varchar(20) unique,loc varchar(10),gender char)
		insert into studentdetail values(2,'sai',22,'be',786787678,'sai@gmail.com','chennai','m')
				insert into studentdetail values(3,'kumar',20,'bsc',78678778998,'kum@gmail.com','madurai','m')
						insert into studentdetail values(4,'snisha',22,'be',786787678,'hsdgi@gmail.com','chennai','f')
								insert into studentdetail values(5,'nihali',25,'be',76356367363,'nsdbgy@gmail.com','chennai','f')
										insert into studentdetail values(6,'tom',21,'be',865677678,'bvsacti@gmail.com','chennai','m')
												insert into studentdetail values(7,'sai',22,'be',25272778,'hsdt@gmail.com','chennai','m')
												select * from studentdetail
		
											
		select gender ,count(*) as total
		from studentdetail
		group by gender