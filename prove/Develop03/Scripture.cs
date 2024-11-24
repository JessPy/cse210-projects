using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    private List<Word> _hiddenWordsHistory;

     public Scripture(Reference reference, string text)
    {
        SetReference(reference);
        SetWords(text.Split(' ').Select(word => new Word(word)).ToList());
        SetHiddenWordsHistory(new List<Word>());
        SetRandom(new Random());
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", GetWords().Select(word => word.GetDisplayText()));
        return $"{GetReference().GetDisplayText()}\n{scriptureText}";
    }

    public void HideRandomWords()
    {
        var visibleWords = GetWords().Where(word => !word.GetIsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        int wordsToHide = Math.Min(3, visibleWords.Count); 
        for (int i = 0; i < wordsToHide; i++)
        {
            var wordToHide = visibleWords[GetRandom().Next(visibleWords.Count)];
            wordToHide.Hide();
            _hiddenWordsHistory.Add(wordToHide);
            visibleWords.Remove(wordToHide);
        }
    }
    public bool IsCompletelyHidden()
    {
        return GetWords().All(word => word.GetIsHidden());
    }
    public void SetHiddenWordsHistory(List<Word> hiddenWordsHistory)
    {
        _hiddenWordsHistory = hiddenWordsHistory;
    }
    public List<Word> GetHiddenWordsHistory()
    {
        return _hiddenWordsHistory;
    }
    public void Back()
    {
        if (_hiddenWordsHistory.Count > 0)
        {
            var lastHiddenWord = _hiddenWordsHistory[^1];
            lastHiddenWord.Reveal();
            _hiddenWordsHistory.RemoveAt(_hiddenWordsHistory.Count - 1);
        }
    }

    //Set and Gets
    private void SetReference(Reference reference)
    {
        _reference = reference;
    }

    public Reference GetReference()
    {
        return _reference;
    }

    private void SetWords(List<Word> words)
    {
        _words = words;
    }

    private List<Word> GetWords()
    {
        return _words;
    }

    private void SetRandom(Random random)
    {
        _random = random;
    }

    public Random GetRandom()
    {
        return _random;
    }
}