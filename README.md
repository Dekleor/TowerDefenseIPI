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












Game Play Outline
This outline will vary depending on the type of game.
•	Opening the game application
•	Game options
•	Story synopsis
•	Modes
•	Game elements
•	Game levels
•	Player’s controls
•	Winning
•	Losing
•	End
•	Why is all this fun?
 
Key Features
Key features are a list of game elements that are attractive to the player.
















DESIGN DOCUMENT
This document describes how GameObjects behave, how they’re controlled and their properties. This is often referred to as the “mechanics” of the game. This documentation is primarily concerned with
the game itself. This part of the document is meant to be modular, meaning you could have several different Game Design Documents attached to the Concept Document.


Design Guidelines
This is an important statement about any creative restrictions that need to be considered and includes brief statements about the general (i.e., overall) goal of the design.






Game Design Definitions
This section established the definition of the game play. Definitions should include how a player wins, loses, transitions between levels, and the main focus of the gameplay.
 
Game Flowchart
The game flowchart provides a visual of how the different game elements and their properties interact. Game flowcharts should represent Objects, Properties, and Actions present in the game. Each of these items should have a number reference to where they exist within the game mechanics document.
•	Menu
•	Synopsis
•	Game Play
•	Player Control
•	Game Over (Winning and Losing
 
Player Definition
●	Use this section for quick descriptions that define the player
●	Use the Player Properties section (below) to define the properties for each player. Player Properties can be affected by the player’s action or interaction with other game elements. Define the properties and how they affect the player’s current game.
●	Use the Player Rewards section to make a list of all objects that affect the player in a positive way. Define these objects by describing what affect they cause and how the player can use the object.

Player Definitions
A suggested list may include:
•	Health
•	Weapons
•	Actions











Player Properties
Each property should mention a feedback as a result of the property changing.









Player Rewards (power-ups and pick-ups)
Make a list of all objects that affect the player in a positive way (e.g., health replenished)
 

User Interface (UI)
This is where you’ll include a description of the user’s control of the game. Think about which buttons on a device would be best suited for the game. Consider what the worst layout is, then ask yourself if your UI is it still playable. A visual representation can be added where you relate the physical controls to the actions in the game. When designing the UI, it may be valuable to research quality control and user interface (UI) design information.
