# Keywords

Find the number of unique words in the list.

Two keywords `k1` and `k2` are considered to be similar if, after replacing hyphens with spaces and ignoring capitalization, `k1` is the same as `k2`.

## Input

**First line**: `n` (`1 <= n <= 40 000`), where `n` is the number of keywords int the list.

**n lines**: Each line contains a keyword `K` that is between `1` and `25` characters in length (inclusive). All characters in a keyword are guaranteed to fall in the `[32, 126]` ASCII range, and no keyword begins or ends with a space or a hyphen.

## Output

Output a single line containing the number of (pairwise) non-similar keywords in the data bank.

## Example

Sample Input

```
4
c++
C++
c
c#
```

Sample Output

```
3
```
