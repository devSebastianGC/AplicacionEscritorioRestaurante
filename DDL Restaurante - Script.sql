Create database Restaurante;
Use Restaurante;
/*-----------------------------------------Creacion de tablas------------------------------------------*/
--Tabla Categoria
create table categoria(
    id_categoria int identity not null,
    nombre_categoria NVARCHAR(100) not null,
    CONSTRAINT pk_categoria PRIMARY KEY(id_categoria),
    CONSTRAINT un_categoria unique(nombre_categoria)
);

--Tabla Menu
create table menu(
    id_menu int identity not null,
    nombre_menu NVARCHAR(100) not null,
    descripcion_menu NVARCHAR(300) not null,
    precio_menu float not null,
    CONSTRAINT pk_menu PRIMARY KEY(id_menu)
);

--Tabla de union Categoria y Menu
create table categoriaxmenu(
    id_categoria int not null,
    id_menu int not null,
    CONSTRAINT pk_categoriaxmenu PRIMARY KEY(id_menu, id_categoria),
    CONSTRAINT fk_categoriaxmenu1 FOREIGN KEY (id_menu) REFERENCES menu(id_menu),
    CONSTRAINT fk_categoriaxmenu2 FOREIGN KEY (id_categoria) REFERENCES categoria(id_categoria)
);

--Tabla Cliente
create table cliente(
    id_cliente int identity not null,
    nombre_cliente NVARCHAR(100) not null,
    genero_cliente NVARCHAR(100) not null,
    telefono_cliente NVARCHAR(100) not null,
    direccion_cliente NVARCHAR(100) not null,
    CONSTRAINT pk_cliente PRIMARY KEY(id_cliente)
);

--Tabla Domiciliario
create table domiciliario(
    id_domiciliario int identity not null,
    nombre_domiciliario NVARCHAR(100) not null,
    genero_domiciliario NVARCHAR(100) not null,
    telefono_domiciliario NVARCHAR(100) not null,
    CONSTRAINT pk_domiciliario PRIMARY KEY(id_domiciliario)
);

--Tabla Compra
create table compra(
	id_compra int identity not null,
    id_cliente int not null,
    id_domiciliario int not null,
    id_menu int not null,
    cantidad int not null,
    fecha_compra date not null,
    entrega_recibida NVARCHAR(100) not null,
    CONSTRAINT pk_compra PRIMARY KEY(id_compra),
    CONSTRAINT fk_compra1 FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
    CONSTRAINT fk_compra2 FOREIGN KEY (id_domiciliario) REFERENCES domiciliario(id_domiciliario),
    CONSTRAINT fk_compra3 FOREIGN KEY (id_menu) REFERENCES menu(id_menu)
);

/*------------------Procedimientos Categoria-----------------*/
--Procedimiento almacenado para mostrar categorias
create procedure mostrar_categoria
as begin
	select * from categoria
end;

--Procedimiento almacenado para insertar categoria
create procedure insertar_categoria
@nombre_cat NVARCHAR(100)
as begin
    insert into categoria(nombre_categoria) values(@nombre_cat);
end;

--Procedimiento almacenado para actualizar categoria
create procedure editar_categoria
@nombre_cat NVARCHAR(100),
@id_cat int
as begin
    update categoria set nombre_categoria = @nombre_cat where id_categoria = @id_cat;
end;

--Procedimiento almacenado para eliminar categoria
create procedure eliminar_categoria
@id_cat int
as begin
    delete from categoria where id_categoria = @id_cat;
end;


/*------------------Procedimientos Menu----------------------*/
--Procedimiento almacenado para mostrar menus
create procedure mostrar_menu
as begin
	select * from menu
end;

--Procedimiento almacenado para insertar menu
create procedure insertar_menu
@nombre_men NVARCHAR(100),
@descripcion_men NVARCHAR(300),
@precio_men float
as begin
    insert into menu(nombre_menu,descripcion_menu,precio_menu) values(@nombre_men, @descripcion_men, @precio_men);
end;

--Procedimiento almacenado para editar menu
create procedure editar_menu 
@nombre_men NVARCHAR(100),
@descripcion_men NVARCHAR(300), 
@precio_men float,
@id_men int
as begin
    update menu set nombre_menu = @nombre_men, descripcion_menu = @descripcion_men, 
    precio_menu = @precio_men where id_menu = @id_men;
end;

--Procedimiento almacenado para eliminar menu
create procedure eliminar_menu
@id_men int
as begin
    delete from menu where id_menu = @id_men;
end;


/*------------------Procedimientos categoria x genero-----------------*/
--Procedimiento almacenado para mostrar categoria x genero
create procedure mostrar_categoriaxmenu
as begin
	select * from categoriaxmenu
end;

--Procedimiento almacenado para insertar categoria x genero
create procedure insertar_categoriaxmenu
@id_cat int, 
@id_men int
as begin
    insert into categoriaxmenu(id_categoria,id_menu) values(@id_cat, @id_men);
end;

--Procedimiento almacenado para actualizar categoria
create procedure editar_categoriaxgenero
@id_cat int,
@id_men int
as begin
    update categoriaxmenu set id_categoria = @id_cat, id_menu = @id_men where id_categoria = @id_cat and id_menu = @id_men;
end;

--Procedimiento almacenado para eliminar categoria x genero
create procedure eliminar_categoriaxmenu
@id_cat int, 
@id_men int
as begin
    delete from categoriaxmenu where id_categoria = @id_cat and id_menu = @id_men;
end;


/*------------------Procedimientos Cliente----------------------*/
--Procedimiento almacenado para mostrar clientes
create procedure mostrar_clientes
as begin
	select * from cliente
end;

--Procedimiento almacenado para insertar cliente
create procedure insertar_cliente
@nombre_cli NVARCHAR(100), 
@genero_cli NVARCHAR(100),
@telefono_cli NVARCHAR(100),
@direccion_cli NVARCHAR(100)
as begin
    insert into cliente(nombre_cliente,genero_cliente,telefono_cliente,direccion_cliente) values(@nombre_cli, @genero_cli, @telefono_cli, @direccion_cli);
end;

--Procedimiento almacenado para editar cliente
create procedure editar_cliente
@nombre_cli NVARCHAR(100),
@genero_cli NVARCHAR(100),
@telefono_cli NVARCHAR(100), 
@direccion_cli NVARCHAR(100),
@id_cli int
as begin
    update cliente set nombre_cliente = @nombre_cli, genero_cliente = @genero_cli, telefono_cliente = @telefono_cli, direccion_cliente = @direccion_cli where id_cliente = @id_cli;
end;

--Procedimiento almacenado para eliminar cliente
create procedure eliminar_cliente
@id_cli int
as begin
    delete from cliente where id_cliente = @id_cli;
end;


/*------------------Procedimientos Domiciliario----------------------*/
--Procedimiento almacenado para mostrar domiciliarios
create procedure mostrar_domiciliario
as begin
	select * from domiciliario
end;

--Procedimiento almacenado para insertar domiciliario
create procedure insertar_domiciliario
@nombre_dom NVARCHAR(100), 
@genero_dom NVARCHAR(100),
@telefono_dom NVARCHAR(100)
as begin
    insert into domiciliario(nombre_domiciliario,genero_domiciliario,telefono_domiciliario) values(@nombre_dom, @genero_dom, @telefono_dom);
end;

--Procedimiento almacenado para editar domiciliario
create procedure editar_domiciliario
@nombre_dom NVARCHAR(100),
@genero_dom NVARCHAR(100),
@telefono_dom NVARCHAR(100),
@id_dom int
as begin
    update domiciliario set nombre_domiciliario = @nombre_dom, genero_domiciliario = @genero_dom, telefono_domiciliario = @telefono_dom where id_domiciliario = @id_dom;
end;

--Procedimiento almacenado para eliminar domiciliario
create procedure eliminar_domiciliario
@id_dom int
as begin
    delete from domiciliario where id_domiciliario = @id_dom;
end;

/*------------------Procedimientos Compra----------------------*/
--Procedimiento almacenado para mostrar compras
create procedure mostrar_compras
as begin
	select * from compra
end;

--Procedimiento almacenado para insertar compra
create procedure insertar_compra
@id_cli int, 
@id_dom int, 
@id_men int,
@cant int, 
@fecha_com date, 
@entrega_rec NVARCHAR(100)
as begin
    insert into compra(id_cliente,id_domiciliario,id_menu,cantidad,fecha_compra,entrega_recibida) values(@id_cli, @id_dom, @id_men, @cant, @fecha_com, @entrega_rec);
end;

--Procedimiento almacenado para editar domiciliario
create procedure editar_compra
@id_cli int, 
@id_dom int, 
@id_men int,
@cant int, 
@fecha_com date, 
@entrega_rec NVARCHAR(100),
@id_com int
as begin
    update compra set id_cliente = @id_cli, id_domiciliario = @id_dom, id_menu = @id_men, cantidad = @cant, fecha_compra = @fecha_com, entrega_recibida = @entrega_rec where id_compra = @id_com;
end;

--Procedimiento almacenado para eliminar compra
create procedure eliminar_compra
@id_com int
as begin
    delete from compra where id_compra = @id_com;
end;