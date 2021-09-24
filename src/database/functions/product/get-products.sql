create or replace function production.get_products()
returns table(Id int, Name varchar(400),Description text,Price numeric(10,2))
language plpgsql
as
$$
begin
 return query select p.product_id as Id, p.name as Name, p.description as Description, p.standard_cost as Price
 from production.product p;
end;
$$;