CREATE TABLE Generos (
  id_genero NUMERIC(5),
  descripcion VARCHAR(20),
  constraint pk_genero primary key(id_genero)
);

CREATE TABLE TecsNM (
  id_tec NUMERIC(5),
  nombre VARCHAR(60),
  constraint pk_tecsNm primary key(id_tec)
);

CREATE TABLE Carreras (
  id_carrera NUMERIC(5),
  id_tec NUMERIC(5),
  nombre VARCHAR(80),
  constraint pk_carreras primary key(id_carrera),
  constraint fk_CtecNm foreign key(id_tec)references TecsNM(id_tec)
);

CREATE TABLE Departamentos (
  id_departamento NUMERIC(5),
  id_tec NUMERIC(5),
  descripcion VARCHAR(60),
  constraint pk_Departamentos primary key(id_departamento),
  constraint fk_DTecsNm foreign key(id_tec)references TecsNM(id_tec)
);

CREATE TABLE Alumnos (
  no_control INTEGER,
  id_genero NUMERIC(5),
  id_carrera NUMERIC(5),
  id_equipo NUMERIC(5),
  id_tec NUMERIC(5),
  nombre VARCHAR(30),
  paterno VARCHAR(30),
  materno VARCHAR(30),
  constraint pk_Alumnos primary key(no_control),
  constraint fk_AGeneros foreign key(id_genero)references Generos(id_genero),
  constraint fk_ATecsNM foreign key(id_tec)references TecsNM(id_tec),
  constraint fk_ACarreras foreign key(id_carrera)references Carreras(id_carrera)
);

CREATE TABLE Entrenadores (
  id_entrenador NUMERIC(5),
  id_genero NUMERIC(5),
  id_tec NUMERIC(5),
  id_departamento NUMERIC(5),
  nombre VARCHAR(30),
  paterno VARCHAR(30),
  materno VARCHAR(30),
  constraint pk_Entrenadores primary key(id_entrenador),
  constraint fk_EGeneros foreign key(id_genero)references Generos(id_genero),
  constraint fk_ETecsNM foreign key(id_tec)references TecsNM(id_tec),
  constraint fk_EDepartamento foreign key(id_departamento)references Departamentos(id_departamento)
);

CREATE TABLE EquiposDeportivos (
  id_equipo NUMERIC(5),
  Entrenadores_id_entrenador NUMERIC(5),
  nombre VARCHAR(100),
  id_tec NUMERIC(5),
  constraint pk_Equipos primary key(id_equipo),
  constraint fk_EEntrenadores foreign key(Entrenadores_id_entrenador)references Entrenadores(id_entrenador),
  constraint fk_EEtecNm foreign key(id_tec)references TecsNM(id_tec)
);

CREATE TABLE Alumnos_has_EquiposDeportivos (
  Alumnos_no_control INTEGER,
  EquiposDeportivos_id_equipo NUMERIC(5),
  constraint pk_AEAlumnos primary key(Alumnos_no_control,EquiposDeportivos_id_equipo),
  constraint fk_AEDeportivos foreign key(EquiposDeportivos_id_equipo)references EquiposDeportivos(id_equipo),
  constraint fk_AEAlumnos foreign key(Alumnos_no_control)references Alumnos(no_control)
);

CREATE TABLE Participaciones (
  id_equipo NUMERIC(5),
  fecha_participa DATE,
  EquiposDeportivos_id_equipo NUMERIC(5),
  constraint pk_PParticipantes primary key(id_equipo,fecha_participa),
  constraint fk_PEDeportivos foreign key(EquiposDeportivos_id_equipo)references EquiposDeportivos(id_equipo)
);

CREATE SEQUENCE seq_genero_id_genero
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 

create or replace trigger generos_triger_auto
	before insert on generos
	for each row 
	begin 
	select seq_genero_id_genero.nextval
	into:new.id_genero
	from dual;
end;
/


CREATE SEQUENCE seq_departa_id_departa
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 

create or replace trigger departa_triger_auto
	before insert on departamentos
	for each row 
	begin 
	select seq_departa_id_departa.nextval
	into:new.ID_DEPARTAMENTO
	from dual;
end;
/





create or replace procedure insertar_genero
(genero_descr varchar2)
as
begin
      insert into generos(descripcion) 
      values(genero_descr);
end insertar_genero;
/




CREATE SEQUENCE seq_carrera_id_carrera
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 

create or replace trigger carrera_triger_auto
	before insert on carreras
	for each row 
	begin 
	select seq_carrera_id_carrera.nextval
	into:new.id_carrera
	from dual;
end;
/


create or replace procedure insertar_carreras
(carrera_id_tec numeric,carrera_nombre varchar2)
as
begin
      insert into carreras(id_tec,nombre) 
      values(carrera_id_tec,carrera_nombre);
end insertar_carreras;
/

create or replace procedure insertar_depto
(depto_id_tec numeric,depto_descr varchar2)
as
begin
      insert into departamentos(id_tec,DESCRIPCION) 
      values(depto_id_tec,depto_descr);
end insertar_depto;
/




CREATE OR REPLACE PROCEDURE  ACTUALIZACARRERAS (id_carrerain numeric,id_tecin numeric,nombrein varchar2)
as
begin
update carreras set nombre = nombrein,id_carrera=id_carrerain
where(id_carrera)=id_carrerain;
end ACTUALIZACARRERAS;
/






CREATE OR REPLACE PROCEDURE  ACTUALIZADEPTO (id_deptoin numeric,nombrein varchar2)
as
begin
update departamentos set descripcion = nombrein,id_departamento=id_deptoin
where(id_departamento)=id_deptoin;
end ACTUALIZADEPTO;
/