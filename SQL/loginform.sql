create database loginform;

use loginform;

create table usuario(
id int unsigned not null auto_increment primary key,
nome varchar(64) not null,
usuario varchar(64) not null,
email varchar(64) not null,
senha varchar(32) not null
)engine=innodb;

insert into usuario values (null,"miguel","miguel","miguel@gmail.com","123");

select * from usuario;