Voici un fichier CSV
attention il est encodé en UTF-16
attention il y a des caractères spéciaux qui rendent la lecture difficile
attention il y a des virgules dans les données
attention il y a des cases de données vides

Je veux pour chaque ligne de ce tableau tu fasses la procédure suivante :
tu vas créer un fichier .cs que tu va appeler Token_BALISENOM.cs

Ensuite dans chaque fichier tu vas écrire le code suivant :
"
namespace tocaki.a4_Dictionary.a3;

public class Token_BALISEFONETIK : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "BALISEFONETIK"; }
    public override string DefinitionInTocaki { get => "BALISETOCAKI"; }
    public override string DefinitionInFrench { get => "BALISEFRANCAIS"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
"

Dans ce que je t'ai demandé plus haut je que :
- à la place de BALISENOM tu écris la valeur qui se trouve dans la colonne "fonetik" auquel tu rajoutes un nombre aléatoire entre 10 et 99.
- à la place de BALISEFONETIK tu écris la valeur qui se trouve dans la colonne "fonetik" mais sans le nombre aléatoire cette fois
- à la place de BALISETOCAKI tu écris la valeur qui se trouve dans la colonne "definisyM"
- à la place de BALISEFRANCAIS tu écris la valeur qui se trouve dans la colonne "Explication, exemple"
- pour le code C# "get => [];" je veux que tu le laisses exactement comme ça

Fais ce travail pour les 20 premières lignes de mon fichier.