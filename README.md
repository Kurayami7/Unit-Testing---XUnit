# Unit Testing - ASP.NET

## What is xUnit
xUnit.Net is an open-source testing framework based on the .NET framework. ‘x’ stands for the programming language, e.g., JUnit, NUnit, etc. The creators of NUnit created xUnit as they wanted to build a better framework rather than adding incremental features to the NUnit framework.

xUnit is created with more focus on the community; hence it is easy to expand upon. You can download xUnit from NuGet gallery. So far, there are close to 7,500 questions tagged as xUnit on Stackoverflow.

Below are some of the core reasons why the creators of NUnit decided to reconsider the framework and built xUnit.Net.

As of writing this article, the latest version of xUnit was 2.4.1. The framework follows a unique style of testing, and tags like [Test] & [TestFixture], a part of the NUnit framework, are no longer used in the xUnit framework.

## Some information
The popular attributes [SetUp] and [TearDown] are also not a part of the xUnit framework. As per the creators of NUnit (and xUnit), usage of [SetUp] and [TearDown] led to code duplication, and they wanted to implement the same features in a much more optimized manner in xUnit. For initialization, constructor of the test class is used, whereas, for de-initialization, IDisposable interface is used. This also encourages writing much cleaner tests. This makes this C# unit testing framework a much better option when it comes to Selenium automation testing as it is more robust and extensible.

## xUnit vs Competition
As far as NUnit vs. XUnit vs. MSTest is concerned, the biggest difference between xUnit and the other two test frameworks (NUnit and MSTest) is that xUnit is much more extensible when compared to NUnit and MSTest. The [Fact] attribute is used instead of the [Test] attribute. Non-parameterized tests are implemented under the [Fact] attribute, whereas the [Theory] attribute is used if you plan to use parameterized tests.

In NUnit and MSTest, the class that contains the tests is under the [TestClass] attribute. This was not a very robust approach hence [TestClass] attribute was also removed in xUnit. Instead, intelligence is built in the xUnit framework so that it can locate the test methods, irrespective of the location of the tests.

## Video Demo:
https://github.com/Kurayami7/Unit-Testing---XUnit/assets/124408792/580aa419-378d-4ac8-b475-4cf40a453a12


## Some Useful Information:
Shown below are the most popular attributes/annotations used in the xUnit framework:

### ANNOTATION
### DESCRIPTION
```
[Fact]	Marks a test method, i.e., actual test in a class 
Assert.Throws Record Exception	Verify the raise and raise assert, irrespective of the place in the code where the problem occurs. 
Constructor	This is not an attribute but is an ideal replacement for the [SetUp] attribute. The constructor should be parameter-less. 
IDisposable.Dispose	This is not an attribute but is an ideal replacement for the [TearDown] attribute. This is where the code for performing necessary cleanup and de-initialization is included. 
The decision to do away with [TearDown] was made as the investors of xUnit felt that a lot of unnecessary code was run before every single test execution. 

[Trait]	Used to set arbitrary meta-data on a test 
[Theory]	This attribute is used when data-driven tests have to be executed. In such cases, [Theory] has to be used instead of [Fact] attribute 
[InlineData]	This attribute is used along with the [Theory] attribute to supply a subset of data against which parameterized tests will be executed. 
[ClassData]	This attribute is used when the parameters being passed to the [Theory] tests are not constants. 
[Theory] [ClassData(typeof(some-data))] 
[MemberData]	This attribute can be used to fetch data for [Theory] from a static method. The most common approach is to load the data from the property of a test class, i.e., using IEnumerable&lt: object[] > 
```

## Quick Revision/Introduction to Testing:
There are ﻿4 main types of testing in Software Development:
 
### 1. Unit Testing: Testing the smallest testable section of code (methods). Developers 
test them on their own.
 
### ﻿2. Integration Testing: This is where testers/QA/QC comes in. They test multiple 
functionalities as a whole when they come together.
﻿
### 3. System Testing: This is where testers/QA/QC test the entire system from start to end.
﻿
### 4. User Acceptance Testing: There are 2 parts to this type of testing. It always
relies on the end-user to test functionality. 
a. The first type is alpha testing, the second is beta testing. Alpha is when testers 
are controlled and selected. 
b. Beta is when it's open to public testing.

## Useful links to get started:
https://xunit.net/docs/getting-started/netfx/visual-studio
<br>
https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/
