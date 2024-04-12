CREATE DATABASE Sandile_Store;

USE Sandile_Store;

CREATE TABLE PRODUCTS (
 Name_ varchar(255) NOT NULL,
 Quantity int NOT NULL,
 Price decimal(10, 2) NOT NULL,
 Stock decimal(10,2) NOT NULL,
 );


SELECT * FROM PRODUCTS WHERE Quantity < 5

SELECT * FROM PRODUCTS;