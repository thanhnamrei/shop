create table if not exists production.product(
    product_id serial primary key,
    name varchar(400) not null,
    product_number varchar(50) not null,
    standard_cost numeric(10,2) not null,
    description text,
    product_subcategory_id smallint,
    sell_start_date timestamp,
    sell_end_date timestamp,
    modified_date timestamp
)

--insert into production.product(name,product_number,standard_cost,description,product_subcategory_id) values('Adjustable Race','AR-5381',98.77,'Sự kết hợp của những dải màu nổi bật và sinh động',1);