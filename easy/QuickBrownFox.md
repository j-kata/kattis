# Quick Brown Fox

Check if the given text is a _pangram_.

A **pangram** is a phrase that includes at least one occurrence of each of the letters, `a`...`z`.

Example: _The quick brown fox jumps over the lazy dog_.

## Input

**First line**: `N` - number or lines, where `1 <= N <= 50`.

**N lines**: Each line (`1 - 100` character) is a single phrase that may contain upper and lower case letters, spaces, decimal digits and punctuation characters `.`, `,`, `?`, `!`, `’` and `"`.

## Output

For each pharse print `pangram` if it is a pangram.
Otherwise, print `missing` followed by space and list of letters, that didn't occur in the phrase.

## Example

Sample Input

```
3
The quick brown fox jumps over the lazy dog.
ZYXW, vu TSR Ponm lkj ihgfd CBA.
.,?!'" 92384 abcde FGHIJ
```

Sample Output

```
pangram
missing eq
missing klmnopqrstuvwxyz
```
