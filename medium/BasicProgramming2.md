# Basic Programming 2

You are given an array `A` of size `N` and a command `t`. Based on the value of `t`, you perform an action on `A` according to the table:

| `t` | Action Needed                                                                                                                     |
| --- | --------------------------------------------------------------------------------------------------------------------------------- |
| 1   | Print "Yes" if there are two integers `x` and `y` in `A`, such that `x != y` and `x + y = 7777`. Print "No" otherwise.            |
| 2   | Print "Unique" if all integers in `A` are different. Print "Contains duplicates" otherwise.                                       |
| 3   | Find and print the integer that appears `N/2` times in `A`. Print `-1` if such integer cannot be found.                           |
| 4   | Find and print the median integer of `A` if `N` is odd; or print both median integers of `A`, separated by space, if `N` is even. |
| 5   | Print integers in `A` that fall between a range `[100...999]` in sorted order.                                                    |

## Input

**First line**: Integers `N` and `t` (`3 <= N <= 200000; 1 <= t <= 5`).

**Second line**: `N` non-negative 32-bit single integers.

## Output

For each test case, output the required answer based on the value of `t`.

## Example

Sample Input 1

```
7 1
1 7770 3 4 5 6 7
```

Sample Output 1

```
Yes
```

---

Sample Input 2

```
7 2
1 2 3 4 5 6 7
```

Sample Output 2

```
Unique

```

---

Sample Input 3

```
7 3
1 1 1 1 2 2 2
```

Sample Output 3

```
1
```

---

Sample Input 4

```
8 4
8 1 4 3 6 7 5 2
```

Sample Output 4

```
4 5
```

---

Sample Input 5

```
7 5
210 999 1000 543 321 99 777
```

Sample Output 5

```
210 321 543 777 999
```
