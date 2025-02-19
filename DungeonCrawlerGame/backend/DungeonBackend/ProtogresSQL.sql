CREATE DATABASE dungeon_crawler;
CREATE USER dungeon_user WITH ENCRYPTED PASSWORD 'password123';
GRANT ALL PRIVLEGES ON DATABASE dungeon_crawler TO dungeon_user;
\q