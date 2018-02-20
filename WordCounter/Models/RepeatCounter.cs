using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _text;
        private int _counter;
        private List<string> _splitText = new List<string> {};

        public RepeatCounter(string inputWord, string inputText)
        {
            _word = inputWord;
            _text = inputText;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetText()
        {
            return _text;
        }

        public int GetCounter()
        {
          return _counter;
        }

        public void SetCounter(int newCounter)
        {
            _counter = newCounter;
        }

        public List<string> GetSplitText()
        {
            return _splitText;
        }

        public void SetSplitText()
        {
            string[] separators = {" "};
            string[] holder = _text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int index = 0; index < holder.Length; index++)
            {
                _splitText.Add(holder[index]);
            }
        }

        public void DoCount()
        {
            for (int j = 0; j < _splitText.Count; j++)
            {
                string stringHolder = _splitText[j];
                string[] endCheck = {",", ".", "!", "?"};
                char[] charsTrim = {',', '.', '!', '?'};
                for (int x = 0; x <= 3; x++)
                {
                  if (stringHolder.EndsWith(endCheck[x]) == true)
                  {
                    stringHolder = stringHolder.TrimEnd(charsTrim);
                  }
                }
                if (stringHolder.ToLower() == _word.ToLower())
                {
                    _counter++;
                }
            }
        }
    }
}
