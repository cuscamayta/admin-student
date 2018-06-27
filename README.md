# ADMStudent
A simple modeling system example to manage different type of students
# Features!
1. Store students in the system.
2. Create new students.
3. Delete an specific student.
4. Search for students:
    - By student name, sorted alphabetically
	- By student type(kinder,elementary,high,university) sorting by date, most recent to last recent
	- By student gender and type(female elementary) sorting by date, most recent to least recent
	
    - Elemento de lista 4
        1. Elemento de lista 5
        2. Elemento de lista 6

# About the project!
This sample was developed using:

| Technology | Site |
| ------ | ------ |
| Net. framework 4.5 | [Web Site](https://msdn.microsoft.com/en-us/magazine/dn574802.aspx "site") |
| C# 5.0  | [Web Site](https://blogs.msdn.microsoft.com/csharpfaq/2012/02/29/visual-studio-11-beta-is-here/ "site") |
| Ninject| [Web Site](http://www.ninject.org/ "site") |
| NancyFX | [Web Site](http://nancyfx.org/ "site") |

# Usage !
## Running the service in mode console
Go to service root (**..\AdmStudent\Truextend.AdmStudent.API.Server\bin\Debug**) and execute **Truextend.AdmStudent.API.Server.exe** as **Administrator**.

### Consuming the service using postman
1. Please use the collection **AdmStudent.postman_collection.json** attached in the source code, use this collection for consume the service using Postman
2. To execute the different features follow below instructions :
   5.1. Get all students (http://localhost:3002/api/v1/students)
   5.2. Create student (http://localhost:3002/api/v1/student)
   5.3. Delete student (http://localhost:3002/api/v1/students/{studentId})
   5.4. Search student by type (http://localhost:3002/api/v1/students/types/{type})
   5.5. Search student by Name (http://localhost:3002/api/v1/students/{name})
5.5. Search student by type and gender (http://localhost:3002/api/v1/students/types/{type}/gender/{gender})

### Consuming the service using Tool Client
1. Go to the folder (**..\AdmStudent\Truextend.AdmStudent.UI.Console\bin\Debug**) in the root application.
2. Open a command console as Administrator in the same folder and execute **Truextend.AdmStudent.UI.Console.exe**.
3. The below are samples for use the tool.
   3.1. Ex: studentSolution.exe name=pepe
   3.2. Ex: studentSolution.exe type=kinder
   3.3. Ex: studentSolution.exe type=elementary gender=female

# About the architecture
**AdmStudent** was developed using the Microservice oriented architecture allowing the horizontal scalability, also the concepts of NLayers where used and the best programming practices.

# Limitations
The current sample is not completely finished, becasuse only contains the simple and basic implementation, the **Logger** services , and the **UnitOfWork** pattern is not implemented and it's possible that exist some bugs.

1. Elemento de lista 1
2.  Elemento de lista 2
    - Elemento de lista 3
    - Elemento de lista 4
        1. Elemento de lista 5
        2. Elemento de lista 6

- Elemento de lista 1
- Elemento de lista 2
    - Elemento de lista 3
    - Elemento de lista 4
        - Elemento de lista 5
        - Elemento de lista 6