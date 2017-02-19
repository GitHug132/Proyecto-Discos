use Discos;
go
--Seleccionar Discos
Select IdDisco, Titulo, Agno, IdInterprete
From Disco;
--Seleccionar Disco a través del interprete
Select IdDisco, Titulo, Agno, d.IdInterprete,i.Interprete
From Disco as d inner join
Interprete as i on d.IdInterprete = i.IdInterprete
where i.Interprete = 'Baccara'; --Aqui se le pasa el nombre del interprete desde cliente
--Seleccionar Disco a través de su titulo
Select IdDisco, Titulo, Agno, IdInterprete
From Disco
where Titulo like '%yes%'; --Aqui el usuario rellenará un input text
--Ver puntuación de un disco

--Vistas
--Vista principal
create view view_discos
as Select d.IdDisco, Titulo, Agno, d.IdInterprete as idInterprete,i.Interprete as NombreInterp, p.Puntuacion as Puntuacion, p.Fecha, t.tipo as tipoDisco,
c.id as IdCliente, c.Nombre as NombreCliente, c.Email, c.FechaNacimiento, c.FechaRegistro
From Disco as d inner join
Interprete as i on d.IdInterprete = i.IdInterprete
inner join DiscoTipo as dt on dt.IdDisco = d.IdDisco
inner join Puntuacion as p on p.iddisco = d.IdDisco
inner join Cliente as c on c.id = p.Idcliente
inner join Tipo as t on t.IdTipo = dt.IdTipo;

--Busqueda disco por interprete
create view view_disco_interprete as
Select IdDisco, Titulo, Agno, d.IdInterprete,i.Interprete
From Disco as d inner join
Interprete as i on d.IdInterprete = i.IdInterprete
where i.Interprete = 'Baccara'; --Aqui se le pasa el nombre del interprete desde cliente

select *
from view_discos;