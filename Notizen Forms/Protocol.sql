Drop Database if exists Protocol;
Create Database Protocol;
use Protocol;

Create Table Professor
(
	ID int not null primary key auto_increment,
    Professor_Name varchar(128) not null
);
Create Table Course
(
	ID int not null primary key auto_increment,
    Course_Name varchar(128) not null
);
Create Table Notes
(
	ID int primary key not null auto_increment,
    Note varchar(128) not null,
    Text text not null,
    Date_Time datetime not null,
    Day varchar(30) not null,
    Course int  not null,
    Professor int not null,
    constraint fk_course foreign key(Course) references Course(id),
    constraint fk_professor foreign key(Professor) references Professor(id)
);

Create View SeeNotes as
select n.ID, n.Note,n.text, n.Date_Time, n.Day, k.Course_Name,  d.Professor_Name from Notes n
join Course k on n.Course = k.ID
join Professor d on n.Professor = d.ID;

insert into Course(Course_Name)
values
("-"),
('Datenbank'),
('IT-Systemtechnik - Programmierung'),
('Fachunterricht Anwendungsentwicklung'),
('Projektmanagment');
insert into Professor (Professor_Name)
values
('-');

select * from Notes;
Select * from Professor;
Select * From Course;
select * from SeeNotes;

-- drop user Test@localhost;
-- create user 'Test'@'localhost'  identified by	'111111';
-- Grant All privileges on *.* to 'Test'@'localhost';

Delimiter //
Create procedure Insert_Notes
(
In p_note varchar(128), 
In p_Text text, 
In p_Date_Time datetime, 
In p_Day varchar(30), 
In p_Course int, 
In p_Professor int
)
BEGIN
	insert into Notes(Note, Text, Date_Time, Day, Course, Professor)
    values
    (p_note, p_Text, p_Date_Time, p_Day, p_Course, p_Professor);
END //

-- call Insert_Notes("","",now(),"Tag", 1,1);


