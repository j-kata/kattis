# Damaged Equation

Given an equation of the form `a ? b = c ? d`, where _a_, _b_, _c_, and _d_ are integers and each **?** represents a missing operator, find all possible combinations of the operators +, -, \*, and / that make the equation valid (i.e., both sides evaluate to the same result).

## Input

Four integers _a_, _b_, _c_, and _d_ on a single line.

## Output

Print out all the expressions that evaluate to true, separated by a newline and sorted alphanumerically ( '\*' < '+' < '-' < '/').

A valid expression must have a space between the integers, operators and the equal sign. Note that expression including division by zero is not a valid expression.

If none of the expressions are valid, print out “problems ahead” (without the quotes).

## Example

Sample Input 1

```
0 4 2 2
```

Sample Output 1

```
0 * 4 = 2 - 2
0 + 4 = 2 * 2
0 + 4 = 2 + 2
0 / 4 = 2 - 2
```

---

Sample Input 2

```
4 5 9 8
```

Sample Output 2

```
problems ahead
```
