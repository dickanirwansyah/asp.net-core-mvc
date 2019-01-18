create table product(
id int auto_increment,
name varchar(255) not null,
price double null,
quantity int null,
status boolean, 

constraint pk_product_id primary key(id)
);

/** test data **/
insert into product(name, price, quantity, status)
values ('iphone 5s', 1000, 10, true);
insert into product(name, price, quantity, status)
values ('iphone 4s', 9000, 20, true);
insert into product(name, price, quantity, status)
values ('samsung galaxy', 1000, 0, false);