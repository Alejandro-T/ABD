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
  id_tec numeric(5),
  constraint pk_AEAlumnos primary key(Alumnos_no_control,EquiposDeportivos_id_equipo),
  constraint fk_AEDeportivos foreign key(EquiposDeportivos_id_equipo)references EquiposDeportivos(id_equipo),
  constraint fk_AEAlumnos foreign key(Alumnos_no_control)references Alumnos(no_control),
  constraint fk_AETEC foreign key(id_tec) references Tecsnm(id_tec)
);

CREATE TABLE Participaciones (
  id_equipo NUMERIC(5),
  id_tec numeric(5),
  fecha_participa DATE,
  constraint pk_PParticipantes primary key(id_equipo,fecha_participa),
  constraint fk_PEDeportivos foreign key(id_equipo)references EquiposDeportivos(id_equipo),
  constraint fk_PEIDTEC foreign key(id_tec)references tecsnm(id_Tec)
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

create or replace procedure insertar_PARTICIPACIONES
(PARTICIPACIONES_ID_EQUIPO numeric,PARTICIPACIONES_id_tec numeric,PARTICIPACIONES_FECHA_PARTICIPA DATE)
as
begin
      insert into PARTICIPACIONES(ID_EQUIPO,id_tec,FECHA_PARTICIPA) 
      values(PARTICIPACIONES_ID_EQUIPO,PARTICIPACIONES_id_tec,PARTICIPACIONES_FECHA_PARTICIPA);
end insertar_PARTICIPACIONES;
/




create or replace procedure insertar_entrena
(entrena_id numeric,entrena_id_genero numeric,entrena_id_tec numeric,entrena_id_depto numeric,entrena_nombre varchar2,entrena_paterno varchar2,entrena_materno varchar2)
as
begin
      insert into entrenadores(ID_ENTRENADOR,id_genero,id_tec,id_departamento,nombre,paterno,materno) 
      values(entrena_id,entrena_id_genero,entrena_id_tec,entrena_id_depto,lower(entrena_nombre),lower(entrena_paterno),lower(entrena_materno));
end insertar_entrena;
/	



create or replace procedure insertar_Arm_Eq
(ALUMNOS_NO_CONTROL_IN numeric,EQUIPOSDEPORTIVOS_ID_EQUIPO_IN numeric,ID_TEC_IN numeric)
as
begin
      insert into ALUMNOS_HAS_EQUIPOSDEPORTIVOS(ALUMNOS_NO_CONTROL,EQUIPOSDEPORTIVOS_ID_EQUIPO,ID_TEC) 
      values(ALUMNOS_NO_CONTROL_IN,EQUIPOSDEPORTIVOS_ID_EQUIPO_IN,ID_TEC_IN);
end insertar_Arm_Eq;
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
update departamentos set descripcion = lower(nombrein),id_departamento=id_deptoin
where(id_departamento)=id_deptoin;
end ACTUALIZADEPTO;
/


CREATE OR REPLACE PROCEDURE  ACTUALIZAENTRENA (ID_ENTRENADORIN numeric,ID_GENEROIN numeric,ID_TECIN numeric,ID_DEPARTAMENTOIN numeric,NOMBREIN varchar2,PATERNOIN varchar2,MATERNOIN varchar2)
as
begin
update ENTRENADORES set id_genero = ID_GENEROIN,id_departamento=ID_DEPARTAMENTOIN,nombre = lower(nombrein),paterno=lower(PATERNOIN),MATERNO=lower(MATERNOIN)
where(id_ENTRENADOR)=ID_ENTRENADORIN;
end ACTUALIZAENTRENA;
/


CREATE OR REPLACE PROCEDURE  ACTUALIZALUMNOS (NO_CONTROLIN numeric,ID_GENEROIN numeric,ID_TECIN numeric,ID_CARRERAIN numeric,NOMBREIN varchar2,PATERNOIN varchar2,MATERNOIN varchar2)
as
begin
update ALUMNOS set id_genero = ID_GENEROIN,id_CARRERA=ID_CARRERAIN,nombre = lower(nombrein),paterno=lower(PATERNOIN),MATERNO=lower(MATERNOIN)
where(NO_CONTROL)=NO_CONTROLIN;
end ACTUALIZALUMNOS;
/





CREATE OR REPLACE PROCEDURE  ACTUALIZEQDEP (ID_EQUIPOIN numeric,ENTRENADORES_ID_ENTRENADORIN numeric,NOMBREIN VARCHAR2)
as
begin
update equiposdeportivos set ENTRENADORES_ID_ENTRENADOR = ENTRENADORES_ID_ENTRENADORIN, NOMBRE=NOMBREIN
where(ID_EQUIPO)=ID_EQUIPOIN;
end ACTUALIZEQDEP;
/







CREATE OR REPLACE PROCEDURE  ACTUALIZEQAGRE (ALUMNOS_NO_CONTROLIN numeric,EQUIPOSDEPORTIVOS_ID_EQUIPOIN numeric,ID_TECIN numeric)
as
begin
update ALUMNOS_HAS_EQUIPOSDEPORTIVOS set ALUMNOS_NO_CONTROL = ALUMNOS_NO_CONTROLIN, EQUIPOSDEPORTIVOS_ID_EQUIPO=EQUIPOSDEPORTIVOS_ID_EQUIPOIN
where(ALUMNOS_NO_CONTROL)=ALUMNOS_NO_CONTROLIN;
end ACTUALIZEQAGRE;
/

CREATE OR REPLACE PROCEDURE  ACTUALIZEQAGRE (ALUMNOS_NO_CONTROLIN numeric,EQUIPOSDEPORTIVOS_ID_EQUIPOIN numeric, EQUIPOSDEPORTIVOS_NUEVO numeric)
as
begin
update ALUMNOS_HAS_EQUIPOSDEPORTIVOS set 
EQUIPOSDEPORTIVOS_ID_EQUIPO = EQUIPOSDEPORTIVOS_NUEVO
where (ALUMNOS_NO_CONTROL, EQUIPOSDEPORTIVOS_ID_EQUIPO) 
IN  (SELECT ALUMNOS_NO_CONTROL, EQUIPOSDEPORTIVOS_ID_EQUIPO 
FROM ALUMNOS_HAS_EQUIPOSDEPORTIVOS 
WHERE ALUMNOS_NO_CONTROL = ALUMNOS_NO_CONTROLIN 
AND EQUIPOSDEPORTIVOS_ID_EQUIPO = EQUIPOSDEPORTIVOS_ID_EQUIPOIN);
end ACTUALIZEQAGRE;
/



CREATE OR REPLACE PROCEDURE  ACTUALIZPARTI (PARTI_ID_EQUIPOIN numeric,PARTI_FECHAIN DATE, FECHA_PARTICIPA_NUEVO DATE)
as
begin
update PARTICIPACIONES set 
FECHA_PARTICIPA = FECHA_PARTICIPA_NUEVO
where (ID_EQUIPO, FECHA_PARTICIPA) 
IN  (SELECT ID_EQUIPO, FECHA_PARTICIPA 
FROM PARTICIPACIONES 
WHERE ID_EQUIPO = PARTI_ID_EQUIPOIN
AND FECHA_PARTICIPA = PARTI_FECHAIN);
end ACTUALIZPARTI;
/
