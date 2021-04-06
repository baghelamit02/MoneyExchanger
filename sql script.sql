create database MoneyChanger
use MoneyChanger

drop table ExchageRates
create table ExchageRates
(
Id varchar(100) primary key,
CurrencyCode varchar(10),
)


insert into ExchageRates
values (NEWID(), 'USD',1.3392,1.3574),
		(NEWID(),'HKD',0.1738,0.1698)


select * from ExchageRates

insert into ExchageRates
values (NEWID(), 'INR',1.5392,0)