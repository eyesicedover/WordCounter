using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
    [TestClass]
    public class ProjectTest
    {
        [TestMethod]
        public void InputWord_ReturnWord_True()
        {
            //Arrange
            string word = "hello";
            string text = "hello world";
            RepeatCounter newRepeatCounter = new RepeatCounter(word, text);

            //Act
            string compare = newRepeatCounter.GetWord();

            //Assert
            Assert.AreEqual(word, compare);
        }


        [TestMethod]
        public void InputText_ReturnText_True()
        {
            //Arrange
            string word = "hello";
            string text = "hello world";
            RepeatCounter newRepeatCounter = new RepeatCounter(word, text);

            //Act
            string compare = newRepeatCounter.GetText();

            //Assert
            Assert.AreEqual(text, compare);
        }

        [TestMethod]
        public void SetCounter_GetCounter_True()
        {
            //Arrange
            string word = "hello";
            string text = "hello world";
            int counter = 12;
            RepeatCounter newRepeatCounter = new RepeatCounter(word, text);

            //Act
            newRepeatCounter.SetCounter(counter);
            int compare = newRepeatCounter.GetCounter();

            //Assert
            Assert.AreEqual(counter, compare);
        }

        [TestMethod]
        public void SplitText_ReturnSplitText_True()
        {
            //Arrange
            string word = "hello";
            string text = "hello world I'm Stephanie";
            RepeatCounter newRepeatCounter = new RepeatCounter(word, text);
            List<string> compare = new List<string> {};
            List<string> test = new List<string> {"hello", "world", "I'm", "Stephanie"};

            //Act
            newRepeatCounter.SetSplitText();
            compare = newRepeatCounter.GetSplitText();

            //Assert
            CollectionAssert.AreEqual(compare, test);
        }

        [TestMethod]
        public void DoCount_True()
        {
            //Arrange
            string word = "hello";
            string text = "hello world hello I'm hello, Stephanie! HELLO! Yes? Hello?";
            RepeatCounter newRepeatCounter = new RepeatCounter(word, text);
            newRepeatCounter.SetSplitText();

            //Act
            newRepeatCounter.DoCount();
            int compare = newRepeatCounter.GetCounter();

            //Assert
            Assert.AreEqual(5, compare);
        }
    }
}
