create database empresaTI17T;
use empresaTI17T;

create table pessoa(
	CPF bigint not null primary key auto_increment,
    nome varchar(100) not null,
    telefone varchar(14) not null,
    cidade varchar(15) not null,
    UF varchar(3) not null
)engine = InnoDB;

insert into pessoa(CPF, nome, telefone, cidade, UF)
values('','','','','');

