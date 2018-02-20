# Word Counter
#### C Sharp and ASP.Net web app for determining the number of times a word appears in a block of text, 2-16-18  

#### _By Stephanie Faber_  

## Description
_This is a project designed to take a user input word and block of text and then determine the number of times that word appears in the text. The home page consists of a form asking for the word to search for, as well as the block of text to search through. Once submitted, the user is taken to another page displaying their inputs and returning to them the number of times the word appeared. Finally, there is a link to route the user back to the homepage._  

## Specifications

1. User enters localhost:5000 to browser and it takes them to the Index.
* Example input: User enters localhost:5000 to browser
* Example output: Index is displayed with a form to take their word and text block

2. On Index, user enters words to the form and clicks Submit. It takes them to a page telling them how many times the word appeared in the text.
* Example input: User clicks Submit
* Example output: Goes to Count page

3. On redirect after the form is submitted, a new RepeatCounter object is created with the word and text block. A method is run to determine the number of times the word appears.
* Example input: User submits form on Index
* Example output: new RepeatCounter is created, method is run on instance to generate number of times word appears

4a. A word counted even when ended with a comma.
* Example input: Word is "hello". Text is "What is hello, if not a longer way of saying hi?"
* Example output: Count is 1.

4b. A word is counted when ended with a period, or other ending punctuation like ! or ?. This is because ending punctuation will be assumed as the end of a sentence.
* Example input: Word is "hello". Text is "To you a hello!"
* Example output: Count is 1.

4c. Contractions will not be broken up and counted. Trying to account all contractions as two words, such as "there's" as "there" and "is" OR "has" is too circumstantial and out of the scope of this project.
* Example input: Word is "hello". Text is "Hello's for you, to you a hello. What is hello, if not a longer way of saying hi?"
* Example output: Count is 2. Hello's does not count because it's contracted with -'s. Hello's does not equal hello.


5. On Count, the user's word and text is displayed, along with the number of times the word appears. At the bottom is a link "Go Back", on click takes back to Index.
* Example input: User's word, text, and word counter is displayed. Go Back is clicked.
* Example output: Index appears with empty form


## Setup/Installation Requirements

* _Clone Repository_

* _Download and install .NET Core 1.1 SDK_

* _Download and install .NET runtime_

* _Download and install Mono for your platform_

* _In Mono command prompt, navigate to this project's folder_

* _In Mono command prompt, enter >dotnet restore_

* _In Mono command prompt, enter >dotnet build_

* _If there are no errors: In Mono command prompt, enter >dotnet run_

* _If there is an error, please contact me via email and describe your issue_

* _When the command prompt runs the build, enter localhost:5000 to your web browser. This should take you to the index page._

Github Repository Link (https://github.com/eyesicedover/ContactBook)

## Support and contact details

_Please email me directly at eyesicedover@gmail.com_

## Technologies Used

* HTML
* ASP.NET
* Razor
* .NET Core
* .NET SDK

### License

*MIT License*

Copyright (c) 2018 **_Stephanie Faber_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
