// Student Requests

GET http://localhost:57601/students

GET http://localhost:57601/students/1

POST http://localhost:57601/students

	{
		"StudentID": 10,
		"LastName": "Person",
		"FirstName": "Test"
	}


PUT http://localhost:57601/students/10

	{    
		"StudentID": 10,
		"LastName": "Edited",
		"FirstName": "Test"
	}

DELETE http://localhost:57601/students/10


// Course Requests

GET http://localhost:57601/courses

GET http://localhost:57601/courses/1

POST http://localhost:57601/courses

	{
		"CourseID": 10,
		"Title": "Gym"
	}

PUT http://localhost:57601/courses/10

	{
		"CourseID": 10,
		"Title": "Gym Class"
	}

DELETE http://localhost:57601/courses/10


//Registration Requests
POST http://localhost:57601/Register

	{
		"StudentID": 1,
		"CourseID": 1 
	   
	}
	
GET http://localhost:57601/Register