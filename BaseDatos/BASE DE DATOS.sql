
/***********************************************************************************************
--Creación de tablas
***********************************************************************************************/
--Drop TABLE personas
CREATE TABLE personas
(
	cedula		TCedula,
	nombre		VARCHAR(30)		NOT NULL,
	apellido1	VARCHAR(30)		NOT NULL,
	apellido2	VARCHAR(30)		NOT NULL,
	direccion	VARCHAR(200)	NOT NULL,
	sexo		Tsexo,
	CONSTRAINT pk_cedula_personas PRIMARY KEY (cedula),
	--CONSTRAINT d_direccion_personas default direccion ('Ciudad Quesada') 
)
GO
--ejemplo de asociación de un valor por defecto a una atributo de tabla.
--EXEC sp_bindefault 'DSEXO','PERSONAS.SEXO'

CREATE TABLE telefonos
(
	cedula		CHAR(11)	NOT NULL,  --NO es necesario definirlo de tipo TCedula, porque ya es foranea debe verificarlo
	telefono	TTelefono	NOT NULL,
	CONSTRAINT	pk_cedulaTelefono_telefonos	PRIMARY KEY (cedula,telefono),
	CONSTRAINT	fk_cedula_telefonos			FOREIGN KEY (cedula) REFERENCES PERSONAS
)
GO

CREATE TABLE correos
(
	cedula		CHAR(11)	NOT NULL,
	correo		TCorreo		NOT NULL,
	CONSTRAINT	pk_cedulaCorreo_telefonos	PRIMARY KEY (cedula,correo),
	CONSTRAINT	fk_cedula_correo			FOREIGN KEY (cedula) REFERENCES personas
)
GO

CREATE TABLE carreras
(
	idCarrera	TINYINT,
	nombre		VARCHAR(50) NOT NULL,
	siglas		CHAR(2)		NOT NULL, 
	CONSTRAINT	pk_idCarrera_carreras	PRIMARY KEY (idCarrera),
	CONSTRAINT	chk_siglas_carreras		CHECK (siglas LIKE '[A-Z][A-Z]')
)
GO

CREATE TABLE estudiantes
(
	cedula		CHAR(11)	NOT NULL,
	carne		INT,
	carrera		TINYINT		NOT NULL,
	CONSTRAINT	pk_cedula_estudiante	PRIMARY KEY NONCLUSTERED (cedula),
	CONSTRAINT	fk_cedula_estudiante	FOREIGN KEY (cedula)	REFERENCES personas,
	CONSTRAINT	fk_idCarrera			FOREIGN KEY (carrera)	REFERENCES carreras,
	CONSTRAINT	U_carne_estudiante		UNIQUE CLUSTERED (carne)
)
GO

CREATE TABLE profesores
(
	cedula			CHAR(11)		NOT NULL,
	especialidad	VARCHAR(50)		NULL, 
	CONSTRAINT		pk_cedula_profesor	PRIMARY KEY (cedula),
	CONSTRAINT		fk_cedula_profesor	FOREIGN KEY (cedula) REFERENCES personas
)
GO

CREATE TABLE cursos
(
	codigo			TCodigoCurso	NOT NULL,
	profesor		CHAR(11)		NULL,
	carrera			TINYINT			NOT NULL,
	nombre			VARCHAR(100)	NOT NULL,
	creditos		TINYINT			NOT NULL,
	teoria			TINYINT			NOT NULL,
	practica		TINYINT			NOT NULL,
	tipo			VARCHAR(11)		NOT NULL,	
	semestre		TINYINT			NOT NULL,			
	fechaCreacion	DATETIME		NULL,
	estado			TEstado			NOT NULL,
	CONSTRAINT		pk_codigo_cursos	PRIMARY KEY (codigo),
	CONSTRAINT		fk_profesor_cursos	FOREIGN KEY (profesor)	REFERENCES profesores,
	CONSTRAINT		fk_carrera_cursos	FOREIGN KEY (carrera)	REFERENCES carreras,
	CONSTRAINT		chk_tipo_cursos		CHECK		(tipo in ('Seminario','laboratorio','taller'))
)
GO

CREATE TABLE dependencias
(
	curso		CHAR(7),
	dependencia	CHAR(7),
	tipo		CHAR(1)	NOT NULL,
	CONSTRAINT	pk_curso_dependencias		PRIMARY KEY (curso,dependencia),
	CONSTRAINT	fk_curso_dependencias		FOREIGN KEY (curso)			REFERENCES cursos,
	CONSTRAINT	fk_dependencia_dependencias	FOREIGN KEY (dependencia)	REFERENCES cursos,
	CONSTRAINT	chk_tipo_dependencias		CHECK		(tipo in ('R','C')) --requisito o correquisito
)
GO

CREATE TABLE programas
(
	idPrograma	INT				IDENTITY (1,1),
	fecha		DATETIME		NULL,
	estado		TEstado,
	curso		TCodigoCurso	NOT NULL
	CONSTRAINT	pk_idPrograma_programas	PRIMARY KEY (idPrograma)
	CONSTRAINT	fk_curso_programas		FOREIGN KEY (curso)		REFERENCES cursos
)
GO

CREATE TABLE contenidos
(
	idContenido	INT				IDENTITY(1,1),
	programa	INT				NOT NULL,
	contenido	VARCHAR(100)	NOT NULL,		--TITULO DEL CONTENIDO DEL CURSO
	padre		INT				NULL,			--SUBCONTENIDOS DE INDICE SUPERIOR A 2
	orden		TINYINT			NOT NULL,		--ORDENAMIENTO DE LOS CONTENIDOS O SUBCONTENIDOS
	CONSTRAINT	pk_idContenido_contenidos	PRIMARY KEY (idContenido),
	CONSTRAINT	fk_programa_contenidos		FOREIGN KEY (programa)	REFERENCES programas,
	CONSTRAINT	fk_padre_contenidos			FOREIGN KEY (padre)		REFERENCES contenidos
)
GO

CREATE TABLE grupos
(
	idGrupo		INT		IDENTITY(1,1),
	curso		char(7)	NOT NULL,
	numeroGrupo	TINYINT NOT NULL,
	programa	INT		NOT NULL,
	semestre	TINYINT NOT NULL,
	anno		TINYINT NOT NULL,
	CONSTRAINT	pk_idGrupo_grupos	PRIMARY KEY				NONCLUSTERED (idGrupo),
	CONSTRAINT	U_idGrupo_grupos	UNIQUE					CLUSTERED (idGrupo,curso,NumeroGrupo),
	CONSTRAINT	chk_semestre_grupos	check		(semestre BETWEEN 1 AND 2),
	CONSTRAINT	fk_curso_grupos		FOREIGN KEY (curso)		REFERENCES cursos,
	CONSTRAINT	fk_programa_grupos	FOREIGN KEY (programa)	REFERENCES programas
)
GO
EXEC sp_bindefault 'DAnnoActual','grupos.anno'
GO

CREATE TABLE gruposEstudiantes
(
	idGrupo		INT			NOT NULL,
	estudiante	CHAR(11)	NOT NULL,
	nota		TINYINT		NOT NULL,
	estado		VARCHAR(3)	NOT NULL, --aprobado, Reprobaciones, abandonos, retiros
	CONSTRAINT	pk_idGrupoEstudanteEstado_gruposEstudiantes	PRIMARY KEY (idGrupo,estudiante,estado),
	CONSTRAINT	chk_estado_gruposEstudiantes				CHECK		(estado in ('A','R','RPA','RJ')),
	CONSTRAINT	fk_idgrupo_gruposEstudiantes				FOREIGN KEY (idGrupo)		REFERENCES grupos ,--on delete, upadate cascade
	CONSTRAINT	fk_estudiante_gruposEstudiantes				FOREIGN KEY (estudiante)	REFERENCES estudiantes
)
GO