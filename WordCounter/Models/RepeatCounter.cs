using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _text;
        private int _counter;

        public RepeatCounter(string inputWord, string inputText)
        {
            _word = inputWord;
            _text = inputText;
        }

        public string GetWord()
        {
            return _word;
        }

    }
}
