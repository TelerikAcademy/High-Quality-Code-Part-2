<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Software Engineering Fundamentals
## Software Development Practices and Methodologies
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:53.39%; left:78.92%; width:26.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:54.21%; left:52.06%; width:22.66%; z-index:-1" /> -->
<article class="signature">
	<p class="signature-course">Learning & Development</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="http://academy.telerik.com " class="signature-link">http://academy.telerik.com </a>
</article>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Software engineering overview](#overview)
  - [Requirements](#requirements)
  - [Design](#design)
  - [Construction](#construction)
  - [Testing](#testing)
  - [Project management](#pm)
- [Development methodologies overview](#methodologies)
  - [The waterfall development process](#waterfallProcess)
  - [Heavyweight methodologies](#heavyweightMethodologies)
  - [Agile methodologies, SCRUM and XP](#agile)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:21.56%; left:70.17%; width:35.26%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Engineering
## Requirements, Design, Construction, Testing -->

<!-- attr: { id:'overview', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="overview"></a>What is Software Engineering?  

```md
Software engineering is the application of a systematic,
disciplined, quantifiable approach to the development,
operation, and maintenance of software.
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:60.06%; left:10.37%; width:26.56%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:59.94%; left:44.10%; width:54.49%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Engineering
- **Software engineering** is:
  - An engineering discipline that provides knowledge, tools, and methods for:
    - Defining software requirements
    - Performing software design
    - Software construction
    - Software testing
    - Software maintenance tasks
    - Software project management

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:43.20%; left:76.26%; width:27.77%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Development Activities
- Software development always includes the following activities (to some extent):
  - Requirements analysis
  - Design
  - Construction
  - Testing (sometimes)
- These activities do not follow strictly one after another (depends on the methodology)!
  - Often overlap and interact




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Requirements -->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:38.29%; left:29.79%; width:49.74%; z-index:-1" /> -->


<!-- attr: { id:'requirements', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="requirements"></a>Software Requirements
- **Software requirements** define the functionality of the system
  - Answer the question "what?", not "how?"
  - Define constraints on the system
- Two kinds of requirements
  - **Functional** requirements
  - **Non-functional** requirements

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:50.63%; left:75.79%; width:28.20%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Requirements Analysis
- **Requirements analysis** starts from a vision about the system
  - Customers don't know what they need!
  - Requirements come roughly and are specified and extended iteratively
- The outcome is the **Software Requirements Specification (SRS)** or set of **User Stories**
- **Prototyping** is often used, especially for the user interface (UI)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Requirements Specification (SRS) -->
- The **Software Requirements Specification (SRS)** is a formal requirements document
- It describes in details:
  - Functional requirements
    - Business processes
    - Actors and use-cases
  - Non-functional requirements
    - E.g. performance, scalability, constraints, etc.

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:33.01%; left:75.79%; width:25.56%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Agile Requirements and User Stories
- Requirements specifications are too heavy
  - Does not work well in dynamic projects that change their requirements every day
- Agile development needs **agile requirements**
  - Split into small iterations
- How to split the requirements?
  - Use simple, informal requirements description
  - User story: a small feature that brings some value to the end-user


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is User Story?
- **User story**
  - User needs to accomplish something
  - Written informal (in words / images / sketches)
  - Looks like use-case but is different (less formal)
- User stories have
  - **Actor** (who?)
  - **Goal** (what?, why?)
  - Other info
    - **Owner, estimate, …**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:44.08%; left:56.25%; width:45.74%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# User Story – _Example_
<img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:14.93%; left:19.65%; width:68.76%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Requirements
- It is always hard to describe and document the requirements in comprehensive way
  - Good requirements save time and money
- Requirements **always change** during the project!
  - Good requirements reduces the changes
  - Prototypes significantly reduce changes
  - Agile methodologies are flexible to changes
    - Incremental development in small iterations


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Requirements Specifications (SRS), User Stories and UI Prototypes
## [Demo]() -->


<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Architecture and Software Design -->


<!-- attr: { id:'design', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="design"></a>Software Architecture and Software Design
- **Software design** is a technical description (blueprints) about how the system will implement the requirements
- The **system architecture** describes:
  - How the system will be decomposed into subsystems (modules)
  - Responsibilities of each module
  - Interaction between the modules
  - Platforms and technologies

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:50.25%; left:87.34%; width:18.62%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# System Architecture Diagram – _Example_
<img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:14.99%; left:19.23%; width:69.55%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Architecture Diagram – _Example_
<img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:14.99%; left:14.01%; width:79.39%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Design
- Detailed Design
  - Describes the internal module structure
  - Interfaces, data design, process design
- Object-Oriented Design
  - Describes the classes, their responsibilities, relationships, dependencies, and interactions
- Internal Class Design
  - Methods, responsibilities, algorithms and interactions between them


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Design Document (SDD) -->
- The **Software Design Document (SDD)**
  - Formal description of the architecture and design of the system
- It contains:
  - Architectural design
    - Modules and their interaction (diagram)
  - For each module
    - Process design (diagrams)
    - Data design (E/R diagram)
    - Interfaces design (class diagram)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:52.89%; left:87.95%; width:16.64%; z-index:-1" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# Software Design Document
## [Demo]()-->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:53%; left:12.16%; width:82.94%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Construction
## Implementation, Unit Testing, Debugging, Integration -->


<!-- attr: { id:'construction', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="construction"></a>Software Construction
- During the **software construction** phase developers create the software
  - Sometimes called **implementation** phase
- It includes:
  - Internal method design
  - Writing the source code
  - Writing unit tests (optionally)
  - Testing and debugging
  - Integration

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:53.77%; left:74.82%; width:29.73%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Writing the Code
- **Coding** is the process of writing the programming code (the source code)
  - The code strictly follows the design
  - Developers perform **internal method design** as part of coding
- The **source code** is the output ofthe software construction process
  - Written by developers
  - Can include unit tests

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:47.60%; left:85.73%; width:19.04%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Testing the Code
- **Testing** checks whether the developed software conforms to the requirements
  - Aims to identify defects (bugs)
- Developers test the code after writing it
  - At least run it to see the results
  - **Unit testing** works better
    - Units tests can be repeated many times
- System testing is done by the QA engineers
  - Unit testing is done by developers

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:39.67%; left:89.41%; width:16.26%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Debugging
- **Debugging** aims to find the source of already identified defect and to fix it
  - Performed by developers
- Steps in debugging:
  - Find the defect in the code
    - Identify the source of the problem
    - Identify the exact place in the code causing it
  - Fix the defect
  - Test to check if the fix is working correctly

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic23.png" style="top:22.04%; left:74.00%; width:29.90%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Integration
- **Integration** is putting all pieces together
  - Compile, run and deploy the modules as a single system
  - Test to identify defects
- Integration strategies
  - Big bang, top-down and bottom-up
  - Continuous integration

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:30.85%; left:70.93%; width:30.36%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Coding != Software Engineering
- Inexperienced developers consider coding the core of development
  - In most projects coding is only 20% of the project activities!
  - The important decisions are taken during the requirements analysis and design
  - Documentation, testing, integration, maintenance, etc. are often disparaged
- Software engineering is not just coding!
  - **Programmer** != **software engineer**




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Verification and Testing -->


<!-- attr: { id:'testing', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="testing"></a>Software Verification
- What is **software verification**?
  - It checks whether the developed software conforms to the requirements
  - Performed by the Software Quality Assurance Engineers (QA engineers)
- Two approaches:
  - Formal **reviews** and **inspections**
  - Different kinds of **testing**
- Cannot certify absence of defects!
  - Can only decrease their rates

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic26.png" style="top:49.37%; left:82.34%; width:22.04%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Testing
- **Testing** checks whether the developed software conforms to the requirements
- Testing aims to find defects (bugs)
  - **Black-box** and **white-box** tests
  - Unit tests, integration tests, system tests, acceptance tests
  - Stress tests, load tests, regression tests
  - Tester engineers can use automated test tools to record and execute tests


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Testing Process
- Test planning
  - Establish test strategy and test plan
  - During requirements and design phases
- Test development
  - Test procedures, test scenarios, test cases, test scripts
- Test execution
- Test reporting
- Retesting the defects

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic27.png" style="top:50%; left:80.86%; width:23.35%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Test Plan and Test Cases
- The **test plan** is a formal document that describes how tests will be performed
  - List of test activities to be performed to ensure meeting the requirements
  - Features to be tested, testing approach, schedule, acceptance criteria
- Test scenarios and test cases
  - **Test scenarios** – stories to be tested
  - **Test cases** – tests of single function


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Test Plans and Test Cases
## [Demo]() -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic28.png" style="top:45.87%; left:7.78%; width:32.62%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic29.png" style="top:45.87%; left:60%; width:32.62%; z-index:-1" /> -->



<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Software Project Management -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic30.png" style="top:53.10%; left:24.80%; width:57.25%; z-index:-1" /> -->


<!-- attr: { id:'pm', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="pm"></a>What is Project Management?
- **Project management** is the discipline of organizing and managing work and resources in order to successfully complete a project
- Successfully means within defined scope, quality, time and cost constraints
- Project constraints:
	- Scope
	- Time
	- Cost
	- Quality

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic52.png" style="top:53%; left:45%; width:40%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is Software Project Management?
- **Software project management**
  - Management discipline about planning, monitoring and controlling software projects
- **Project planning**
  - Identify the scope, estimate the work involved, and create a project schedule
- **Project monitoring and control**
  - Keep the team up to date on the project's progress and handle problems


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is Project Plan?
- The **project plan** is a document that describes how the work on the project will be organized
  - Contains tasks, resources, schedule, milestones, etc.
  - Tasks have start, end, assigned resources (team members), % complete, dependencies, nested tasks, cost, etc.
- Project management tools simplify creating and monitoring project plans


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Project Plan – _Example_
<img class="slide-image" showInPresentation="true" src="imgs\pic31.png" style="top:14.10%; left:4.42%; width:97.21%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Development Methodologies
## Waterfall, Scrum, Lean Development, Kanban, Extreme Programming -->


<!-- attr: { id:'methodologies', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="methodologies"></a>What is a Development Methodology?
- A **development methodology** is a set of practices and procedures for organizing the software development process
  - A set of rules that developers have to follow
  - A set of conventions the organization decides to follow
  - A systematical, engineering approach for organizing and managing software projects


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Development Methodologies
- Back in history
  - The "**Waterfall**" Process
    - Old-fashioned, not used today
  - Rational Unified Process (RUP)
  - Microsoft Solutions Framework (MSF)
- Modern development methodologies
  - **Agile development** processes
  - Scrum, Kanban, Lean Development, Extreme Programming (XP), etc.

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic33.png" style="top:13.05%; left:78.20%; width:27.70%; z-index:-1" /> -->




<!-- attr: { id:'waterfallProcess', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="waterfallProcess"></a>The Waterfall Process
- The waterfall development process:

<img class="slide-image" showInPresentation="true" src="imgs\pic53.png" style="top:23.05%; left:20%; width:80%; z-index:-1" />
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic37.png" style="top:12.34%; left:93.14%; width:14.10%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic38.png" style="top:52.89%; left:4.68%; width:14.19%; z-index:-1" /> -->


<!-- attr: { id:'heavyweightMethodologies', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="heavyweightMethodologies"></a>Formal Methodologies
- Formal methodologies are heavyweight!

<img class="slide-image" showInPresentation="true" src="imgs\pic54.png" style="top:22.34%; left:3.14%; width:94.10%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Agile Development -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic39.png" style="top:40%; left:21.43%; width:63.74%; z-index:-1" /> -->


<!-- attr: { id:'agile', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="agile"></a>The Agile Manifesto
“Our highest priority is to satisfy the
customer through early and continuous
delivery of valuable software“

Manifesto for Agile


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Agile Spirit
- Incremental
  - **Working software** over comprehensive documentation
- Cooperation
  - **Customer collaboration** over contract negotiation
- Straightforward
  - **Individuals and interactions** over processes and tools
- Adaptive
  - **Responding to change** over following a plan

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic41.png" style="top:14.10%; left:85.71%; width:19.39%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Agile Methodologies
- Scrum
- Kanban
- Lean Software Development
- e**X**treme **P**rogramming (XP)
- Feature-Driven Development (FDD)
- Crystal family of methodologies
- Adaptive Software Development (ASD)
- Dynamic System Development Model (DSDM)
- Agile Unified Process (AUP)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic42.png" style="top:14.99%; left:74.85%; width:27.71%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Extreme Programming:The 12 Key Practices

<img class="slide-image" showInPresentation="true" src="imgs\pic55.png" style="top:19.67%; left:3.33%; width:80.67%; z-index:-1" />
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic43.png" style="top:19.67%; left:53.33%; width:50.67%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Scrum
- Scrum is an iterative incremental framework for managing complex projects
- Scrum roles:
  - **Scrum Master** – maintains the Scrum processes
  - **Product Owner** – represents the stakeholders
  - **Team** – a group of about 7 people
    - The team does the actual development: analysis, design, implementation, testing, etc.

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic44.png" style="top:65.80%; left:76.72%; width:26.57%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Scrum Terminology
- **Sprint**
  - An iteration in the Scrum development
  - Usually few weeks
- **Product Backlog**
  - All features that have to be developed
- **Sprint Backlog**
  - All features planned for the current sprint

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic45.png" style="top:66%; left:57.08%; width:46.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Scrum Process Framework
<img class="slide-image" showInPresentation="true" src="imgs\pic46.png" style="top:15.87%; left:7.49%; width:91.68%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Scrum Practices
- Sprint Planning Meeting
  - At the beginning of the sprint cycle
  - Establish the Sprint backlog
- Daily Scrum stand-up meeting
  - Each day during the sprint – project status from each team member
  - Timeboxed to 15 minutes
- Sprint Review Meeting
  - Review the work completed / not completed

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic47.png" style="top:13.21%; left:86.08%; width:19.39%; z-index:-1" /> -->


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 2: Software Engineering Fundamentals
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
