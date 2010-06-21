namespace Rm.Spellchecker.Core
{
    public interface ITextElementReader
    {
        bool HasElements { get; }
        TextElementList Run(string text);
    }
}