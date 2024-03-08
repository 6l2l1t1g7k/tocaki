Voici un fichier .csv qui contient des données
le codage est UTF-16
Le séparateur de champ est ,
Le séparateur de mot est "

attention il y a des caractères spéciaux qui rendent la lecture difficile
attention il y a des virgules dans les données
attention il y a des cases de données vides

Je veux pour chaque ligne de ce tableau tu fasses la procédure suivante :
tu vas créer un fichier .cs que tu va appeler Token_BALISENOM.cs

Ensuite dans chaque fichier tu vas écrire le code suivant :
"
namespace tocaki.a4_Dictionary.a23;

public class Token_BALISEFONETIK : LexicalToken {
    public override List<Type> ParentConcepts => [];
    public override string Phonetics => "BALISEFONETIK";
    public override string DefinitionInTocaki => "BALISETOCAKI";
    public override string DefinitionInFrench => "BALISEFRANCAIS";
    public override List<string> FrenchWordsAssociated => [];
}
"

Dans ce que je t'ai demandé plus haut je que :
- à la place de BALISENOM tu écris la valeur qui se trouve dans la colonne "fonetik" auquel tu rajoutes un nombre aléatoire entre 10 et 99.
- à la place de BALISEFONETIK tu écris exactement le texte qui se trouve dans la colonne "fonetik"
- à la place de BALISETOCAKI tu écris exactement le texte qui se trouve dans la colonne "definisyM"
- à la place de BALISEFRANCAIS tu écris exactement le texte qui se trouve dans la colonne "Explication, exemple"
- pour le code C# "get => [];" je veux que tu le laisses exactement comme ça

Fais ce travail pour me donner a télécharger les fichiers pour les 20 premières lignes