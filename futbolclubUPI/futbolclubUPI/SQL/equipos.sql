

-- SQL = STRUCTURE QUERY LANGUAGE == LENGUAJE DE CONSULTA ESTRUCTURADO

--ESCRITURA Y LECTURA

--DBA - DATABASE ADMINISTRATOR

--DDL = DATA DEFINITION LANGUAGE ( CREATE, DROP, TRUNCATE)

--DML = DATA MANIPULATION LANGUAGE ( SELECT, INSERT, DELETE, UPDATE)

--DCL = DATA CONTROL LANGUAGE (GRANT, REVOKE)

-- TLC


--1 CREAR UNA BASE DE DATOS

  create database UHFC

  --2 CREAR LAS TABLAS

  create table jugador
  (
  id int,
   nombre varchar(50),
   edad int
  )

  create table entrenador
  (
  id int primary key identity(1,1),
  nombre varchar(50),
  titulos varchar(150),

  )


  --INGRESO DE REGISTROS 

  insert into jugador (id,nombre,edad) values (1,'kevin chamorro',25)
  insert into jugador (id,nombre,edad) values (2,'Douglas sequeira',22)

  --CONSULTA DE REGISTROS

  select id,nombre,edad from jugador
  select nombre from jugador
  select *from jugador where edad = 22

  select *from entrenador
  select *from jugador

  --BORRAR UN REGISTRO

  delete jugador where id = 1

  --ACTUALIZAR REGISTROS

  update jugador set edad = 20 where id = 2