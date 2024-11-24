using System;

class Word
{
    private string _text; 
    private bool _isHidden;

    public Word(string text)
    {
        SetText(text);
        SetIsHidden(false);
    }

    public void Hide()
    {
        SetIsHidden(true);
    }
    public string GetDisplayText()
    {
        return GetIsHidden() ? new string('_', GetText().Length) : GetText();
    }
    public void Reveal()
    {
        SetIsHidden(false);
    }
    //Set and Get
    private void SetText(string text)
    {
        _text = text;
    }
    public string GetText()
    {
        return _text;
    }
    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    } 
    public bool GetIsHidden()
    {
        return _isHidden;
    }
}