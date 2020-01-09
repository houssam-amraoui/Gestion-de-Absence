create database GestionAbsence;

use GestionAbsence;

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
jour varchar(10),
idgroupe int);

create table Eregestrement(
ideregestrement int identity(1,1),
timestart varchar(50),
timeend varchar(50),
idjour int)

alter table Stagiaire add constraint pk_stagiaire primary key (idstagiaire);
alter table Groupe add constraint pk_groupr primary key (idgroupe);
alter table jour add constraint pk_jour primary key (idjour);
alter table Eregestrement add constraint pk_Eregestrement primary key (ideregestrement);

alter table Stagiaire add constraint fk_stagiaireGroupe foreign key (idgroupe) references Groupe(idgroupe) on delete cascade;
alter table jour add constraint fk_JourGroupe foreign key (idgroupe) references Groupe(idgroupe);
alter table Eregestrement add constraint fk_Eregestrementjour foreign key (idjour) references jour(idjour);



insert into groupe values('TDI102'),
						('TDI202'),
						('TDI201'),
						('TDI101');
insert into stagiaire values(1,'name1','L55471',1),
							(2,'name2','L55482',2),
							(3,'name3','L55493',3),
							(4,'name4','L55501',4),
							(5,'name5','L55512',2);
alter table Eregestrement add Activite varchar(50);





-- if id jour is existe
 insert into Eregestrement (timestart , Activite , idjour) values (1,'rahmouni',(select idjour from jour as a where a.jour ='4' and a.idgroupe = (select idgroupe from Groupe where nomgroupe = 'TDI102') ));
-- add idjourif not existe
select Count (idjour) from jour as a where a.jour ='4' and a.idgroupe = (select idgroupe from Groupe where nomgroupe = 'TDI102')

insert into jour (jour, idgroupe) values ('4',(select idgroupe from Groupe where nomgroupe = 'TDI102'))