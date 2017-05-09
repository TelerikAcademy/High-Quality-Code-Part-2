![Telerik Academy](https://github.com/TelerikAcademy/Common/raw/master/logos/telerik-header-logo.png)

# Project managment system

High-Quallity Code - Part 2 Exam, 4 May 2017  

Refactor and complete a project managment system.

![starwars](https://s.tmimgcdn.com/blog/wp-content/uploads/2015/12/the-code-wars.jpg?x47994)

---

### Application description

#### May the 4th be with you!

A long time ago, in a galaxy far, far away... the Death Star exploded during the Battle of Yavin. Yeah, damn vents. The thermal exhaust port was a significant flaw in the design. But if only they had a working project managment system when they were building it, this wouldn't have happened. This is where you come in. You have been tasked to fix and improve that system. You don't want to? Well, too bad you don't have a choice! Here is what you have been given:

- **Projects** have a `name`, `starting date`, `ending date`, `state` and collections of `users` and `tasks`. The `name` is required (cannot be null, empty or whitespace). The `starting date` must be between `1800-1-1` and `2017-1-1` (the battle was so long ago, C# doesn't support such datetimes, deal with it). The `ending date` must be between `2018-1-1` and `2144-1-1`. The `state` can be either `Active` or `Inactive`.

- **Tasks** have a `name`, `owner` and a `state`. The `name` and `owner` are required. The `state` can be either `Pending`, `InProgress` or `Done`.

- **Users** have `username` and `email`. Both are required. The `email` must be a valid address.

This is pretty much the OOP structure, quite simple, is it not? Now, a little bit about how the system works. As usual, you have a command line interface that accepts... well... `commands`. Those commands a listed further below. Now, lets take a look at the main classes and what they do:

- **Startup** - Bootstraps the application.

- **Engine** - Dictates where to read the input, when to process it and where to display the output. It can also log system exceptions, or display `UserValidatioExceptions`, caused by inproper user input.

- **FileLogger** - A logging class that works with `Log4Net` to create a `log.txt` file at the root of the solution. If you want to see what system exceptions the application has thrown, better look into that file.

- **Validator** - A complicated class, written by the servants of the dark side in order to confuse you. It deals with the validation of the models by reading the `DataAnnotation` attributes from them (we will talk about them in the Databases course). It validates user input.

- **CommandsFactory** - Has a method that takes in a string and tries to create a command from it. It also has a method for each possible command. It validates user input.

- **ModelsFactory** - Has methods that take in strings and build the previously stated models. Here is where all the parsing magic happens. It can also validate user input.

- **All the commands** - Simple classes, created by the `CommandsFactory`, that work with the database to store, extract and display data. 

Now, lets take a look at the commands themselves. They consist of two parts - the `command's name` and the `command's parameters`. The command's name is `case insensitive`. All parameters are required, there are no optional ones. Not all input validations return an adequate error message. This is not a bug and you should not be conserned with that. Use the 'log.txt' file for more details in such cases. Here are the commands, with a short description:

- **CreateProject _[Name] [StartingDate] [EndingDate] [State]_** - Creates a new project with the passed parameters. Project `names` are unique.

- **CreateUser _[ProjectId] [Username] [Email]_** - Creates a new user with the passed parameters and adds it to the `project` with the corresponding id. If a `project` with such id is not found, an `UserValidationException` is thrown. `Usernames` are unique for each project.

- **CreateTask _[ProjectId] [UserId] [Name] [State]_** - Creates a new task with the passed parameters and adds it to the `project` with the corresponding id. If a `project` or a project `user` with such ID is not found, an `UserValidationException` is thrown.

- **ListProjects** - Lists all `projects` and their details.

##### Input
The input data comes from the console. It consists of a sequence of commands, each staying at a separate single line. The input ends by the **"Exit"** command.

##### Output
The output should be on the console. It should consist of the outputs from each of the commands from the input sequence.

##### Constraints

- The command name will always be separated by the space symbol (" ") from the parameters and each parameter will be separated by the space symbol as well.
- Numbers will be valid 32-bit signed integer numbers.

---

### Application requirements

Modifying things that you are NOT allowed to modify will result in a penalty for `each violation`.

- **You are NOT allowed to modify the Database and IDatabase. (except to document)**
- **You are NOT allowed to modify the System.Console's input or output streams. That would result in integration tests.**
- **You are NOT allowed to modify the Settings.StyleCop ruleset.**

#### Problem 1. Code Refactoring (40 points)
Refactor the source code to improve its quality, **but do not change it's behavior**. Points will be taken away if the program no longer works properly or at all. Follow the single responsibility and dependency inversion principles. Don't try to "optimize" things you are not familiar with (like reflection algorithms). Find common refactoring problems and code smells, including (but not limited to):

- Fix compilation errors and warnings
- Apply better naming of classes, variables, fields, properties and parameters
- Apply better naming of project assemblies and namespaces.
- Extract members into appropriate files and namespaces
- Introduce constants, fields, properties and local variables
- Introduce enumerations and proper class abstractions
- Introduce property validations and guard clauses where appropriate
- Introduce interfaces, parent classes, virtual members and abstract classes
- Remove redundant code, usings, comments, constants and other things
- Remove middle man, dead code, hidden dependencies and other code smells
- Aim for self-documenting code.

#### Problem 2. Unit Testing (30 points)
Design and fully implement unit tests. You can use `VSTT`, `VSTT v2` or `NUnit` for the tests themselves. **All of your tests** require the use of mocking with either `JustMock` or `Moq`. Tests with no mocks will not be given any points. Some tests must be written with at least two test cases (different test data) in order to be given the full amount of points. 

- **Test the Engine class (10 points)**
  - Test if Start() reads something. `(0.5 points)`
  - Test if Start() writes something when passed "Exit". `(0.5 points)`
  - Test if Start() writes the command execution result. `(1 points)`
  - Test if Start() writes exception message when a UserValidationException occurs. `(2 points)`
  - Test if Start() logs exception message when generic Exception occurs. `(2 points)`
  - Test if Start() writes a string that contains "something happened" when generic Exception occurs. `(4 points)`
  
- **Test the CreateTaskCommand class (15 points)**
  - Test if Execute() throws when invalid parameters count are passed. `(0.5 points)`
  - Test if Execute() throws when empty parameters are passed. `(0.5 points)`
  - Test if Execute() calls the Projects property's indexer of the Database with the passed ID. `(4 points)`
  - Test if Execute() calls the Users property's indexer of the Project with the passed ID. `(4 points)`
  - Test if Execute() creates a Task with exactly those parameters. `(2 points)`
  - Test if Execute() adds the created Task to the Project. `(2.5 points)`
  - Test if Execute() returns a success message, containing the substring "Successfully created". `(1.5 points)`
  
- **Follow the unit testing best practices (5 points)**

Any other code is not required to be tested and will not bring any additional points. **You are NOT allowed to modify System.Console's input or output streams. That would result in integration tests. Hint: extract providers.**

#### Problem 3. StyleCop (8 points)
You have been provided with a StyleCop ruleset. **You are NOT allowed to modify the ruleset in any way.** You can install StyleCop from Tools > Extensions and Updates > Online > StyleCop. 

- 0 errors (8 points)
- from 1 to 10 errors (7 points)
- from 11 to 30 errors (5 points)
- from 31 to 60 errors (3 points)
- from 61 to 170 errors (0 points)
- from 171 to 220 errors (-3 points)
- more than 221 errors (-5 points)


#### Problem 4. Bug Fixing (8 points)

- Debug the code and find and fix the `four bugs` in it. (6 points)
- Describe them in the provided text file `Documentation.txt`. (2 points)

#### Problem 5. New Features (6 points)
Add the following new comamnd:

- **ListProjectDetails _[ProjectId]_** - Lists the details of a specific `project`. If a project with such id is not found, an `UserValidationException` is thrown with a message of your choosing.

#### Problem 6. Performance Bottleneck (4 points)
Find the performance bottleneck and briefly describe it in the provided text file `Documentation.txt`. Fix the problem if possible. If you cannot fix it, just describing it in the file awards you points.

#### Problem 7. Code Documentation (4 points)
Document  the **IDatabase, IModelsFactory, ICommandsFactory and IEngine** interfaces using `XML documentation`. Any other code documentation is not required.

---

### Null tests

#### 01. Input

```
CreateProject DeathStar 2016-1-1 2018-05-04 Active
CreateUser 0 DarthVader sexybeast@darkside.com
CreateTask 0 0 BuildTheStar Pending
Exit
```

#### 01. Expected output

```
Successfully created a new project!
Successfully created a new user!
Successfully created a new task!
Program terminated.
```

#### 02. Input

```
CreateProject DeathStar 2016-1-1 2018-05-04 Active
ListProjects
Exit
```

#### 02. Expected output

```
Successfully created a new project!
Name: DeathStar
  Starting date: 2016-01-01
  Ending date: 2018-05-04
  State: Active
  Users:
  - This project has no users!
  Tasks:
  - This project has no tasks!
Program terminated.
```

#### 03. Input

```
CreateProject DeathStar 2016-1-1 2018-05-04 Active
CreateUser 0 DarthVader sexybeast@darkside.com
ListProjects
Exit
```

#### 03. Expected output

```
Successfully created a new project!
Successfully created a new user!
Name: DeathStar
  Starting date: 2016-01-01
  Ending date: 2018-05-04
  State: Active
  Users:
    Username: DarthVader
    Email: sexybeast@darkside.com  
  Tasks:
  - This project has no tasks!
Program terminated.
```

#### 04. Input

```
CreateProject DeathStar 2016-1-1 2018-05-04 Active
CreateUser 0 DarthVader sexybeast@darkside.com
CreateTask 0 0 BuildTheStar Pending
CreateTask 0 0 SecureTheVents Pending
CreateTask 0 0 DominateOmegle InProgress
CreateProject DeathStar2 2016-1-1 2018-05-04 Active
CreateUser 1 DarthVader sexybeast@darkside.com
CreateTask 1 0 BuildTheStar Pending
CreateTask 1 0 SecureTheVents Pending
CreateTask 1 0 DominateOmegle InProgress
ListProjects
Exit
```

#### 04. Expected output

```
Successfully created a new project!
Successfully created a new user!
Successfully created a new task!
Successfully created a new task!
Successfully created a new task!
Successfully created a new project!
Successfully created a new user!
Successfully created a new task!
Successfully created a new task!
Successfully created a new task!
Name: DeathStar
  Starting date: 2016-01-01
  Ending date: 2018-05-04
  State: Active
  Users:
    Username: DarthVader
    Email: sexybeast@darkside.com  
  Tasks:
    Name: BuildTheStar
    Owner: DarthVader
    State: Pending
  -------------
    Name: SecureTheVents
    Owner: DarthVader
    State: Pending
  -------------
    Name: DominateOmegle
    Owner: DarthVader
    State: InProgress
Name: DeathStar2
  Starting date: 2016-01-01
  Ending date: 2018-05-04
  State: Active
  Users:
    Username: DarthVader
    Email: sexybeast@darkside.com  
  Tasks:
    Name: BuildTheStar
    Owner: DarthVader
    State: Pending
  -------------
    Name: SecureTheVents
    Owner: DarthVader
    State: Pending
  -------------
    Name: DominateOmegle
    Owner: DarthVader
    State: InProgress
Program terminated.
```
