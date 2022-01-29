/* Исходя из задания предпологается, что существует 3 таблицы: 
*
* products, с колонками product_id и product_name, которая содержит информацию о продуктах ,
* categories, с колонками category_id и category_name, которая содержит информацию о категориях,
* и таблица products_and_categories, с колонками product_id и category_id, в которой обе предыдущие 
* колонки объединены связью многие со многими.
*
* для решения задания требуется соединить третью таблицу с двумя предыдущими через LEFT JOIN
* что бы вместо id отображались имена.
*/

select product_name, category_name 
FROM products P 
LEFT JOIN products_and_categories PC 
ON P.product_id = PC.product_id 
LEFT JOIN categories С
ON PC.category_id = С.category_id;