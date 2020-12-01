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


CREATE SEQUENCE seq_departa_id_departa
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 


CREATE SEQUENCE seq_alum_id_alum
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 


CREATE SEQUENCE seq_carrera_id_carrera
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 


CREATE SEQUENCE seq_equipos_id_equipos
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 

CREATE SEQUENCE seq_entrena_id_entrena
START WITH 1
INCREMENT BY 1 
NOMAXVALUE; 


create or replace procedure insertar_genero
(id_genre numeric, genero_descr varchar2)
as
begin
      insert into generos(id_genero,descripcion) 
      values(id_genre,lower(genero_descr));
end insertar_genero;
/

create or replace procedure insertar_depto
(id_pto numeric,depto_id_tec numeric,depto_descr varchar2)
as
begin
      insert into departamentos(ID_DEPARTAMENTO,id_tec,DESCRIPCION) 
      values(id_pto,depto_id_tec,lower(depto_descr));
end insertar_depto;
/


create or replace procedure insertar_equipo
(id_eq numeric,entrena_id_entrena numeric,nombre_eq varchar2,eq_id_tec numeric)
as
begin
      insert into EQUIPOSDEPORTIVOS(ID_EQUIPO,ENTRENADORES_ID_ENTRENADOR,NOMBRE,ID_TEC) 
      values(id_eq,entrena_id_entrena,lower(nombre_eq),eq_id_tec);
end insertar_equipo;
/


create or replace procedure insertar_carreras
(carrera_id numeric,carrera_id_tec numeric,carrera_nombre varchar2)
as
begin
      insert into carreras(id_carrera,id_tec,nombre) 
      values(carrera_id,carrera_id_tec,lower(carrera_nombre));
end insertar_carreras;
/

create or replace procedure insertar_entrena
(entrena_id numeric,entrena_id_genero numeric,entrena_id_tec numeric,entrena_id_depto numeric,entrena_nombre varchar2,entrena_paterno varchar2,entrena_materno varchar2)
as
begin
      insert into entrenadores(ID_ENTRENADOR,id_genero,id_tec,id_departamento,nombre,paterno,materno) 
      values(entrena_id,entrena_id_genero,entrena_id_tec,entrena_id_depto,lower(entrena_nombre),lower(entrena_paterno),lower(entrena_materno));
end insertar_entrena;
/	

create or replace procedure insertar_alumno
(id_control numeric,alumno_id_genero numeric,entrena_id_carrera numeric,alumno_id_tec numeric,alumno_nombre varchar2,alumno_paterno varchar2,alumno_materno varchar2)
as
begin
      insert into alumnos(no_control,id_genero,id_carrera,id_tec,nombre,paterno,materno) 
      values(id_control,alumno_id_genero,entrena_id_carrera,alumno_id_tec,lower(alumno_nombre),lower(alumno_paterno),lower(alumno_materno));
end insertar_alumno;
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


CREATE OR REPLACE PROCEDURE  ACTUALIZAENTRENA (ID_ENTRENADORIN numeric,ID_GENEROIN numeric,ID_TECIN numeric,ID_DEPARTAMENTOIN numeric,NOMBREIN varchar2,PATERNOIN varchar2,MATERNOIN varchar2)
as
begin
update ENTRENADORES set id_genero = ID_GENEROIN,id_departamento=ID_DEPARTAMENTOIN,nombre = nombrein,paterno=PATERNOIN,MATERNO=MATERNOIN
where(id_ENTRENADOR)=ID_ENTRENADORIN;
end ACTUALIZAENTRENA;
/


CREATE OR REPLACE PROCEDURE  ACTUALIZALUMNOS (NO_CONTROLIN numeric,ID_GENEROIN numeric,ID_TECIN numeric,ID_CARRERAIN numeric,NOMBREIN varchar2,PATERNOIN varchar2,MATERNOIN varchar2)
as
begin
update ALUMNOS set id_genero = ID_GENEROIN,id_CARRERA=ID_CARRERAIN,nombre = nombrein,paterno=PATERNOIN,MATERNO=MATERNOIN
where(NO_CONTROL)=NO_CONTROLIN;
end ACTUALIZALUMNOS;
/

