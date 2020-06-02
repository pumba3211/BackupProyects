CREATE TABLE persona
(
  id serial,
  cedula character varying(40),
  nombre character varying(50),
  apellidos character varying(50),
  "años" integer,
  CONSTRAINT pk_persona PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE persona
  OWNER TO "Presentacion";
