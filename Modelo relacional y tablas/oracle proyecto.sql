CREATE TABLE Generos (
  id_genero NUMERIC(1),
  descripcion VARCHAR(20),
  constraint pk_genero primary key(id_genero)
);

CREATE TABLE TecsNM (
  id_tec NUMERIC(2),
  nombre VARCHAR(60),
  constraint pk_tecsNm primary key(id_tec)
);

CREATE TABLE Carreras (
  id_carrera NUMERIC(2),
  id_tec NUMERIC(2),
  nombre VARCHAR(80),
  constraint pk_carreras primary key(id_carrera),
  constraint fk_CtecNm foreign key(id_tec)references TecsNM(id_tec)
);

CREATE TABLE Departamentos (
  id_departamento NUMERIC(2),
  id_tec NUMERIC(2),
  descripcion VARCHAR(60),
  constraint pk_Departamentos primary key(id_departamento),
  constraint fk_DTecsNm foreign key(id_tec)references TecsNM(id_tec)
);

CREATE TABLE Alumnos (
  no_control INTEGER,
  id_genero NUMERIC(1),
  id_carrera NUMERIC(2),
  id_equipo NUMERIC(2),
  id_tec NUMERIC(2),
  nombre VARCHAR(30),
  paterno VARCHAR(30),
  materno VARCHAR(30),
  constraint pk_Alumnos primary key(no_control),
  constraint fk_AGeneros foreign key(id_genero)references Generos(id_genero),
  constraint fk_ATecsNM foreign key(id_tec)references TecsNM(id_tec),
  constraint fk_ACarreras foreign key(id_carrera)references Carreras(id_carrera)
);

CREATE TABLE Entrenadores (
  id_entrenador NUMERIC(3),
  id_genero NUMERIC(1),
  id_tec NUMERIC(2),
  id_departamento NUMERIC(2),
  nombre VARCHAR(30),
  paterno VARCHAR(30),
  materno VARCHAR(30),
  constraint pk_Entrenadores primary key(id_entrenador),
  constraint fk_EGeneros foreign key(id_genero)references Generos(id_genero),
  constraint fk_ETecsNM foreign key(id_tec)references TecsNM(id_tec),
  constraint fk_EDepartamento foreign key(id_departamento)references Departamentos(id_departamento)
);

CREATE TABLE EquiposDeportivos (
  id_equipo NUMERIC(2),
  Entrenadores_id_entrenador NUMERIC(3),
  nombre VARCHAR(100),
  id_tec NUMERIC(2),
  constraint pk_Equipos primary key(id_equipo),
  constraint fk_EEntrenadores foreign key(Entrenadores_id_entrenador)references Entrenadores(id_entrenador),
  constraint fk_EEtecNm foreign key(id_tec)references TecsNM(id_tec)
);

CREATE TABLE Alumnos_has_EquiposDeportivos (
  Alumnos_no_control INTEGER,
  EquiposDeportivos_id_equipo NUMERIC(2),
  constraint pk_AEAlumnos primary key(Alumnos_no_control,EquiposDeportivos_id_equipo),
  constraint fk_AEDeportivos foreign key(EquiposDeportivos_id_equipo)references EquiposDeportivos(id_equipo),
  constraint fk_AEAlumnos foreign key(Alumnos_no_control)references Alumnos(no_control)
);

CREATE TABLE Participaciones (
  id_equipo NUMERIC(2),
  fecha_participa DATE,
  EquiposDeportivos_id_equipo NUMERIC(2),
  constraint pk_PParticipantes primary key(id_equipo,fecha_participa),
  constraint fk_PEDeportivos foreign key(EquiposDeportivos_id_equipo)references EquiposDeportivos(id_equipo)
);