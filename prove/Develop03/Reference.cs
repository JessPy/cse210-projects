using System;
class Reference
{
    private string _book;
    private string _charpter;
    private string _verseStart;
    private string _verseEnd;
    public Reference (string book, string charpter, string verseStart, string verseEnd)
    {
        SetBook(book);
        SetCharpter(charpter);
        SetVerseStart(verseStart);
        SetVerseEnd(verseEnd);
    }
    public Reference (string book, string charpter, string verseStart)
    {
        SetBook(book);
        SetCharpter(charpter);
        SetVerseStart(verseStart);
    }
    public string GetDisplayText()
    {
        return GetVerseEnd() == null
            ? $"{GetBook()} {GetCharpter()}:{GetVerseStart()}"
            : $"{GetBook()} {GetCharpter()}:{GetVerseStart()}-{GetVerseEnd()}";
    }
    // Setters
    private void SetBook(string book)
    {
        _book = book;
    }
    private void SetCharpter(string charpter)
    {
        _charpter = charpter;
    }
    private void SetVerseStart(string verseStart)
    {
        _verseStart = verseStart;
    }
    private void SetVerseEnd(string verseEnd)
    {
        _verseEnd = verseEnd;
    }
    // Getetrs
    public string GetBook()
    {
        return _book;
    }
     public string GetCharpter()
    {
        return _charpter;
    }
     public string GetVerseStart()
    {
        return _verseStart;
    }
     public string GetVerseEnd()
    {
        return _verseEnd;
    }

   
}