# Iqvia Interview Exercise

The overall goal of this exercise is to develop a simple calculator library in C#.

The exercise is divided into three stages. Each of which has an associated set of unit tests that your code should pass.

You have been provided with a *Visual Studio* solution that should form the basis for your work.  Should you prefer, you may instead use *Visual Studio Code*.

The solution has the following structure:

* `README.md` - This file.
* `Calculator.Tests` project - A set of unit tests your code should satisfy.
  * `Stage1.cs` - Unit tests for *stage 1* of this exercise.
  * `Stage2.cs` - Unit tests for *stage 2* of this exercise.
  * `Stage3.cs` - Unit tests for *stage 3* of this exercise.
* `Stage 1 - Expression` project - Develop your *stage 1* code here.
* `Stage 2 - Fluent Api` project - Develop your *stage 2* code here.
* `Stage 3 - Strategy` project - Develop your *stage 3* code here.

Throughout, pay attention to the quality of your code, and in particular to:

* *Demonstrating your knowledge of object orientation*
* *Demonstrating your knowledge of C#*
* *Self-documenting code*
* *Encapsulation*
* *Extensibility*
* *Validation*
* *Elegance*
* *Cohesion*
* *Reuse/DRY*
* *Efficiency*

# Stage 1 - Developing the Core Expression Library

Code for this section should be developed in the `Stage 1 - Expression` project.

You will develop a class library which evaluates simple integer-only arithmetic expressions:  

* Expressions may be of arbitrary complexity.
* The following arithmetic operations should be supported:
  * Addition
  * Subtraction
  * Multiplication
  * Division
  * Unary minus

You are explicitly **not** expected to parse a string representation of an arithmetic expression.  As will be apparent from inspection of the `Stage1.cs` unit tests, the goal is to develop a software library with methods to build and to evaluate arithmetic expressions.

For example, to build and evaluate the expression `2 + 3 * 4`, client code using your library would look something like:

```
var expression=new AddExpression(new LiteralExpression(2), 
    new MultiplyExpression(new LiteralExpression(3), 
        new LiteralExpression(4));
    
var result=expression.Eval();
``` 

Your code should properly support the `ToString` method, for the above example:

```
Console.WriteLine(expression);
```

Should output:

```
(2+(3*4))
```

Your code should pass all unit tests in `Stage1.cs`.

# Stage 2 - A More Fluent API

Code for this section should be developed in the `Stage 2 - Fluent Api` project.

You will build on your existing *Stage 1* code to create a more *fluent* API.  Employ extension methods and/or other C# constructs you deem appropriate.   

Once complete we should be able to build and evaluate expressions as follows.

**Example 1**

The arithmetic expression `4*(10+2)` could be coded with your new API as:

```
var result=10.Plus(2).Times(4).Eval();
```

**Example 2**

The arithmetic expression `(6*7-9+2)*2` could be coded with your new API as:

```
var result=6.Times(7).Minus(9).Plus(2).Times(2).Eval();
```

Once more expressions may be arbitrarily complex.

You should *not* modify the code developed in *Stage 1* but rather build on it.

**Note:** These expressions are built left to right.  Do not attempt to adjust for operator precedence, client code must create an expression just as they require it to be evaluated.

Your code should pass all unit tests in `Stage2.cs`.

# Stage 3 - Strategy Pattern

Code for this section should be developed in the `Stage 3 - Strategy` project.

You will further augment your code to include an expression class that implements a strategy pattern to evaluate its arguments as a component of an expression.   

Your new class must be usable in the same manner as any of the expression components developed in *Stage 1*.  It should both be usable as part of an expression composed from *Stage 1* classes, as well as taking *Stage 1* classes as arguments.

You will then use this class to implement a `modulo` operation (`%` in C#).

For example, using the basic form of the API developed in *Stage 1*, we should be able to write code evaluate `20 % 3` as:

```
var result = new BinaryExpressionStrategy(
    new LiteralExpression(20), new LiteralExpression(3),
    "%", 
    (a, b) => a % b).
    Eval();
```

Or, a slightly more complex example, which combines your new class with both *Stage 1* and *Stage 2* Apis, `(2*((7+4)%3))` could be coded as:

```
var result = 2.Times(
                new BinaryExpressionStrategy(
                    7.Plus(4), 
                    new LiteralExpression(3),
                    "%", 
                    (a, b) => a % b)).
             Eval();
```

Stringification should continue to operate properly.  In the above examples the string parameter `%` supplies the textual symbol to be used when stringifying the particular strategy.

Your code should pass all unit tests in `Stage3.cs`.

