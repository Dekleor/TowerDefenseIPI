# Projet Fin d’année Tower Defense IPI
Réalisation d'un projet type MESI dans le cadre de la formation CDEV.  
Avec 5 jeunes et beaux développeurs.

-----------------------

## Nom du jeu :  
 Projet petits Lapins
 
 
## Genre :
Tower Defense 3D en vue première personne



## Eléments de jeu :
Les joueurs en coopération doivent faire face a des hordes d'ennemis qui cherchent a détruire le coeur de leur base. Ils peuvent, pour cela, améliorer leur équipement ou construire des tourelles de défense.
L'amélioration ou la construction se fait en récoltant des ressources sur la carte ou a la mort des ennemis.



## Nombre de joueurs :
1 à 4 joueurs simultanés.

## Spécificité Technique.

## Forme technique :
Graphismes en 3D



## Camera :
Camera à la première personne



## Plateforme :
PC


## Langage:
C#
 
 
## Média :
PC

-----------------

# GAME PLAY
Avant de lancer un niveau, chaque joueur choisi un personnage qui lui sera propre. Ils se retrouvent ensuite sur la carte choisi à coté du coeur à défendre.
Un timer se lance avant l'arrivée de la prochaine vague. Pendant ce temps le(s) joueur(s) peuvent faire deux activités distinctes : 
 - Commencer a construire des défense avec les ressources qui sont disponible de base (tour d'attaque, de défense, murs, etc)
 - Commencer à explorer la carte pour trouver l'endroit de spawn des ennemis et/ou récolter des ressources supplémentaires. (bois, pierre, 

Une fois le timer terminé, une première vague d'ennemi arrive. Composées de plusieurs type d'ennemi différents (certains ont des priorités de cible qui leur sont propre, d'autres sont plus lents avec plus d'armure ou a l'inverse, plus rapide mais plus faible, etc). Chaque ennemi abbatu lache des ressources pour pouvoir préparer la prochaine vague.
Une fois tout les ennemis abbatus, le timer se relance pour une nouvelle boucle.
