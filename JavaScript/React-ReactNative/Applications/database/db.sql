CREATE DATABASE database_links;

USE database_links;
CREATE TABLE users(
    id INT(11) NOT NULL,
    username VARCHAR(16) NOT NULL,
    password VARCHAR(16) NOT NULL,
    fullname VARCHAR(100) NOT NULL


);
USE database_links;
ALTER TABLE users
  modify password VARCHAR(60) NOT NULL;
use database_links;
ALTER TABLE users
    MODIFY id INT(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT =2;
use database_links;
select * from sessions;
DELETE FROM users WHERE id = 4;



--links tables
use database_links;
CREATE TABLE links(
    id int(11),
    title VARCHAR(150),
    url VARCHAR(100),
    description text,
    user_id int(11),
    created_at timestamp default current_timestamp,
    constraint fk_user FOREIGN KEY (user_id) REFERENCES users(id)
    );

use database_links;
select * from links;

use database_links;
alter table links
modify id int(11) not null AUTO_INCREMENT, AUTO_INCREMENT = 2;

