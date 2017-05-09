using System.Collections.Generic;
using Telerik.ILS.Services.Courses.PracticalExams.CriteriaImporter;
public static class CriteriaForImporting
{
    public static IEnumerable<Criteria> GetCriteria()
    {
        var codeRefactoring = new List<Criteria>()
        {
            new Criteria("Problem 1. Code Refactoring (40 points)", string.Empty, new List<Option>()),
            new Criteria("Fix compilation errors and warnings", "StyleCop warnings do not count as compilation warnings.", new List<Option>()
            {
                new Option("Yes", 1),
                new Option("No", 0),
            }),
            new Criteria("Applied better naming of project assemblies and namespaces", string.Empty, new List<Option>()
            {
                new Option("Yes", 2),
                new Option("Somewhat", 1),
                new Option("No", 0),
            }),
            new Criteria("Remove redundant code, usings, comments, constants and other things", string.Empty, new List<Option>()
            {
                new Option("Yes", 2),
                new Option("Somewhat", 1),
                new Option("No", 0),
            }),
            new Criteria("Extracted members into appropriate files and namespaces", string.Empty, new List<Option>()
            {
                new Option("Yes", 3),
                new Option("Somewhat", 1.5M),
                new Option("No", 0),
            }),
            new Criteria("Introduced property validations and guard clauses where appropriate", string.Empty, new List<Option>()
            {
                new Option("Yes", 3),
                new Option("Somewhat", 1.5M),
                new Option("No", 0),
            }),
            new Criteria("Introduce constants, fields, properties and local variables", string.Empty, new List<Option>()
            {
                new Option("Yes", 4),
                new Option("Somewhat", 2),
                new Option("No", 0),
            }),
            new Criteria("Applied better naming of classes, variables, fields, properties and parameters", string.Empty, new List<Option>()
            {
                new Option("Yes", 5),
                new Option("Mostly", 3M),
                new Option("Somewhat", 1M),
                new Option("No", 0),
            }),   
            
                        
            new Criteria("The code is self-documenting", "It can easily be read and understood, without the need to dive deep into the code's implementation details.", new List<Option>()
            {
                new Option("Yes", 2),
                new Option("Somewhat", 1),
                new Option("No", 0),
            }),
            new Criteria("All fields are set to private.", string.Empty, new List<Option>()
            {
                new Option("Yes", 2),
                new Option("Somewhat", 1),
                new Option("No", 0),
            }),
            new Criteria("The default namespace was changed from 'Pesho' to something better", "Right click the project in the Solution Explorer window and go to Properties. Click Application on the left and go to the top.", new List<Option>()
            {
                new Option("Yes", 2),
                new Option("No", 0),
            }),
            new Criteria("The EnginePRovider class middleman was removed", string.Empty, new List<Option>()
            {
                new Option("Yes", 2),
                new Option("No", 0),
            }),
            new Criteria("The BuildCommand method middleman in the CommandsFactory was removed", string.Empty, new List<Option>()
            {
                new Option("Yes", 2),
                new Option("No", 0),
            }),
            new Criteria("Console references from the Engine class have been abstracted", string.Empty, new List<Option>()
            {
                new Option("They have been put into provider classes and injected", 3),
                new Option("Some of them are put into providers and are injected", 1.5M),
                new Option("They are still tightly coupled", 0),
            }),
            new Criteria("Each command accepts it's dependencies though some sort of injection", string.Empty, new List<Option>()
            {
                new Option("Dependencies are injected in the constructor", 3),
                new Option("Dependencies are injected in the properties", 3),
                new Option("Dependencies are injected, but not in every class", 1.5M),
                new Option("They are still tightly coupled", 0),
            }),
            new Criteria("Common validations from each command have been extracted", string.Empty, new List<Option>()
            {
                new Option("They have been put into an abstract base class (inheritance)", 4),
                new Option("They have been put into a helper class and injected via the constructor (composition)", 4),
                new Option("They are something in the middle", 2),
                new Option("They are still dublicated in each command", 0),
            }),
            new Criteria("The IDatabase interface was modified", "Use an online diff checker tool, it's easier that way. Spaces, tabs and other insignificant changes do not count as modifications. Changes in the usings or namespace does not count as modifications.", new List<Option>()
            {
                new Option("The interface was not modified", 0),
                new Option("The interface was modified", -10),
            }),
            new Criteria("The Database class was modified", "Use an online diff checker tool, it's easier that way. Spaces, tabs and other insignificant changes do not count as modifications. Changes in the usings or namespace does not count as modifications.", new List<Option>()
            {
                new Option("The class was not modified", 0),
                new Option("The class was modified", -10),
            }),
        };

        var unitTesting = new List<Criteria>
        {
            new Criteria("Problem 2. Unit Testing (30 points)", string.Empty, new List<Option>()),
            new Criteria("Test if Start() reads something", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 0.5M),
                new Option("Test is implemented semi-correctly or does not pass", 0),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Start() writes something when passed 'Exit'", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 0.5M),
                new Option("Test is implemented semi-correctly or does not pass", 0),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Start() writes the command execution resul.", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 1),
                new Option("Test is implemented semi-correctly or does not pass", 0.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Start() writes exception message when a UserValidationException occurs", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 2),
                new Option("Test is implemented semi-correctly or does not pass", 0.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Start() logs exception message when generic Exception occurs", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 2),
                new Option("Test is implemented semi-correctly or does not pass", 0.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Start() writes a string that contains 'something happened' when generic Exception occurs", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 4),
                new Option("Test is implemented semi-correctly or does not pass", 1.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),



            new Criteria("Test if Execute() throws when invalid parameters count are passed", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 0.5M),
                new Option("Test is implemented semi-correctly or does not pass", 0),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Execute() throws when empty parameters are passed", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 0.5M),
                new Option("Test is implemented semi-correctly or does not pass", 0),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Execute() calls the Projects property's indexer of the Database with the passed ID", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes with at least two testcases", 4),
                new Option("Test is implemented correctly and passes with one testcase", 3),
                new Option("Test is implemented semi-correctly or does not pass", 1.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Execute() calls the Users property's indexer of the Project with the passed ID", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes with at least two testcases", 4),
                new Option("Test is implemented correctly and passes with one testcase", 3),
                new Option("Test is implemented semi-correctly or does not pass", 1.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Execute() creates a Task with exactly those parameters", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 2),
                new Option("Test is implemented semi-correctly or does not pass", 0.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Execute() adds the created Task to the Project", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 2.5M),
                new Option("Test is implemented semi-correctly or does not pass", 1),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),
            new Criteria("Test if Execute() returns a success message, containing the substring 'Successfully created'", "Use author's solution as reference of correctness.", new List<Option>
            {
                new Option("Test is implemented correctly and passes", 1.5M),
                new Option("Test is implemented semi-correctly or does not pass", 0.5M),
                new Option("Test is implemented but without mocks/stubs", 0),
                new Option("Test is not implemented", 0),
            }),


            new Criteria("Unit tests are in a seperate assembly (visual studio project)", string.Empty, new List<Option>()
            {
                new Option("Yes", 1),
                new Option("No", 0),
            }),
            new Criteria("The unit tests assembly (visual studio project) is named with a .Tests prefix (or similar)", string.Empty, new List<Option>()
            {
                new Option("Yes", 1),
                new Option("No", 0),
            }),
            new Criteria("The testing NuGet packages are installed only on the unit tests assembly (visual studio project)", string.Empty, new List<Option>()
            {
                new Option("Yes", 1),
                new Option("No", 0),
            }),
            new Criteria("The unit tests are organized in one of the three popular naming conventions", string.Empty, new List<Option>()
            {
                new Option("Yes", 1),
                new Option("No", 0),
            }),
            new Criteria("The unit tests are well named and can be easily read/understood", string.Empty, new List<Option>()
            {
                new Option("Yes", 1),
                new Option("No", 0),
            }),
            new Criteria("Some of the unit tests modify the System.Console's input and/or output streams", string.Empty, new List<Option>()
            {
                new Option("No", 0),
                new Option("Yes", -5),
            }),
            new Criteria("Other testing and/or mocking frameworks are used than the allowed.", "You can use VSTT, VSTT v2 or NUnit for the tests themselves. All of your tests require the use of mocking with either JustMock or Moq.", new List<Option>()
            {
                new Option("No", 0),
                new Option("Yes", -5),
            })
        };

        var stylecop = new List<Criteria>()
        {
            new Criteria("Problem 3. StyleCop (8 points)", string.Empty, new List<Option>()),
            new Criteria("Has the following number of points", "Substitute the Settings.StyleCop file with the one from the skeleton to ensure no changes have been made. These error counts are valid only for the main ProjectManager assembly (visual studio project). Other assemblies should be ignored. Right click on the project in the Solution Explorer and click Run StyleCop. You should install StyleCop from Tools > Extensions and Updates > Online. Install 'Visual StyleCop' for VS2013 and VS2015 or 'StyleCop' for VS2017. If there is a 'StyleCop' or 'StyleCop.Analyzers' NuGet packages, remove them. For the correct amount of errors, look at the Output window, not the Erros List!", new List<Option>
            {
                new Option("0 errors", 8),
                new Option("from 1 to 10 errors", 7),
                new Option("from 11 to 20 errors", 6),
                new Option("from 21 to 30 errors", 5),
                new Option("from 31 to 40 errors", 4),
                new Option("from 41 to 50 errors", 3),
                new Option("from 51 to 60 errors", 2),
                new Option("from 61 to 70 errors", 1),
                new Option("from 71 to 170 errors", 0),
                new Option("from 171 to 220 errors", -3),
                new Option("more than 221 errors", -5)
            }),
        };

        var bugs = new List<Criteria>()
        {
            new Criteria("Problem 4. Bug Fixing (8 points)", string.Empty, new List<Option>()),
            new Criteria("User has swapped username and email", "When creating a new User in the ModelsFactory, the two parameters are swap passed to the User constructor.", new List<Option>()
            {
                new Option("Fixed and documented", 2),
                new Option("Fixed but not documented", 1.5M),
                new Option("Not fixed but documented", 0.5M),
                new Option("Not fixed nor documented", 0)
            }),
            new Criteria("CreateUser case missing", "When trying to parse the command's name in the CommandsFactory, the switch-case that handles that logic is missing the createuser string, therefore cannot create a CreateUserCommand.", new List<Option>()
            {
                new Option("Fixed and documented", 2),
                new Option("Fixed but not documented", 1.5M),
                new Option("Not fixed but documented", 0.5M),
                new Option("Not fixed nor documented", 0)
            }),
            new Criteria("FileLogger not logging", "When calling the Log method of the FileLogger, nothing happens because the Log method's body is commented.", new List<Option>()
            {
                new Option("Fixed and documented", 2),
                new Option("Fixed but not documented", 1.5M),
                new Option("Not fixed but documented", 0.5M),
                new Option("Not fixed nor documented", 0)
            }),
            new Criteria("Task is missing owner name", "When calling ToString() onto Task, the owner's username is not printed.", new List<Option>()
            {
                new Option("Fixed and documented", 2),
                new Option("Fixed but not documented", 1.5M),
                new Option("Not fixed but documented", 0.5M),
                new Option("Not fixed nor documented", 0)
            })
        };

        var newFeature = new List<Criteria>()
        {
            new Criteria("Problem 5. New Features (6 points)", string.Empty, new List<Option>()),
            new Criteria("ListProjectDetailsCommand class was implemented", string.Empty, new List<Option>()
            {
                new Option("The class exists", 1),
                new Option("The class exists but does not implement the ICommand interface", 0.5M),
                new Option("The class exists but it is named differently (no consistency)", 0.5M),
                new Option("The class does not exist", 0)
            }),
            new Criteria("ListProjectDetailsCommand class can be instantiated", string.Empty, new List<Option>()
            {
                new Option("The class can be created from a string (or reflection)", 2),
                new Option("The class can be created and/or used, but that logic was not implemented in the CommandsFactory", 1),
                new Option("The class can not be created and/or used", 0),
            }),
            new Criteria("ListProjectDetailsCommand class behaves correctly", string.Empty, new List<Option>()
            {
                new Option("The class takes the right parameters and returns a correct result", 3),
                new Option("The class takes the right parameters but does not return correct (or any) result", 0),
                new Option("The class takes the right parameters and returns invalid result", 0),
                new Option("The class does not take the right parameters nor returns anything adequate", 0),
            }),
        };

        var performance = new List<Criteria>()
        {
            new Criteria("Problem 6. Performance Bottleneck (4 points)", string.Empty, new List<Option>()),
            new Criteria("Fixed and documented the performance bottleneck", "The bottleneck is the two lines of datetime related operations with the empty while loop in the CommandsFactory BuildCommand method.", new List<Option>()
            {
                new Option("Fixed and documented", 4),
                new Option("Fixed but not documented", 3M),
                new Option("Not fixed but documented", 1M),
                new Option("Not fixed nor documented", 0)
            }),
        };

        var documentation = new List<Criteria>()
        {
            new Criteria("Problem 7. Code Documentation (4 points)", string.Empty, new List<Option>()),
            new Criteria("Documented the IDatabase interface with XML Documentation", string.Empty, new List<Option>()
            {
                new Option("Documented the interface and methods", 1),
                new Option("Documented the interface but not the methods", 0.5M),
                new Option("Documented the methods but not the interface itself", 0.5M),
                new Option("Not documented", 0),
            }),
            new Criteria("Documented the IModelsFactory interface with XML Documentation", string.Empty, new List<Option>()
            {
                new Option("Documented the interface and methods", 1),
                new Option("Documented the interface but not the methods", 0.5M),
                new Option("Documented the methods but not the interface itself", 0.5M),
                new Option("Not documented / Interface does not exist", 0)
            }),
            new Criteria("Documented the ICommandsFactory interface with XML Documentation", string.Empty, new List<Option>()
            {
                new Option("Documented the interface and methods", 1),
                new Option("Documented the interface but not the methods", 0.5M),
                new Option("Documented the methods but not the interface itself", 0.5M),
                new Option("Not documented / Interface does not exist", 0)
            }),
            new Criteria("Documented the IEngine interface with XML Documentation", string.Empty, new List<Option>()
            {
                new Option("Documented the interface and methods", 1),
                new Option("Documented the interface but not the methods", 0.5M),
                new Option("Documented the methods but not the interface itself", 0.5M),
                new Option("Not documented / Interface does not exist", 0)
            }),
        };


        var total = new List<Criteria>();
        total.AddRange(codeRefactoring);
        total.AddRange(unitTesting);
        total.AddRange(stylecop);
        total.AddRange(bugs);
        total.AddRange(newFeature);
        total.AddRange(performance);
        total.AddRange(documentation);

        return total;
    }
}
