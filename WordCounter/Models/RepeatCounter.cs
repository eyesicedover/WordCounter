using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            string[] holder = Regex.Split(_text, " ");
            for (int index = 0; index < holder.Length; index++)
            {
                _splitText.Add(holder[index]);
            }
        }

        public void DoCount()
        {
          for (int j = 0; j < _splitText.Count; j++)
          {
              if (_splitText[j].ToLower() == _word.ToLower())
              {
                  _counter++;
              }
          }
        }
    }
}
