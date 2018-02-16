using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    }
}
