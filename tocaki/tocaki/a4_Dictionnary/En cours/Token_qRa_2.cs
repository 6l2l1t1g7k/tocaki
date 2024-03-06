namespace tocaki.a4_Dictionary.a3;

public class Token_qRa : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qRa"; }
    public override string DefinitionInTocaki { get => "qRa"; } // TODO modifier ce mot, collision avec qra
    public override string DefinitionInFrench { get => "une forte pente, l’abrupt"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
