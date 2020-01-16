use master
go
drop database GestionAbsence;
go
create database GestionAbsence;
go
use GestionAbsence;
go
create table users(
idusers int identity(1,1),
nameusers varchar(20),
matiere varchar(50),
login varchar(50),
password varchar(50),
preriorite int)


create table absence(
idAbsence int identity(1,1),
idusers int,
idstagiaire int,
date date,
periode int)

create table Stagiaire(
idstagiaire int identity(1,1),
numStagiaire int,
name varchar(100),
cin varchar(50),
idgroupe int)

create table Groupe(
idgroupe int identity(1,1),
nomgroupe varchar(50))

create table jour(
idjour int identity(1,1),
jour int,
idgroupe int);

create table Eregestrement(
ideregestrement int identity(1,1),
timestart int,
idjour int,
Activite varchar(50),
salle varchar(20),
idusers int)


alter table Stagiaire add constraint pk_stagiaire primary key (idstagiaire);
alter table Groupe add constraint pk_groupr primary key (idgroupe);
alter table jour add constraint pk_jour primary key (idjour);
alter table Eregestrement add constraint pk_Eregestrement primary key (ideregestrement);
alter table users add constraint pk_users primary key (idusers);
alter table absence add constraint pk_absence primary key (idAbsence);

alter table Stagiaire add constraint fk_stagiaireGroupe foreign key (idgroupe) references Groupe(idgroupe) on delete cascade;
alter table jour add constraint fk_JourGroupe foreign key (idgroupe) references Groupe(idgroupe);
alter table Eregestrement add constraint fk_Eregestrementjour foreign key (idjour) references jour(idjour);
alter table absence add constraint fk_absenceUsers foreign key (idusers) references users(idusers);
alter table absence add constraint fk_absenceStagiaire foreign key (idstagiaire) references Stagiaire(idstagiaire);
alter table Eregestrement add constraint fk_EregestrementUsers foreign key (idusers) references users(idusers);



insert into groupe values('TDI102'),
						('TDI202'),
						('TDI201'),
						('TDI101');
insert into stagiaire values(1,'name1','L55471',1),
							(2,'name2','L55482',2),
							(3,'name3','L55493',3),
							(4,'name4','L55501',4),
							(5,'name5','L55512',2);

							
-- if id jour is existe
 insert into Eregestrement (timestart , Activite , idjour) values (1,'rahmouni',(select idjour from jour as a where a.jour ='4' and a.idgroupe = (select idgroupe from Groupe where nomgroupe = 'TDI102') ));
-- add idjourif not existe
select Count (idjour) from jour as a where a.jour ='4' and a.idgroupe = (select idgroupe from Groupe where nomgroupe = 'TDI102')

insert into jour (jour, idgroupe) values ('4',(select idgroupe from Groupe where nomgroupe = 'TDI102'))


go
create proc addIJIFNE(@idjour int,@groupe varchar(50))
as
begin
declare @j int;
	select @j= Count (idjour) from jour as a where a.jour =@idjour and a.idgroupe = (select idgroupe from Groupe where nomgroupe =@groupe)
	if(@j=0)
		begin
		insert into jour (jour, idgroupe) values (@idjour,(select idgroupe from Groupe where nomgroupe =@groupe))
		end
end

exec dbo.addIJIFNE 4,'TDI102'


SELECT jour, e.timestart,e.activite FROM Eregestrement e INNER JOIN jour j ON e.idjour = j.idjour INNER JOIN Groupe g ON j.idgroupe = g.idgroupe WHERE g.nomgroupe = 'TDI102' order by jour,timestart


delete from Eregestrement where timestart = '3'  and idjour = (select idjour from jour)



