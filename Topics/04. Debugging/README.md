<!-- section start -->
<!-- attr: {class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Debugging
## Building Rock-Solid Software
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:60%; left:75%; width:20.10%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:20%; left:10%; width:21.68%; z-index:-1; border-radius:10px;" /> -->
<article class="signature">
	<p class="signature-course">High-Quality Code - Part 2</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="http://academy.telerik.com " class="signature-link">http://academy.telerik.com </a>
</article>




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Introduction to Debugging](#debug)
- [Visual Studio Debugger](#vs-debug)
- [Breakpoints](#breakpoint)
- [Data Inspection](#inspection)
- [Threads and Stacks](#threads)
- [Finding a Defect](#defects)
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:20.36%; left:65.96%; width:34.38%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Introduction to Debugging -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:45%; left:29%; width:40%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'debug', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="debug"></a> What is Debugging?
- The process of locating and fixing or bypassing bugs (errors) in computer program code
- To debug a program:
  - Start with a problem and stable source state
  - Isolate the source of the problem
  - Fix it and send the fix to the source control
    - One change at a time
  - Create regression test
- Debugging tools (called debuggers) help identify coding errors


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Debugging vs. Testing
- **Testing**
  - A means of **initial detection of errors**
- **Debugging**
  - A means of **diagnosing** and **correcting** the root causes of errors that have already been detected
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:47.05%; left:16.84%; width:34.24%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:52.22%; left:69.19%; width:17.67%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em'  } -->
# Importance of Debugging
- Perfect code is an illusion
  - There is no non-trivial software without bugs
    - [programmers.stackexchange.com/q/41248/163921](http://programmers.stackexchange.com/q/41248/163921)
  - There are factors that are out of our control
- Debugging can viewed as one big decision tree
  - Individual nodes represent theories
  - Leaf nodes represent possible root causes
- You should be able to debug code that is written years ago
- $60 Billion per year in economic losses due to software defects (in USA only)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em' } -->
# How to Avoid Bugs
- Reduce number of code lines
  - Write less and write smarter. Keep it simple.
- Reduce complexity / Good code separation
  - Reduce number of possible code paths
- Understand the size of the input & output spaces (be aware of the corner cases)
- Unit test (TDD) with almost 100% test coverage
- Always assume your code is not working
  - Prove it otherwise!
  - Always check the code you write
- Experience matters / Read, learn, code




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Visual Studio Debugger -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:45%; left:32%; width:35%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'vs-debug', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="vs-debug"></a>Visual Studio Debugger
- Visual Studio IDE gives us a lot of tools to debug your application
  - Adding breakpoints
  - Visualize the program flow
  - Control the flow of execution
  - Data tips
  - Watch variables
  - Debugging multithreaded programs
  - and many more…


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# How To Debug a Process
- Starting a process under the Visual Studio debugger
- Attaching to an already running process
  - Without a solution loaded you can still debug
  - Useful when solution isn't readily available
  - Debug menu -> <br/>Attach to Process
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:53%; left:51.46%; width:45%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Debugging a Solution
- Debug menu, Start Debugging item
  - F5 is a shortcut
- Easier access to the source code and symbols since its loaded in the solution
- Certain differences exist in comparison to debugging an already running process
  - Hosting for ASP.NET application
    - VS uses a replacement of the real IIS


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Debug Windows
- Debug Windows are the means to introspect on the state of a process
- Opens a new window with the selected information in it
- Window categories
  - Data inspection
  - Threading
- Accessible from menu
  - Debug -> Windows
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:37.02%; left:58.95%; width:43.16%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Debugging Toolbar
- Convenient shortcut to common debugging tasks
  - Step into
  - Step over
  - Continue
  - Break
  - Breakpoints
- Customizable to fit your needs
  - Add and/or remove buttons
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:23.80%; left:44.91%; width:53%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em' } -->
# Controlling Execution
- By default, an app will run uninterrupted (and stop on exception or breakpoint)
- Debugging is all about looking at the state of the process
- Controlling execution allows:
  - Pausing execution
  - Resuming execution
  - Stepping through the application in smaller chunks
  - In the case of IntelliTrace (recording steps), allows backward and forward stepping


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# IntelliTrace
- IntelliTrace operates in the background, records what you are doing during debugging
- You can easily get a past state of your application from the IntelliTrace
- <div style="width:60%"> You can navigate your code with any part and see what’s happened
  - To navigate, just click any of the events that you want to explore
  </div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:43%; left:65%; width:38%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Options and Settings
- Visual Studio offers quite a few knobs and tweaks in the debugging experience
- Options and settings is available via Debug -> Options and Settings
- Examples of Options and Settings
  - Enable just my code (ignore other code)
  - Enable .NET framework source stepping
  - Source server support
  - Symbols (line numbers, variable names)
  - Much more…




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Breakpoints -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:45%; left:10%; width:79.30%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'breakpoint', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="breakpoint"></a>Breakpoints
- Ability to stop execution based on certain criteria is key when debugging
  - When a function is hit
  - When data changes
  - When a specific thread hits a function
  - much more
- Visual Studio debugger has a huge feature set when it comes to breakpoints


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Visual Studio Breakpoints
- Stops execution at a specific instruction (line of code)
  - Can be set using Debug->Toggle breakpoint
    - F9 shortcut
    - Clicking on the left most side of the source code window
- By default, the breakpoint will hit every time execution reaches the line of the code
- Additional capabilities: condition, hit count, value changed, when hit, filters


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Managing Breakpoints
- Managed in the breakpoint window
- Adding breakpoints
- Removing or disabling breakpoints
- Labeling or grouping breakpoints
- Export/import breakpoints
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:57%; left:6.16%; width:94.17%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Breakpoint Filters
- Allows you to excerpt even more control of when a breakpoint hits
- Examples of customization
  - Machine name
  - Process ID
  - Process name
  - Thread ID
  - Thread name
- Multiple can be combined using `&, ||, !`
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:35%; left:63%; width:35%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Data Inspection -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:45%; left:30%; width:40%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'inspection', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="inspection"></a>Data Inspection
- Debugging is all about data inspection
  - What are the local variables?
  - What is in memory?
  - What is the code flow?
  - In general - What is the state of the process right now and how did it get there?
- As such, the ease of data inspection is key to quick resolution of problems


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Visual Studio Data Inspection
- Visual Studio offers great data inspection features
  - Watch windows
  - Autos and Locals
  - Memory and Registers
  - Data Tips
  - Immediate window
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:22.92%; left:58%; width:41.43%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Watch Window
- Allows you to inspect various states of your application
- Several different kinds of “predefined” watch windows
  - Autos
  - Locals
- “Custom” watch windows also possible
  - Contains only variables that you choose to add
  - Right click on the variable and select “Add to Watch”


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Autos and Locals
- Locals watch window contains the local variables for the specific stack frame
  - Debug -> Windows -> Locals
  - Displays: name of the variable, value and type
  - Allows drill down into objects by clicking on the + sign in the tree control
- Autos lets the debugger decide which variables to show in the window
  - Loosely based on the current and previous statement


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Memory and Registers
- Memory window can be used to inspect process wide memory
  - Address field can be a raw pointer or an expression
  - Drag and drop a variable from the source window
  - Number of columns displayed can be configured
  - Data format can be configured
- Registers window can be used to inspect processor registers


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Data Tips
- Provides information about variables
  - Variables must be within scope of current execution
- Place mouse pointer over any variable
  - Variables can be expanded by using the + sign
- Pinning the data tip causes it to always stay open
- Comments can be added to data tips
- Data tips support drag and drop
- Importing and exporting data tips


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Immediate Window
- Useful when debugging due to the expansive expressions that can be executed
  - To output the value of a variable <name of variable>
  - To set values, use <name of variable>=<value>
  - To call a method, use <name of variable>.<method>(arguments)
  - Similar to regular code
  - Supports Intellisense
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:52.01%; left:62.69%; width:38.63%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Threads and Stacks -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:45%; left:30%; width:45%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'threads', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="threads"></a>Threads
- Fundamental unit of code execution
- Commonly, more than one thread
  - .NET, always more than one thread
- Each thread has a memory area associated with it known as a stack used to
  - Store local variables
  - Store frame specific information
- Memory area employs last in first out semantics


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Threads Window
- Contains an overview of thread activity in the process
- Includes basic information in a per thread basis
  - Thread ID’s
  - Category
  - Name
  - Location
  - Priority
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:40.55%; left:36.49%; width:67.03%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Callstacks
- A threads stack is commonly referred to as a callstack
- Visual Studio shows the elements of a callstack
  - Local variables
  - Method frames
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:37%; left:63%; width:37.69%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic23.png" style="top:53%; left:12.16%; width:46.10%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Finding a Defect -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:45%; left:30%; width:40%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'defects', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="defects"></a>Finding a Defect
- **Stabilize** the error
- **Locate** the source of the error
  - **Gather** the data
  - **Analyze** the data and form hypothesis
  - Determine how to **prove** or **disprove** the hypothesis
  - Prove or disprove the hypothesis by **2c**
- **Fix** the defect
- **Test** the fix
- **Look** for similar errors
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic25.png" style="top:53.77%; left:87.95%; width:16.01%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Tips for Finding Defects
- Use all available data
- Refine the test cases
- Check unit tests
- Use available tools
- Reproduce the error several different ways
- Generate more data to generate more hypotheses
- Use the results of negative tests
- Brainstorm for possible hypotheses
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic26.png" style="top:14.99%; left:80.47%; width:20.28%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Tips for Finding Defects -->
- Narrow the suspicious region of the code
- Be suspicious of classes and routines that have had defects before
- Check code that’s changed recently
- Expand the suspicious region of the code
- Integrate incrementally
- Check for common defects
- Talk to someone else about  the problem
- Take a break from the problem
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic27.png" style="top:59.94%; left:96.60%; width:9.73%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Fixing a Defect
- Understand the problem before you fix it
- Understand the program, not just the problem
- Confirm the defect diagnosis
- Relax
- Save the original source code
- Fix the problem not the symptom
- Make one change at a time
- Add a unit test that expose the defect
- Look for similar defects
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic28.png" style="top:28.21%; left:78.60%; width:28.36%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Psychological Considerations
- Your ego tells you that your code is good and doesn't have a defect even when you've seen that it has one.
- How "Psychological Set" Contributes to Debugging Blindness

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic29.png" style="top:45%; left:58.95%; width:38.57%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 2: Debugging
## Questions? -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [HQC-Part 2 course](http://academy.telerik.com/student-courses/programming/high-quality-code-part-2/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
