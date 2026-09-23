# 🐛 Bug Journal

> A record of problems I encountered, how I investigated them, what caused them, and what each failure taught me.

---

# BUG-VS001 — [Visual Studio Solution and Project Opening]

**Date Discovered:** 2026-09-21
**Date Resolved:** 2026-09-21
**Project:** ATIP Project
**Technology:** C#, .NET
**Area:** Technical Issue
**Severity:** Low
**Status:** Resolved
---

## 🐛 Problem

Visual Studio Failling to read my Solution and Project Properly to Enable me run the Project

>

---

## 🎯 Expected Behavior

THE Green Run button was suppose to appear for me to run my code.

>

---

## 💥 Actual Behavior

Project was not recognized by Visual Studio as a MAUI Project

>

---

## 🔁 Steps to Reproduce

How can I make the problem happen again?

1. Opening a project or Solution as a folder
2. Ignoring to open any project or Solution by using the open       solution/ project option in Visual Studio.  

---

# 🧠 My Debugging Process

## Initial Observation

I observed that the Green button was not enable for me to be able to run my MAUI project.

>

---

## Initial Hypothesis

What do I **think** is causing the problem?

> I actually thaught it was Visual Studio loading problem, where Visual studio was still trying to load every feature as i just launch the app.

---

## 🔎 Investigation

What did I inspect, research, or test?

1.I check if all my files in the project was still intact.
2. Later A checked if the .csprog still has explicitly mention the startup amchine in its code.

---

## 🧪 Experiments

What did I change or test, and what happened?

| Test / Change                         | Result                |
| ------------------------------------- | --------------------- |
|I trid to mention the MAUIapp inside   |No result was gotten
 the item framework group as a package  |
|I also opening a new project to check  |the Green button appeared
If the green button appears|        |   |
|Then I tried opening the Solution again,|It worked now Visual
Now i opened it as a solution/ project  |Studio recognized it as a
                                        |Sln not just a
                                        |folder.
                                        |        

---

## 🔄 Hypothesis Update

Did my original theory change?

My original theory was a failure, it was not a Visual studio launch problem. 

---

## 🎯 Root Cause

What was actually causing the problem?

I opened my project and solution as a foldernthat's why Visual studio could not recognize my solution as a Solution. Just as a folder and file

---

## 🔧 Solution

What fixed the problem?

> Closing the app and opening the Solution as a Solution in Visual Studio.

---

## ✅ Verification

How did I confirm that the solution actually worked?

* [ ] Reproduced the original problem
* [ ] Applied the solution
* [ ] Tested again
* [*] Confirmed expected behavior
* [ ] Tested related functionality
* [ ] Tested edge cases

**Verification notes:**

>

---

# 📚 What This Bug Taught Me

What concept or principle did I learn from this problem?

> Always open your work a swhat it is in your IDE not just as what it may look like to be.

---

## 🔁 How Can I Recognize This Bug Next Time?

What symptoms should I look for?

>

---

## 🛡️ How Can I Prevent It?

What can I do differently in future projects?

>TO always open the SOlution and Project as Sln and project.

---

# 🧠 BY MY SELF — Debugging Check

### Did I try to solve it myself first?

* [*] Yes
* [ ] No

### Did I form my own hypothesis?

* [*] Yes
* [ ] No

### Did I test my hypothesis?

* [*] Yes
* [ ] No

### Did I understand the root cause?

* [ ] No
* [ ] Partially
* [*] Yes

### Could I solve a similar problem again without looking at this entry?

* [ ] No
* [ ] With hints
* [*] Yes

---

## 🤖 AI Assistance

**Did I use AI?**

* [*] No
* [ ] Yes

**What did I ask?**

>

**What did AI suggest?**

>

**What did I verify myself?**

>

**What did I learn rather than simply copy?**

>

---

## 🔗 Related Documentation

**Daily Log:**
`2026-09-21`

**Technical Note:**
`[Related Note]`

**Related Bug(s):**

*

**Related Commit(s):**

*

---

## 🏁 Final Lesson

If I encounter this problem six months from now, what should I remember?

>Alway open a file as its file type.
