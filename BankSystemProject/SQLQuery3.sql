use[BankSysttem]
GO
CREATE TABLE Bank(
bank_name varchar(20) NOT NULL,
  bank_code INT primary key NOT NULL,
  bank_addr varchar(50)NOT NULL,
  
);
use[BankSysttem]
GO
create table Branches(
	branch_num INT PRIMARY KEY,
	branch_add varchar(50) NOT NULL,
	bank_code INT NOT NULL,
	FOREIGN KEY(bank_code) REFERENCES Bank(bank_code)
);

use[BankSysttem]
GO
create table Customer(
	cus_ass INT PRIMARY KEY NOT NULL,
    cus_address VARCHAR(250) NOT NULL,
    cus_name VARCHAR(50) NOT NULL,
    cus_phone INT NOT NULL,
	branch_num INT NOT NULL,
  FOREIGN KEY(branch_num) REFERENCES branches(branch_num)
);

use[BankSysttem]
GO
create table Account(
	acc_balance INT NOT NULL,
	acc_number INT NOT NULL PRIMARY KEY,
	acc_type varchar(25) NOT NULL,

);

alter table Account
add acc_pass varchar(30) not null

use[BankSysttem]
GO
CREATE TABLE Loan(
	loan_amount int,
	loan_number int PRIMARY KEY, 
	loan_type varchar(20) 

);

use[BankSysttem]
GO
create table Eployee(
	emp_id int primary key,
	emp_name varchar(20) not null,
	emo_salary float  not null,
	branch_num int ,
	foreign key(branch_num) REFERENCES Branches(branch_num)
	);

	alter table Eployee
	add emp_pass varchar(30) not null

use[BankSysttem]
GO
create table Admin(
	admin_id int primary key,
	admin_name varchar(20) not null,
	admin_salary float not null,
	admin_pass varchar(30) not null,
	bank_code int not null,
	foreign key(bank_code) REFERENCES Bank(bank_code)

);


CREATE TABLE hold_by
(
  ssn INT NOT NULL,
  account_number INT NOT NULL,
  PRIMARY KEY (ssn, account_number),
  FOREIGN KEY (ssn) REFERENCES customer(cus_ass),
  FOREIGN KEY (account_number) REFERENCES Account(acc_number)
);


use[BankSysttem]
GO

create table serve(
	ssn int not null,
	emp_id int not null,
	primary key (ssn, emp_id),
	FOREIGN KEY (ssn) REFERENCES customer(cus_ass),
	FOREIGN KEY (emp_id) REFERENCES Eployee(emp_id)

);

insert into Branches(branch_num, branch_add, bank_code) values(1,'cairo',001)
insert into Branches(branch_num, branch_add, bank_code) values(2, 'giza', 001)
insert into Branches(branch_num, branch_add, bank_code) values(3, 'alx', 001)
insert into Branches(branch_num, branch_add, bank_code) values(4, 'hurgada', 001)

insert into Customer values (1,'gize','ali','01122334',1)
insert into Customer values (2,'cairo','mohammed','011556334',4)
insert into Customer values (3,'alex','ahmed','011556334',2)
insert into Customer values (4,'hurgada','ashraf', '01208471066',2)

insert into Bank values('bank1','001','cairo')

insert into Eployee values (1,'ahmed',1500, 1,'ahmed12')
insert into Eployee values (2,'mohammed',2000, 3, 'moh12')
insert into Eployee values (3,'ali', 3000, 2, 'ali12')
insert into Eployee values (4,'alaa',1000, 1, 'alaa12')

insert into loan(loan_number,loan_type,loan_amount) values (1,'industry loan', 2000)
insert into loan(loan_number,loan_type,loan_amount) values (2,'commercial loan', 5000)
insert into loan(loan_number,loan_type,loan_amount) values (3,'commercial loan', 200)
insert into loan(loan_number,loan_type,loan_amount) values (4, 'Personal loan', 400)

insert into serve (ssn, emp_id) values (1,2)
insert into serve (ssn, emp_id) values (2,1)
insert into serve (ssn, emp_id) values (4,3)

insert into Account values (2000, 1, 'current', '1234')
insert into Account values (1000, 2, 'savin', '0000')
insert into Account values (500, 3, 'salary', '1111')

insert into Admin values (1, 'ali', 4000, '1234',001)
insert into Admin values (2, 'ahmed', 3000, 'ahm12',001)
insert into Admin values (3, 'khaled', 6000, 'kh00',001)