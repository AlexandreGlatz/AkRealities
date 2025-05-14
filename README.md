# Akrealities Test Technique

Ceci est le test technique réalisé par Alexandre Glatz pour Akrealities

Le sujet demandait des éléments d'UI spécifiques pour la réalité mixte avec le SDK de Meta

- Le camera rig, les controllers et le hand tracking sont ajoutés depuis le SDK
 
- Chaque intéraction est gérée par le SDK d'intéraction de Meta

- Pour l'intégration des activités j'ai créé une simple structure contenant le titre, la description et le clip audio d'une activité, la struct est serializable
 
- Pour l'ajout facilité de boutons j'ai créé une liste de cette struct en serialize field pour le modifier facilement dans l'éditeur

- Pour la création de boutons chacun correspond à 1 élément de la liste et s'assigne l'ouverture de la fenêtre annexe

- La fenêtre annexe ne fait que recevoir les information dans ses textes et les appliques à la pression du bouton

- Pour jouer les sons il y a le building block spatial audio de meta
