# Keywords

Catherine considers two keywords _k1_ and _k2_ to be similar if, after replacing hyphens with spaces and ignoring capitalization, _k1_ is the same as _k2_.

Find the number of unique words in the list.

## Input

**First line**: _n_ (1 <= _n_ <= 40 000), where _n_ is the number of keywords int the list.

**n lines**: each line contains a keyword _K_ that is between 1 and 25 characters in length (inclusive). All characters in a keyword are guaranteed to fall in the [32, 126] ASCII range, and no keyword begins or ends with a space or a hyphen.

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
