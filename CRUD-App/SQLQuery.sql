Create Database EtudiantDB
Go

Use EtudiantDB
Go

create table Etudiant(
                       Matricule int primary key identity,
				       Nom varchar(50),
				       Prenom varchar(50),
				       Filiere varchar(100),
					   Groupe int,
				       DateNaissance date,
)