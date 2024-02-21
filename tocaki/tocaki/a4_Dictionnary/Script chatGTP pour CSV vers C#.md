Voici un nouveau fichier CSV
attention il est encodé en UTF-16
attention il y a des caractères spéciaux

Je veux pour chaque ligne de ce tableau tu fasses la procédure suivante :
tu vas créer un fichier .cs que tu va appeler Token_BALISENOM.cs
Tu dois remplacer BALISENOM par le texte de la colonne "fonetik" au quel tu rajoutes un nombre aléatoire entre 1 et 99.

Ensuite dans chaque fichier tu vas écrire le code suivant :
"
namespace tocaki.a4_Dictionnary.a2;

public class Token_BALISEFONETIK : LexicalToken
{
    public override string Phonetics { get => "BALISEFONETIK"; }
    public override string DefinitionInTocaki { get => "BALISETOCAKI"; }
    public override string DefinitionInFrench { get => "BALISEFRANCAIS"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
"
à la place de BALISEFONETIK tu écris la valeur qui se trouve dans la colonne "fonetik"
à la place de BALISETOCAKI tu écris la valeur qui se trouve dans la colonne "definisyM"
à la place de BALISEFRANCAIS tu écris la valeur qui se trouve dans la colonne "Explication, exemple"
pour le code C# "get => [];" je veux que tu le laisses exactement comme ça

Commence par faire ce travail pour les 10 premières lignes et je te dirais quand je veux que tu fasses le reste.