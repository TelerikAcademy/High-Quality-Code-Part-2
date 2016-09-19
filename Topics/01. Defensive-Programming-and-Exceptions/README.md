<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Defensive Programming, Assertions and Exceptions  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:60%; left:62%; width:38.41%; z-index:-1; border: 1px solid white; border-radius: 5px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:15%; left:2%; width:17.08%; z-index:-1" /> -->
<article class="signature">
	<p class="signature-course">High-Quality Code - Part II</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="http://academy.telerik.com " class="signature-link">http://academy.telerik.com </a>
</article>


<!-- section start -->
# Defensive programming
“Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the Universe trying to produce bigger and better idiots. So far, the Universe is winning.”   

\- Rick Cook, The Wizardry Compiled

<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- What is Defensive Programming?
- Assertions and **Debug.Assert(…)**
- Exceptions Handling Principles
- Error Handling Strategies
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:39.67%; left:67.37%; width:36.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:49.92%; left:22.72%; width:21.23%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Defensive Programming -->
<!-- ## Using Assertions and Exceptions Correctly -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:42.96%; left:8.07%; width:39%; z-index:-1; border: 1px solid white; border-radius: 5px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:43.20%; left:55.79%; width:45%; z-index:-1; border: 1px solid white; border-radius: 5px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is Defensive Programming?
  - Similar to defensive driving – you are never sure what other drivers will do
  - **Expect incorrect input** and handle it correctly
  - Think not only about the usual execution flow, but consider also **unusual** situations!

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:64%; left:30%; width:40%; z-index:-1; border: 1px solid white; border-radius: 5px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Protecting from <br/> Invalid Input
- “Garbage in &rarr; garbage out” – **Wrong!**
  - Garbage in &rarr; nothing out / exception out / error message out / no garbage allowed in
- Check the values of all data from external sources (from user, file, internet, DB, etc.)
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:63%; left:2%; width:52.77%; z-index:-1; border: 1px solid black; border-radius: 5px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:76%; left:50%; width:50.37%; z-index:-1; border: 1px solid black; border-radius: 5px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Protecting from <br/> Invalid Input -->
- Check the values of all **routine input parameters**
- Decide how to handle **bad inputs**
  - Return neutral value
  - Substitute with valid data
  - Throw an exception
  - Display error message, log it, etc.
- The best form of defensive coding is not inserting error at first place




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Assertions -->
<!-- ## Checking Preconditions and Postconditions -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:45%; left:20%; width:30.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:45%; left:60%; width:25.56%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Assertions
- **Assertion** – a statement placed in the code that **must always be true** at that moment
  - Assertions are used during development
    - Removed in release builds
  - Assertions check for bugs in code

```cs
public double GetAverageStudentGrade()
{
  Debug.Assert(studentGrades.Count > 0,
     "Student grades are not initialized!");
  return studentGrades.Average();
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:30%; left:85%; width:24.13%; z-index:-1; border: 1px solid white; border-radius:5px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Assertions -->
  - Use assertions for conditions that **should never occur** in practice
    - Failed assertion indicates a **fatal error** in the program (usually unrecoverable)
- Use assertions to **document assumptions** made in code (preconditions & postconditions)  

```cs
private Student GetRegisteredStudent(int id)
{
		Debug.Assert(id > 0);
		Student student = registeredStudents[id];
		Debug.Assert(student.IsRegistered);
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Assertions -->
  - Failed assertion indicates a **fatal error** in the program (usually unrecoverable)
- Avoid putting executable code in assertions  

```cs
Debug.Assert(PerformAction(), "Could not perform action");
```   
  - Won’t be compiled in production. Better use:

```cs
bool actionPerformed = PerformAction();
Debug.Assert(actionPerformed, "Could not perform action");
```
  - Assertions should fail loud
    - It is fatal error &rarr; total crash


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Assertions
## [Demo]()
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:18%; left:0%; width:40%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
## Best Practices for Exception Handling
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:55%; left:30%; width:40%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Exceptions
- **Exceptions** provide a way to inform the caller about an error or exceptional events
  - Can be caught and processed by the callers
- Methods can **throw** exceptions:

```cs
public void ReadInput(string input)
{
  if (input == null)
  {
    throw new ArgumentNullException("input");  }
  …
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Use **try-catch** statement to handle exceptions:
- You can use multiple **catch** blocks to specify handlers for different exceptions
- Not handled exceptions propagate to the caller

```cs
void PlayNextTurn()
{
  try
  {
    readInput(input);
    …
  }
  catch (ArgumentException e)
  {
    Console.WriteLine("Invalid argument!");
  }
}
```

<div class="fragment balloon" style="top:55%; left:40.55%; width:35.26%">Exception thrown here</div>
<div class="fragment balloon" style="top:70%; left:43.20%; width:52.01%">The code here will not be executed</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Use **finally** block to execute code even if exception occurs (not supported in C++):
- Perfect place to perform cleanup for any resources allocated in the **try** block

```cs
void PlayNextTurn()
{
  try
  {
    …  }
  finally
  {
    Console.WriteLine("Hello from finally!");
  }
}
```

<div class="fragment balloon" style="top:60%; left:22.04%; width:37.91%">Exceptions can be eventually thrown here</div>
<div class="fragment balloon" style="top:78%; left:27.33%; width:49.37%">The code here is always executed</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Use exceptions to notify the other parts of the program about errors
  - Errors that should not be ignored
- Throw an exception only for conditions that are **truly exceptional**
  - Should I throw an exception when I check for user name and password? &rarr; better return false
- Don’t use exceptions as control flow mechanisms


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Throw exceptions at the right **level of abstraction**

```cs
class Employee
{
	// Bad
  …
  public TaxId
  { get { throw new NullReferenceException(…); }
}
```
```cs
class Employee
{
	// Better
  …
  public TaxId
  { get { throw new EmployeeDataNotAvailable(…); }
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Use **descriptive error messages**
  - Incorrect example:
	```cs
	throw new Exception("Error!");
	```
  - _Example_:
	```cs
	throw new ArgumentException("The speed should be a number " +
  "between " + MIN_SPEED + " and " + MAX_SPEED + ".");
	```
  - Avoid **empty catch blocks**
	```cs
	try
{
  …
}
catch (Exception ex)
{
}
	```





<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Always include the exception **cause** when throwing a new exception
```cs
try
{
  	WithdrawMoney(account, amount);
}
catch (DatabaseException dbex)
{
	  throw new WithdrawException(String.Format(
	    "Can not withdraw the amount {0} from acoount {1}",
	    amount, account), dbex);
}
```
<div class="fragment balloon" style="top:70%; left:45.84%; width:47.60%">We chain the original exception (the source of the problem)</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Catch only exceptions that you are capable to process correctly
  - Do not catch all exceptions!
  - Incorrect example:  

	```cs
	try
	{
	  ReadSomeFile();
	}
	catch
	{
	  Console.WriteLine("File not found!");
	}
	```  

  - What about **OutOfMemoryException**?




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Exceptions -->
- Have an exception handling strategy for all unexpected / unhandled exceptions:
  - Consider logging (e.g. Log4Net)
  - Display to the end users only messages that they could understand
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:55%; left:3.74%; width:48.48%; z-index:-1; border: 1px solid black; border-radius:5px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:55%; left:61.26%; width:44.55%; z-index:-1; border: 1px solid black; border-radius:5px;" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Exceptions
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:42%; left:33%; width:34.38%; z-index:-1; border: 1px solid black; border-radius:5px;" /> -->



<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Error Handling Strategies -->
## Assertions vs. Exceptions vs. Other Techniques
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:57%; left:72.02%; width:23.20%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:57%; left:46.09%; width:17.63%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:57%; left:15.21%; width:23.25%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Error Handling Techniques
- How to handle **errors that you expect** to occur?
  - Depends on the situation:
    - Throw an **exception** (in OOP)
      - The most typical action you can do
    - Return a neutral value, e.g. **-1** in **IndexOf(…)**
    - Substitute the next piece of valid data (e.g. file)
    - Return the same answer as the previous time
    - Substitute the closest legal value
    - Return an error code (in old languages / APIs)
    - Display an error message in the UI
    - Call method / Log a warning message to a file
    - Crash / shutdown / reboot


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Assertions vs. Exceptions
- **Exceptions** are announcements about error condition or unusual event
  - Inform the caller about error or exceptional event
  - Can be caught and application can continue working
- **Assertions** are fatal errors
  - Assertions always indicate bugs in the code
  - Can not be caught and processed
  - Application can’t continue in case of failed assertion
- When in doubt &rarr; throw an exception


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Assertions in C#
- Assertions in C# are rarely used
  - In C# prefer throwing an **exception** when the input data / internal object state are invalid
    - Exceptions are used in C# and Java instead of **preconditions checking**
  - Prefer using **unit testing** for testing the code instead of **postconditions checking**
- Assertions are popular in C / C++
  - Where exceptions & unit testing are not popular
- In JS there are no built-in assertion mechanism


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Error Handling Strategy
- Choose your **error handling strategy** and follow it consistently
  - Assertions / exceptions / error codes / other
- In C#, .NET and OOP prefer using **exceptions**
  - Assertions are rarely used, only as additional checks for fatal error
  - Throw an exception for incorrect input / incorrect object state / invalid operation
- In JavaScript use exceptions: **try-catch-finally**
- In non-OOP languages use error codes


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Robustness vs. Correctness
- How will you handle error while calculating single pixel color in a computer game?
- How will you handle error in financial software? Can you afford to lose money?
- **Correctness** == never returning wrong result
  - Try to achieve correctness as a primary goal
- **Robustness** == always trying to do something that will allow the software to keep running
  - Use as last resort, for non-critical errors


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Assertions vs. Exceptions

```cs
public string Substring(string str, int startIndex, int length)
{
  if (str == null)
  {
    throw new NullReferenceException("Str is null.");
  }
  if (startIndex >= str.Length)
  {
    throw new ArgumentException(
      "Invalid startIndex:" + startIndex);
  }
  if (startIndex + count > str.Length)
  {
    throw new ArgumentException("Invalid length:" + length);
  }
  …
  Debug.Assert(result.Length == length);
}
```

<div class="fragment balloon" style="top:34.62%; left:66.12%; width:29.09%">Check the input and preconditions</div>
<div class="fragment balloon" style="top:75%; left:20.28%; width:46.72%">Perform the method main logic</div>
<div class="fragment balloon" style="top:85%; left:55%; width:24.68%">Check the postconditions</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Error Barricades
- Barricade your program to stop the damage caused by incorrect data
- Consider same approach for class design
  - Public methods &rarr; validate the data
  - Private methods &rarr; assume the data is safe
  - Consider using exceptions for public methods and assertions for private
- **public methods / functions**
- **private methods / functions**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:20%; left:100%; width:13.46%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:40%; left:100%; width:10.50%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Being Defensive About Defensive Programming
- Too much defensive programming is not good
  - Strive for balance
- How much defensive programming to leave in production code?
  - Remove the code that results in hard crashes
  - Leave in code that checks for important errors
  - Log errors for your technical support personnel
  - See that the error messages you show are user-friendly

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 2: Defensive Programming
## Questions? -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [HQC-Part 1 course](http://academy.telerik.com/student-courses/programming/high-quality-code-part-2/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
