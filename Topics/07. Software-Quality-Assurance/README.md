<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Software Quality Assurance
## Planning and Tracking Software Quality
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:18.51%; left:-10%; width:18.52%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:52.01%; left:68.30%; width:35.50%; z-index:-1" /> -->
<article class="signature">
	<p class="signature-course">High-Quality Code - Part 2</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</article>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [What Is Software Quality?](#quality)
- [Causes of Software Defects](#defects)
- [What is Quality Assurance?](#qa)
- [Improving the Software Quality](#improvingQuality)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:34.38%; left:81.40%; width:22.14%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What Is Software Quality? -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:40%; left:32.89%; width:43.81%; z-index:-1" /> -->


<!-- attr: { id:'quality', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="quality"></a>What is Software Quality?
- **Pressman's** definition of "Software Quality“

```md
Software quality measures how well software is designed
(quality of design), and how well the software
conforms to that design (quality of conformance)
```
  - Whereas **quality of conformance** is concerned with implementation, **quality of design** measures how valid the design and requirements are in creating a worthwhile product


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What is Software Quality? -->
- **IEEE** Definition of  "Software Quality“

```md
- The degree to which a system, component, or
process meets specified requirements
- The degree to which a system, component, or
process meets customer or user needs or expectations
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:53.77%; left:49.59%; width:55.87%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What is Software Quality? -->
- Steve McConnell's **Code Complete** defines two **types of quality characteristics**:
  - **External**
    - Those parts of a product that face its users
  - **Internal**
    - Not apparent to the user

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:40.55%; left:72.98%; width:27.33%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# External Characteristics
- Correctness
- Usability
- Efficiency
- Reliability
- Integrity
- Adaptability
- Accuracy
- Robustness

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:20%; left:25%; width:70%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Internal Characteristics
- Maintainability
- Flexibility
- Portability
- Reusability
- Readability
- Testability
- Understandability

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:12.34%; left:59.88%; width:43.77%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Dependencies
<img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:12.34%; left:13.82%; width:79.75%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Causes of Software Defects -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:40%; left:29.94%; width:49.37%; z-index:-1" /> -->


<!-- attr: { id:'defects', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="defects"></a>Causes of Software Defects
- A human being can make an **error (mistake)**
- Errors produce **defects**
  - **Defects are faults / bugs** in the program code, or in a document
- If a defect in code is executed, that might cause a **failure:**
  - Fail to do what it should do
  - Do something it shouldn’t

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:10%; left:92.34%; width:20.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:52%; left:64.09%; width:16.79%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:55.54%; left:85%; width:20.09%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Causes of Software Defects -->
- The human factor
  - Humans make **mistakes**
  - Poor **training**
  - **Time** pressure
  - **Code** complexity
  - Complexity of **infrastructure**
  - Changing **technologies**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:12.34%; left:64.56%; width:32.62%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:46.72%; left:69.24%; width:26.45%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Causes of Software Defects -->
- Organizational factors
  - Inefficient **team** communication
  - Incomplete **data** specifications
  - Unclearly defined **requirements**
  - Incorrect project **documentation**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:44.08%; left:73.92%; width:26.45%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Causes of Software Defects -->
- Environmental conditions
  - Radiation
  - Magnetism
  - Electronic fields
  - Pollution
  - Etc.

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:12.34%; left:71.58%; width:26.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:48.37%; left:59.19%; width:38.55%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What is Quality Assurance? -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:40%; left:25.73%; width:57.30%; z-index:-1" /> -->


<!-- attr: { id:'qa', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="qa"></a>What Is Software Quality Assurance?
- **IEEE** Definition of  "Software Quality Assurance“

```md
- A planned and systematic pattern of all
actions necessary to provide adequate
confidence that an item or product conforms
to established technical requirements.
- A set of activities designed to evaluate
the process by which the products are developed
or manufactured.  Contrast with quality control.
```


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What Is Software Quality Assurance? -->
- Software quality assurance is a **planned and systematic program of activities**
  - Designed to ensure that a system has the **desired characteristics**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:45%; left:57%; width:44.08%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Role of SQA
- What is the role of SQA in the software development process?
  - **Monitoring** the software engineering processes
  - Reducing the **risk** of problems
  - Ensuring the **quality** of the software
  - Providing information for **decision-making**
  - Help meeting **standards**:
    - Contractual or legal requirements
    - Industry-specific standards

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:55.54%; left:84.21%; width:21.16%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# QA vs. Testing
<img class="slide-image" showInPresentation="true" src="imgs\pic29.png" style="top:12%; left:5%; width:90%; z-index:-1" />



<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Improving the Software Quality -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:53%; left:26.32%; width:56.20%; z-index:-1" /> -->


<!-- attr: { id:'improvingQuality', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="improvingQuality"></a>Techniques for Improving Software Quality
- Software-quality **objectives**
- Explicit quality-assurance **activity**
- Testing **strategy**
- Software-engineering **guidelines**
- Informal technical **reviews**
- Formal technical **reviews**
- External **audits**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic23.png" style="top:46.63%; left:73.92%; width:30.41%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Relative Effectiveness
<img class="slide-image" showInPresentation="true" src="imgs\pic30.png" style="top:12%; left:5%; width:90%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Higher Defect Detection Rate
- Combination of Techniques
- Extreme programing Techniques

<img class="slide-image" showInPresentation="true" src="imgs\pic31.png" style="top:30%; left:5%; width:90%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Recommended Combination
- Formal inspections of all requirements, all architecture, and designs for critical parts of a system
- Modeling or prototyping
- Code reading or inspections
- Automated testing

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:52.78%; left:48.37%; width:55.69%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The General Principle
- The General Principle of Software Quality is that **improving quality reduces development costs**
  - The industry-average productivity for a software product is about **10 to 50** of lines of delivered code per person **per day**
  - Debugging and associated refactoring and other **rework** consume about **50 percent of the time** on a traditional, naive software-development cycle


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 2: Software Quality Assurance
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
