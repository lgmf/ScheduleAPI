create database schedule
go

use schedule
go

create table contacts(
	id int identity(1,1) primary key,
	identifier varchar(8) default substring(cast(NEWID() as varchar(max)),1,8),
	first_name varchar(150) not null,
	last_name varchar(150),
	email varchar(150),
	avatar varchar(500),
	gender varchar(2) not null,
	is_favorite bit not null default 0,
	removed bit not null default 0,
)
go

begin tran

insert into dbo.contacts(first_name,last_name,email,avatar,gender)
values ('Luiz Guilherme', 'Mendes Ferrari', 'luiz.guilherme@forlogic.net','http://img.forlogic.net//Colaboradores/Luiz-Guilherme.png','m'),
	   ('Marcos Vinicius', 'Jacobs', 'marcos@forlogic.net','http://img.forlogic.net//Colaboradores/marcos1.png','m'),
       ('Jéssica', 'Ayumi Uehara', 'luiz.guilherme@forlogic.net','http://img.forlogic.net//Colaboradores/jessica-1.png','f')

--commit
--rollback
