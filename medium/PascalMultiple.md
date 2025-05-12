# Pascal Multiple

Given `N` and `K`, compute how many entries in the first `N + 1` rows of Pascal's trinagle are multiplies of `K`.

Pascal's triangle:

1
1 1
1 2 1
1 3 3 1
1 4 6 4 1
...

`C(i,j)` is the `j`-th entry of the `i`-th row in Pascal's triangle.

`C(0, 0) = 1`

`C(i + 1, j) = C(i, j) + C(i, j - 1)`

## Input

Two positive integers `N` (`1 <= N <= 1000`) and `K` (`1 <= K <= N`).

## Output

Print the number of entries in the first `N + 1` rows of Pascal’s triangle that are divisible by 'K'.

## Example

Sample Input

```
1000 4
```

Sample Output

```
394315
```
