use master
go
drop database gestionAbsencev2
go
create database gestionAbsencev2;
go
use gestionAbsencev2;

create table Stagiaire(
idstagiaire int identity(1,1),
numStagiaire int,
name varchar(100),
cin varchar(50),
);

create table incription(
idInscription int identity(1,1),
idgroupe int,
annee int,
constraint pk_incription primary key (idInscription));

create table Groupe(
idgroupe int identity(1,1),
nomgroupe varchar(50));

create table Seance(
idSeance int identity(1,1),
timestart int,
numjour int,
Activite varchar(50),
salle varchar(20),
idusers int,
idgroupe int);

create table users(
idusers int identity(1,1),
nameusers varchar(20),
matiere varchar(50),
login varchar(50),
password varchar(50),
preriorite int)

create table absence(
idInscription int,
idAbsence int identity(1,1),
idstagiaire int,
idSeance int,
date date,
);






alter table Stagiaire add constraint pk_stagiaire primary key (idstagiaire);
alter table Groupe add constraint pk_groupe primary key (idgroupe);
alter table Seance add constraint pk_Seance primary key (idSeance);
alter table users add constraint pk_users primary key (idusers);
alter table absence add constraint pk_absence primary key (idAbsence);



alter table Seance add constraint fk_SeanceUsers foreign key (idusers) references users(idusers);
alter table absence add constraint fk_absenceStagiaire foreign key (idstagiaire) references Stagiaire(idstagiaire);
alter table absence add constraint fk_absenceSeance foreign key (idSeance) references Seance(idSeance);
--alter table Eregestrement add constraint fk_EregestrementUsers foreign key (idusers) references users(idusers);
alter table incription add constraint fk_incriptiongroupe foreign key (idgroupe) references Groupe(idgroupe);
alter table Seance add constraint fk_Seancegroupe foreign key (idgroupe) references Groupe(idgroupe);
alter table absence add constraint fk_absenceInscription foreign key (idInscription) references incription(idInscription);



