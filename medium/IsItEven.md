# Is It Even?

Check if the product `x1 * x2 * ... * xN` is divisible by `2^K` for some integer `K >= 0`.

## Input

**First line**: Two integers `N`, `K` (`1 <= N <= 1000 000` and `0 <= K <= 1000`).
**N lines**: Single integer value `x` (`1 <= x <= 10^9`)

## Output

Print `1` if `2^K` divides `x1 * x2 * ... * xN`, otherwise print `0`.

## Example

Sample Input 1

```
4 2
3
2
1
1
```

Sample Output 1

```
0
```

---

Sample Input 2

```
5 4
3
30
6
4
7
```

Sample Output 2

```
1
```
