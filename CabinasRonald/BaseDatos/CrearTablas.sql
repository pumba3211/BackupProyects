


CREATE TABLE cabina
(
  id serial NOT NULL,
  televizor integer,
  abanico integer,
  ducha integer,
  cama integer,
  camamatrimonial integer,
  CONSTRAINT pk_cabina PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE cabina
  OWNER TO "CabinasRonald";


CREATE TABLE cliente
(
  id serial not null,
  cedula character varying(255),
  nombre character varying(50),
  apellidos character varying(200),
  visitas integer,
  primeravisita time without time zone,
  ultimavisita time without time zone,
  CONSTRAINT pk_cliente PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE cliente
  OWNER TO "CabinasRonald";


CREATE TABLE fotos
(
  id serial NOT NULL,
  nombre character varying(50),
  extencion nombre character varying(50),
  imagenurl nombre character varying(255)
  CONSTRAINT pk_foto PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE fotos
  OWNER TO "CabinasRonald";


CREATE TABLE fotos_cabina
(
  id serial NOT NULL,
  id_foto integer,
  id_cabina integer,
  CONSTRAINT pk_foto_cabina PRIMARY KEY (id),
  CONSTRAINT fk_cabina FOREIGN KEY (id_cabina)
      REFERENCES cabina (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT fk_foto FOREIGN KEY (id_foto)
      REFERENCES fotos (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE fotos_cabina
  OWNER TO "CabinasRonald";


CREATE TABLE fotos_cliente
(
  id serial NOT NULL,
  id_foto integer,
  id_cliente integer,
  CONSTRAINT pk_foto_cliente PRIMARY KEY (id),
  CONSTRAINT fk_cliente FOREIGN KEY (id_cliente)
      REFERENCES cliente (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT fk_foto FOREIGN KEY (id_foto)
      REFERENCES fotos (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE fotos_cliente
  OWNER TO "CabinasRonald";


CREATE TABLE reservacion
(
  id serial NOT NULL,
  id_cabina integer,
  id_cliente integer,
  fecha_reservacion time with time zone,
  fecha_cancelacion time without time zone,
  factura integer,
  cantpersonas integer,
  CONSTRAINT pk_reservacion PRIMARY KEY (id),
  CONSTRAINT "fK_cliente" FOREIGN KEY (id_cliente)
      REFERENCES cabina (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT fk_cabina FOREIGN KEY (id_cabina)
      REFERENCES cabina (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE reservacion
  OWNER TO "CabinasRonald";
CREATE TABLE usuario
(
  id serial NOT NULL,
  usuario character varying(50),
  password character varying(255)[],
  tipo smallint,
  CONSTRAINT pk_usuario PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE usuario
  OWNER TO "CabinasRonald";
