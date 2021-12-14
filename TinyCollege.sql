USE master;
GO

IF DB_ID(N'TinyCollege') IS NOT NULL DROP DATABASE TinyCollege;

CREATE DATABASE TinyCollege;
GO

USE TinyCollege
GO

CREATE TABLE [Student] (
  [stuId] int IDENTITY (80,1) NOT NULL PRIMARY KEY 
, [studentName] nvarchar(50) NOT NULL
);
GO
CREATE TABLE [Course] (
  [courseId] int IDENTITY (14,1) NOT NULL PRIMARY KEY 
, [courseName] nvarchar(50) NOT NULL
, [semesterOffered] nvarchar(11) NOT NULL
);
GO
CREATE TABLE [Enroll] (
  [courseId] int NOT NULL FOREIGN KEY 
(courseId) REFERENCES Course(courseId)
, [stuId] int NOT NULL FOREIGN KEY
(stuId) REFERENCES Student(stuId),
PRIMARY KEY (courseId, stuId)
);

SELECT Course.courseId, Course.courseName, Student.studentName 
FROM Enroll 
JOIN Student ON Enroll.stuId = Student.stuId 
JOIN Course on Enroll.courseId = Course.courseId 
WHERE Course.courseId = 1;


GO
SET IDENTITY_INSERT [Student] ON;
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
1,N'Alexis Snider');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
2,N'Desiree Bonilla');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
3,N'John Lyon');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
4,N'Ryan McSorley');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
5,N'Christopher Perry ');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
6,N'Christion Smith');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
7,N'Bob Dylan');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
8,N'Tom Petty');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
9,N'David Bowie');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
10,N'Janet Jackson');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
11,N'Paula Abdul');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
12,N'Gloria Estefan');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
13,N'Grace Slick');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
14,N'Janis Joplin');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
15,N'Jimmy Hendrix');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
16,N'Alburt Camus');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
17,N'Kurt Vonnegut');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
18,N'Ursula Le Guin');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
19,N'Robert Frost');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
20,N'Harper Lee');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
21,N'Maya Angelou');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
22,N'George Orwell');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
23,N'Agatha Christie');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
24,N'Sylvia Plath');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
25,N'William Blake');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
26,N'Margaret Atwood');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
27,N'Simone de Beauvoir');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
28,N'Ernest Hemingway');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
29,N'Stephen King');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
30,N'JK Rowling');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
31,N'Ron Swanson');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
32,N'Leslie Knope');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
33,N'April Ludgate');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
34,N'Andy Dwyer');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
35,N'Ann Perkins');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
36,N'Tom Haverford');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
37,N'Ben Wyatt');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
38,N'Chris Traeger');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
39,N'Donna Meagle');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
40,N'Mark Brendanawicz');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
41,N'Jerry Gergich');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
42,N'Abed Nadir');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
43,N'Troy Barnes');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
44,N'Britta Perry');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
45,N'Annie Edison');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
46,N'Shirley Bennett');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
47,N'Jeff Winger');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
48,N'Pierce Hawthorne');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
49,N'Bill Murray');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
50,N'Wes Anderson');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
51,N'Stanley Kubrick');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
52,N'David Lynch');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
53,N'Martin Scorsese');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
54,N'Francis Ford Coppola');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
55,N'George Costanza');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
56,N'Elaine Benes');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
57,N'Cosmo Kramer');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
58,N'Jerry Seinfield');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
59,N'Tommy Pickles');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
60,N'Angelica Pickles');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
61,N'Chuckie Finster');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
62,N'Kimi Finster');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
63,N'Susie Carmichael');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
64,N'Betty DeVille');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
65,N'Helga G. Pataki');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
66,N'Gerald Johanssen');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
67,N'Harold Berman');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
68,N'Phoebe Heyerdahl');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
69,N'Lila Sawyer');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
70,N'Stinky Peterson');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
71,N'Thaddeus Gammelthorpe');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
72,N'Patty Smith');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
73,N'Wolfgang Puck');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
74,N'Julia Child');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
75,N'Gordon Ramsay');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
76,N'Missy Barns');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
77,N'Mary Hill');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
78,N'Bob Burger');
GO
INSERT INTO [Student] ([stuId],[studentName]) VALUES (
79,N'Bob Villa');
GO
SET IDENTITY_INSERT [Student] OFF;
GO
SET IDENTITY_INSERT [Course] ON;
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
1,N'Introductory Agile Software Development',N'Fall 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
2,N'Introductory Databases',N'Fall 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
3,N'Intermediate Agile Software Development',N'Spring 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
4,N'Intermediate Databases',N'Spring 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
5,N'Advanced Agile Software Development',N'Fall 2022');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
6,N'Advanced Databases',N'Spring 2022');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
7,N'Literature I',N'Fall 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
8,N'Literature II',N'Spring 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
9,N'Poetry I',N'Fall 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
10,N'Poetry II',N'Spring 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
11,N'Algebra I',N'Fall 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
12,N'Algebra II',N'Spring 2021');
GO
INSERT INTO [Course] ([courseId],[courseName],[semesterOffered]) VALUES (
13,N'Art I',N'Fall 2021');
GO
SET IDENTITY_INSERT [Course] OFF;
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,1);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,11);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,21);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,31);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,41);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,51);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,61);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
1,71);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,2);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,12);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,22);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,32);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,42);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,52);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,62);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
2,72);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,3);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,13);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,23);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,33);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,43);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,53);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,63);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
3,73);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,4);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,14);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,24);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,34);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,44);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,54);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,64);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
4,74);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,5);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,15);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,25);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,35);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,45);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,55);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,65);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
5,75);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
6,6);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
6,16);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
6,26);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
6,36);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
6,46);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
6,56);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
6,67);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
7,7);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
7,17);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
7,27);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
7,37);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
7,47);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
7,57);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
7,66);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
8,8);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
8,18);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
8,28);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
8,38);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
8,48);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
8,58);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
8,68);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
9,9);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
9,19);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
9,29);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
9,39);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
9,49);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
9,59);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
9,69);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
10,10);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
10,20);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
10,30);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
10,40);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
10,50);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
10,60);
GO
INSERT INTO [Enroll] ([courseId],[stuId]) VALUES (
10,70);
GO