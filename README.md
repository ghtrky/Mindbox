Ответ на второе задание:
```SQL
select p."Name", c."Name" from products p
left join products_categories pc on pc.productid = p.id 
left join categories c on c.id = pc.categoryid
```
