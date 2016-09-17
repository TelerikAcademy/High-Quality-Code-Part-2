<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Code Tuning and Optimization
## When and How to Improve Code Performance?

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:39.43%; left:9.59%; width:16.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:50.62%; left:51.11%; width:52.36%; z-index:-1" /> -->

<article class="signature">
	<p class="signature-course">High-Quality Code</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="http://academy.telerik.com " class="signature-link">http://academy.telerik.com </a>
</article>

<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Computer Performance](#performance)
- [Code Tuning](#tuning)
- [dotTrace](#dottrace)
- [C# Optimizations](#optimization)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:14.93%; left:66.36%; width:30.03%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Computer Performance -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:49.33%; left:29.03%; width:46.16%; z-index:-1" /> -->

<!-- attr: { id:'performance', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="performance"></a>What is Performance?

```md
Computer performance is characterized by the amount of
useful work accomplished by a computer system compared
to the time and resources used.
```

- Аn aspect of software quality that is important in human–computer interactions
- Resources:
  - en.wikipedia.org/wiki/Computer_performance
  - C#: http://www.dotnetperls.com/optimization


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Good Computer Performance
- Good computer performance:
  - Short response time for a given piece of work
  - High throughput (rate of processing work)
  - Low utilization of computing resource(s)
  - High availability of the computing system or application
  - Fast (or highly compact) data compression and decompression
  - High bandwidth / short data transmission time


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Actual vs. Perceived Performance
- _Example_: “Vista's file copy performance is noticeably worse than Windows XP” – false:
  - Vista uses algorithm that perform better in most cases
  - Explorer waits 12 seconds before providing a copy duration estimate, which certainly provides no sense of smooth progress
  - The copy dialog is not dismissed until the write-behind thread has committed the data to disk, which means the copy is slowest at the end


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Is Performance Really a Priority?
- Performance improvements can reduce readability and complexity

```md
“Premature optimization is the root of all evil.”
 - Donald Knuth
```
```md
“More computing sins are committed in the name of
efficiency(without necessarily achieving it)
than for any othersingle reason – including
blind stupidity.”
 - W. A. Wulf
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# How to Improve Performance?
- **Software requirements**
  - Software cost vs. performance
- **System design**
  - Performance-oriented architecture
  - Resource-reducing goals for individual subsystems, features, and classes
- **Class and method design**
  - Data structures and algorithms

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # How to ImprovePerformance? -->
- **External Interactions**
  - Operating system
  - External devices – storage, network, Internet
- **Code Compilation / Code Execution**
  - Compiler optimizations
- **Hardware**
  - Very often the cheapest way
- **Code Tuning**

<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Tuning Concepts -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:43.83%; left:23.29%; width:55.67%; z-index:-1" /> -->

<!-- attr: { id:'tuning', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="tuning"></a>Introduction to Code Tuning
- What is **code tuning**/ **performance tuning**?
  - Modifying the code to make it run more efficiently (faster)
  - Not the most effective / cheapest way to improve performance
  - Often the code quality is decreased to increase the performance
- The 80 / 20 principle
  - 20% of a program’s methods consume 80% of its execution time

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Systematic Tuning – Steps
- **Systematic code tuning** follows these steps:
  - Assess the problem and establish numeric values that categorize acceptable behavior
  - Measure the performance of the system before modification
  - Identify the part of the system that is critical for improving the performance
    - This is called the **bottleneck**
  - Modify that part of the system to remove the bottleneck

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Systematic Tuning – Steps -->
  - Measure the performance of the system after modification
  - If the modification makes the performance better, adopt it
  - If the modification makes the performance worse, discard it

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Tuning Myths
- "Reducing the lines of code in a high-level language improves the speed or size of the resulting machine code" &rarr; **false!**

```cs
for i = 1 to 10
   a[i] = i
end for
```

```cs
a[1] = 1
a[2] = 2
a[3] = 3
a[4] = 4
...
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Tuning Myths -->
- "A fast program is just as important as a correct one" &rarr; **false!**
  - The software should work correctly!

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:35.59%; left:31.81%; width:45.84%; z-index:-1" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Tuning Myths -->
- "Certain operations are probably faster or slower than others" &rarr; **false!**
  - E.g. "add" is faster than "multiply"
  - Always **measure** performance!
- "You should optimize as you go" **&rarr;** **false!**
  - It is hard to identify bottlenecks before a program is completely working
  - Focus on optimization detracts from other program objectives
  - **Performance tuning breaks code quality!**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:18.84%; left:87.02%; width:18.51%; z-index:-1" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# When to Tune the Code?
- Use a high-quality design
  - Make the program right
  - Make it modular and easily modifiable
  - When it’s complete and correct, check the performance
- Consider compiler optimizations
- Measure, measure, measure
- Write clean code that’s easy to maintain
- Write use unit tests before optimizing


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!--# When to Tune the Code?-->
- Junior developers think that "**selection sort is slow**"? Is this correct?
  - Answer: depends!
  - Think how many elements you sort
  - Is "selection sort" slow for 20 or 50 elements?
  - Is it slow for 1,000,000 elements?
  - Shall we rewrite the sorting if we sort 20 elements?
- Conclusion: never optimize unless the piece of code is **proven to be a bottleneck**!

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Measurement
- Measure to find bottlenecks
- Measurements need to be precise
- Measurements need to be repeatable

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:37.02%; left:35.56%; width:36.14%; z-index:-1" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Optimize in Iterations
- Measure improvement after each optimization
- If optimization does not improve performance &rarr; revert it
- Stop testing when you know the answer

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:42.31%; left:40.23%; width:30.85%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# JetBrains dotTrace
## Resolve Performance Issues

<!-- attr: { id:'dottrace', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="dottrace"></a>What is dotTrace?
- What is dotTrace?
  - A performance analysis tool
  - Also called **profiler**
  - Designed for code and memory profiling
  - Measures the **frequency** and **duration** of function calls
  - Traces the **call** **stack**
  - Collects information about **memory** **usage**


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Demo: dotTrace
## Profiling and Improving Performance of "Mandelbrot Fractal" application

<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # C# Code Optimizations -->
<!-- ## http://www.dotnetperls.com/optimization -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:45.74%; left:30.67%; width:43.65%; z-index:-1" /> -->


<!-- attr: { id:'optimization', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="optimization"></a>Do We Need Optimizations?
- The C# language is **fast** (unlike Java)
  - A bit slower than C and C++
- Is it worthwhile to benchmark programming constructs?
  - We should **forget about small** **optimizations**
    - Say about 97% of the time: premature optimization is the root of all evil
  - At all levels of performance optimization
    - You should be **taking measurements** on the changes you make


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Benchmarking with Stopwatch
- **Stopwatch** measures time elapsed
- Useful for micro-benchmarks optimization

```cs
using System.Diagnostics;

static void Main()
{
  Stopwatch stopwatch = new Stopwatch();
  stopwatch.Start();

    // Do something …

  stopwatch.Stop();
  Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# C# Optimization Tips
- **Static fields** are faster than instance fields
- Instance methods are always slower than **static methods**
  - To call an instance method, the instance reference must be resolved first
  - Static methods do not use an instance reference
- It is faster to **minimize** **method arguments**
  - Even use constants in the called methods instead of passing them arguments
  - This causes less stack memory operations


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # C# Optimization Tips -->
- When you call a method in your C# program
  - The runtime allocates a separate memory region to store all local variable slots
  - This memory is allocated on the **stack**
  - Sometimes we can **reuse the same variable**
    - Well-known anti-pattern for quality code
- **Constants** are fast
  - Constants are not assigned a memory region, but are instead considered values
  - Injected directly into the instruction stream


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # C# Optimization Tips -->
- The **switch** statement compiles in a different way than **if**-statements typically do
  - Some switches are faster than **if**-statements
- Using **two-dimensional arrays** is relatively slow
  - We can explicitly create a one-dimensional array and access it through arithmetic
  - The .NET Framework enables faster accesses to **jagged arrays** than to 2D arrays
  - Jagged arrays may cause slower garbage collections


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # C# Optimization Tips -->
- **StringBuilder** can improve performance when appending strings
  - Using **char[]**  may be the fastest way to build up a string
- If you can store your data in an **array of bytes**, this allows you to save memory
  - Smallest unit of addressable storage – byte
- Simple array **T[]** is always faster than **List<T>**
  - Using efficient data structures (e.g. **HashSet<T>** and **Dictionary<K,T>**) may speed-up the code


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # C# Optimization Tips -->
- Use **lazy evaluation**(caching)

```cs
public int GetSize()
{
  if (this.size == null)
    size = CalculateSize();
  return this.size;
}
```

- **for**-loops are faster than foreach loops
  - **foreach** uses enumerator
- C# structs are slower (in most cases)
  - Structs are copied in their entirety on each function call or return value


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # C# Optimization Tips -->
- Instead of testing each case using logic, you can translate it through a **lookup** **table**
  - It eliminates costly branches in your code
- It is more efficient to work with a **char** instead of a single-char string
- Use **JustDecompile** or any other decompilation tool to view the output IL code
- Use Debug &rarr; Windows &rarr; **Disassembly** in VS
- Don’t do unnecessary optimizations!
- Measure after each change

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Optimization Tips – Inline Code
- Manual or compiler optimization that replaces a method call with the method body
  - You can manually paste a method body into its call spot or let the compiler to decide
- Typically, **inlined****code**improves performance in micro-benchmarks
  - … but makes the code hard to maintain!
- In .NET 4.5 you can force code inlining:

```cs
[MethodImpl(MethodImplOptions.AggressiveInlining)]
void SomeMethod() { … }
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# Measuring Performance in C#-->
<!--## [Demo]()-->

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 2: Code Tuning and Optimizations
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
