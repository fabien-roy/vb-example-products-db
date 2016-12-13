﻿#AUT2016 - VB.NET - TP3#

Ceci est le travail TP3 en VB.NET, fait par moi (Fabien Roy).

C'est une gestion d'inventaire de COOP de cégep qui utilise SQL Server 2014 et LinQ.

##Liste de bugs/features##

###Ce que je n'ai pas eu le temps d'ajouter (features)###
	L'inventaire ne devrait pas avoir à aller chercher les données quand on annule l'ajout/la modification

###Ce que je n'ai pas eu le temps de règler (bugs)###
	(Rien)

###Ce que je n'ai pas eu à regler (vieux bugs/features du TP1 qui ne nécéssitent pas de correction)###
	Le formulaire FormAjoutItem construit lui-même un datarow et l'envoie dans le DataTable Items. Il faudrait que ce soit gèrer entièrement par DataTableTravailleur.
	Faire marcher le filtre des items sélectionnés et la recherche en même temps
	S'il y a trop d'items dans la facture et que le formulaire d'affichage de facture dépasse l'écran, l'impression ne comportera pas la page au complet (parce que je me sers d'une capture d'écran pour l'impression)

## Choses à faire ##

### LinQ + inventaire ###

	1 [x] Adapter le DGV à LinQ
	1 [x] Adapter Insert à LinQ
	1 [x] Adapter Update à LinQ
	1 [x] Adapter Delete à LinQ
	1 [x] Vérifier pour les prix d'achats
	3 [ ] Adapter filtres à LinQ
	3 [x] Faire fonctionner le total d'inventaire
	3 [ ] Bug de total d'inventaire quand on filtre seulement la sélection

### LinQ + factures ###

	1 [x] Vérifier pourquoi ce n'est pas les bons inventaires qui sont affichés
	1 [x] Réparer le DGV et les quantités
	1 [x] Vérifier qu'il y a une sélection avant d'envoyer vers la facture
	1 [ ] Adapter le DGV de factures à LinQ
	1 [x] Adapter l'ajout d'éléments à la facture à LinQ
	1 [x] Faire fonctionner la facture comme au TP1 avec LinQ
	2 [ ] Baisser l'inventaire des factures avec LinQ
	2 [ ] Ajouter les factures à la base de données lors de la création
	3 [ ] Faire fonctionner l'impression comme au TP1 avec LinQ

### Tab des factures ###
	
	2 [ ] Faire les procedures stockées de select
	2 [ ] Faire les procedures stockées d'insert
	2 [ ] Faire les procedures stockées d'update
	2 [ ] Faire les procedures stockées de delete
	2 [x] Faire le tab des factures
	2 [ ] Faire le DGV des factures
	2 [ ] Faire l'ajout de factures
	2 [ ] Faire le formulaire de manipulation de factures
	2 [ ] Faire la modification de factures
	2 [ ] Faire la suppresion de factures

### Utilisateurs de la base de données ###

	2 [ ] Faire en sorte que le login est pour un utilisateur de la base de données
	2 [ ] Demander une connexion au départ du programme
	2 [ ] Pouvoir choisir l'addresse du ConnectionString en se connectant
	2 [x] Lier la table Utilisateur avec les logins sur la base de données
	2 [ ] Aller chercher les droits des utilisateurs
	3 [x] Construire le tab des utilisateurs
	3 [x] Faire le DGV des utilisateurs
	3 [x] Faire le formulaire de manipulation d'utilisateur
	3 [ ] Faire les procedures stockées de select d'utilisateur
	3 [x] Avoir une procédure stockée pour l'insert d'utilisateurs de la base de données
	3 [ ] Avoir une procédure stockée pour l'update d'utilisateurs de la base de données
	3 [ ] Avoir une procédure stockée pour le delete d'utilisateurs de la base de données
	3 [ ] Faire marcher les procédures stockées avec les utilisateurs de la base de données + 

### Gestion de droits ###

	2 [ ] Faire les procedures stockées de select d'utilisateur + des droits (au besoin)
	2 [ ] Faire les procedures stockées d'update d'utilisateur + des droits (au besoin)
	3 [ ] Pouvoir se déconnnecter

### Application des droits ###

	2 [ ] Mettre les droits dans les variables globales
	3 [ ] Faire le bit 1 - Utilisateur Select (Permet le DGV + le Tab)
	3 [ ] Faire le bit 2 - Utilisateur Insert (Permet le bouton)
	3 [ ] Faire le bit 4 - Utilisateur Update infos (Permet le bouton)
	3 [ ] Faire le bit 8 - Utilisateur Delete (Permet le bouton)
	3 [ ] Faire le bit 16 - Utilisateur Update droits (Change le DGV)
	3 [ ] Faire le bit 32 - Inventaire Select (Permet le DGV +  le Tab) (Ne pourra pas produire de factures)
	3 [ ] Faire le bit 64 - Inventaire Insert (Permet le bouton)
	3 [ ] Faire le bit 128 - Inventaire Update (Permet le bouton)
	3 [ ] Faire le bit 256 - Inventaire Delete (Permet le bouton)
	3 [ ] Faire le bit 512 - Inventaire Admin (Permet le Textbox d'estimations + prix achat)
	3 [ ] Faire le bit 1024 - Factures Select (Permet le DGV + le Tab)
	3 [ ] Faire le bit 2048 - Factures Insert (Permet le bouton)
	3 [ ] Faire le bit 4096 - Factures Update (Permet le bouton)

### Autre ###
	
	1 [ ] Supprimer les fichiers du TP1
	1 [ ] Renommer README.md en LISEZMOI.md
	1 [ ] Vérifier les TODO dans le programme

## Historiques des versions de LISEZMOI.md ##

Ceci est mon travail TP1 en VB.net.

C'est une gestion d'inventaire de coop par fichiers textes.

Cela comprends :
	- L'affichage des items
	- L'ajout d'items
	- La modification d'items
	- La suppression d'items
	- Le calcul de données administratives (totaux)
	- La connexion administrateur
	- L'interface administrateur
	- La facturation (avec vérification et suppression de quantités)
	- L'impression de facture
	- La sauvegarde de la table "Items" dans un fichier.
	- Sélection des items par checkbox.
	- Un filtre pour voir seulement les items sélectionnés.

Ce que je n'ai pas eu le temps d'ajouter (features) : 
	- Enregistrement en binaire, compression et encryption. L'enregistrement de base est fonctionnel.
	- Le formulaire FormAjoutItem construit lui-même un datarow et l'envoie dans le DataTable Items. Il faudrait que ce soit gèrer entièrement par DataTableTravailleur.
	- Faire marcher le filtre des items sélectionnés et la recherche en même temps

Ce que je n'ai pas eu le temps de règler (bugs) : 
	- S'il y a trop d'items dans la facture et que le formulaire d'affichage de facture dépasse l'écran, l'impression ne comportera pas la page au complet (parce que je me sers d'une capture d'écran pour l'impression)
	- Dans la méthode LireDataTable de DataTableTravailleur, la façon de lire la table n'est pas valide. Je crois que j'ai un problème de référence.

Dans mon code, on peut parfois voir des commentaires spécifiques
	TODO : petit mémo à moi-même
	TOFIX : bugs à règler
	TOADD : ajout à faire (feature)

Je préfère laisser ces commentaires dans mon codes, puisque certains aident à cerner les erreurs dont je parle ici et puisque cela va m'être utile dans le TP2.