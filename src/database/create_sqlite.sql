CREATE TABLE categorias ( 
	id_categoria         integer NOT NULL PRIMARY KEY autoincrement ,
	nome                 text NOT NULL    ,
	CONSTRAINT pk_categorias UNIQUE ( id_categoria ) ,
	CONSTRAINT pk_categorias UNIQUE ( id_categoria ) 
 );

CREATE TABLE jogos ( 
	id_jogo              integer NOT NULL  PRIMARY KEY autoincrement ,
	id_categoria         integer NOT NULL    ,
	nome                 text NOT NULL    ,
	joguei               integer NOT NULL    ,
	CONSTRAINT pk_jogos UNIQUE ( id_jogo, id_categoria ) ,
	CONSTRAINT Pk_jogos_id_jogo_0 UNIQUE ( id_jogo ) ,
	CONSTRAINT Pk_jogos_id_jogo_0 UNIQUE ( id_jogo ) ,
	FOREIGN KEY ( id_categoria ) REFERENCES categorias( id_categoria )  
 );

