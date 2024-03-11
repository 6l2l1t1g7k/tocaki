using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a23;

public class Token_ruzwi : LexicalToken
{
    public readonly Token_rumze rumze1 = new();
    public override List<Type> ParentConcepts => [typeof(Token_rumze)];
    // TODO Q? y'a moyen de faire List<Type> ParentConcepts => [Token_rumze]; ? Est ce qu'il vaudrait mieux avoir une instance vu ce que je fais ?
    public override string Phonetics => "ruzwi";
    public override string DefinitionInTocaki => $"{rumze1.Phonetics} qui vérifie que pour tout x de {rumze1.EnsembleDeDepart} il existe au moins un y de {rumze1.EnsembleDarrive} tel que le couple (x, y) appartienne à {rumze1.EnsembleDeLaRelation}.";
    public override string DefinitionInFrench => "";
    public override List<string> FrenchWordsAssociated => ["fonction"];

    public string Explication = "On peut aussi dire que c'est une rumze retreinte à son espace de définition.";
}
