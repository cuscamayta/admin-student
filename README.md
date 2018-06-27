# ADMStudent
Exercise code example for:

ADMStudent is a  simple modeling systems example for manage stuednts of different types.
# Features!
  - Store students in the system
  - Create new Student
  - Delete a specific student
  - Search for students in the follow ways:
        --  By student name, sorted alphabetically
        --  By student type(kinder,elementary,high,university) sorting by date, most recent to last recent
        --  By student gender and type(female elementary) sorting by date, most recent to least recent.

# About the project!
This sample was developed using :

| Technology | Site |
| ------ | ------ |
| Net. framework 4.5 | [Web Site](https://msdn.microsoft.com/en-us/magazine/dn574802.aspx "site") |
| C# 5.0  | [Web Site](https://blogs.msdn.microsoft.com/csharpfaq/2012/02/29/visual-studio-11-beta-is-here/ "site") |
| Ninject| [Web Site](http://www.ninject.org/ "site") |
| NancyFX | [Web Site](http://nancyfx.org/ "site") |

# Usage !

1. Open a command console as Administrator
2. Go to the folder bin/release in the root application
3. On the app root execute the Truextend.AdmStudent.API.Server.exe
4. Open a browser or postman
5. for execute the dfferent features follow the nes descriptions uri :
    5.1. Get all students (http://localhost:3002/#!/api/v1/admstudents/students/)
    5.2. Create student (http://localhost:3002/#!/api/v1/admstudents/students/)
    5.3. Get all students (http://localhost:3002/#!/api/v1/admstudents/students/)
    5.4. Get all students (http://localhost:3002/#!/api/v1/admstudents/students/)
    5.5. Get all students (http://localhost:3002/#!/api/v1/admstudents/students/)

# About the architecture
**AdmStudent** was developed following the microservice oriented architecture allowing the horizontal scalability, and also using the concept of NLayers and using the best programming practices.
