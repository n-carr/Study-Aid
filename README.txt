This application works very similarly to flash cards. You will be presented with a question and, once you have thought of your answer, you must click a button to be presented with the answer. This application will track which questions you answer correctly and incorrectly so that you can re-do the quiz with only the questions you answered incorrectly at the end.

I hope this application serves you well.


HOW TO USE THIS APPLICATION:
----------------------------
A quiz can be started in one of two ways:

1. Manually entering the questions and answers. 
	This process involves typing or copying and pasting the questions into the questions column and the answers into the answers column, then pressing the "Start Quiz" button.
	Note that a ^^ in either the question or answer portion will be replaced by a new line during the quiz.

2. Using a quiz file. 
	This process involves setting up a .txt file in a specific format (see below) before running the application, then selecting and running the file through the "Start from File" button.

After you start the quiz, you will be given questions and answers one at a time. If you get a question wrong, it will be noted automatically. At the end of the quiz you will be given the option to repeat the quiz with only the questions you answered incorrectly.


QUIZ FILES:
-----------
To run this program, you may create a quiz file (a .txt file formatted in a special way) that contains one question/answer per line. 

The question and answer portions must be divided by && and a new line in either the question or answer portion is denoted by ^^.

Here is an example of how to set up your quiz file.

Question 1? && Answer 1.
Question 2? ^^ A) Option 1. ^^ B) Option 2. && Answer 2.
Question 3? && Answer 3A. ^^ Answer 3B.

Please note that whether or not you place spaces before or after these special character sets (&& and ^^) is irrelevant. The spaces will be removed, so feel free to add spaces if you feel it will improve readability.


FILE PROBLEMS:
--------------
You may be notified upon starting the quiz that your quiz file could not be opened. Either the file has been corrupter in some way (which is unlikely) or the file was moved or deleted. If the latter has occurred, simply select the file again and run the quiz.

You may be notified upon starting the quiz that one or more of your questions is missing its "delimiter." This means that the && intended to split the question from the answer is missing. You can either continue the quiz without this question ("OK") or stop the quiz and attempt to run it again after fixing the quiz file ("Cancel").


CREDIT:
-------
Nathaniel Carr. 2018.