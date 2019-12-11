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


alter table Stagiaire add constraint fk_stagiaireGroupe foreign key (idgroupe) references Groupe(idgroupe);
alter table jour add constraint fk_JourGroupe foreign key (idgroupe) references Groupe(idgroupe);
alter table Eregestrement add constraint fk_Eregestrementjour foreign key (idjour) references jour(idjour);