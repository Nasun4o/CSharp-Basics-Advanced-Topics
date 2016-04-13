# CSharp-Basics-Advanced-Topics

Problem 1.	Difference between Dates
Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. Examples:
First date
Second date	Days between
17.03.2014
30.04.2014	44
17.03.2014
17.03.2014	0
14.06.1980
5.03.2014	12317
5.03.2014
3.03.2014	-2

Problem 2.	Sorting Numbers
Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:
Input	Output
5
3
-3
2
122
0	-3
0
2
3
122
3
0
1
0	0
0
1

Problem 3.	Longest Area in Array
Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. Examples:
Input	Output
6
hi
hi
hello
ok
ok
ok	3
ok
ok
ok
2
SoftUni
Hello	1
SoftUni
4
hi
hi
hi
hi	4
hi
hi
hi
hi
5
wow
hi
hi
ok
ok	2
hi
hi

Problem 4.	Matrix of Palindromes
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
Input	Output
3 6	aaa aba aca	ada aea afa
bbb bcb bdb	beb bfb bgb
ccc cec cdc	cfc cgc chc
2 3	aaa aba aca
bbb bcb bdb
1 1	aaa
1 3	aaa aba aca

Problem 6.	Remove Names
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. Examples:
Input	Output
Peter Alex Maria Todor Steve Diana Steve
Todor Steve Nakov	Peter Alex Maria Diana
Hristo Hristo Nakov Nakov Petya
Nakov Vanessa Maria	Hristo Hristo Petya

Problem 7.	Join Lists
Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. Examples:
Input	Output
20 40 10 10 30 80
25 20 40 30 10	10 20 25 30 40 80
5 4 3 2 1
6 3 2	1 2 3 4 5 6
1
1	1

Problem 8.	Longest Word in a Text
Write a program to find the longest word in a text. Examples:
Input	Output
Welcome to the Software University.	University
The C# Basics course is awesome start in programming with C# and Visual Studio.	programming

Problem 9.	Extract URLs from Text
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
Examples:
Input	Output
The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.	http://nakov.com
www.nakov.com
http://blog.nakov.com

