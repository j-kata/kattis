# Darts Scoring

You need to find all the ways the dart game can be finished in at most three throws.

Points:

`Bullseye` - 50 points  
`Outer bullseye` - 25 points  
`Single [i]` - [1..20] depending on the slice `i`  
`Double [i]` - [1..20] \* 2 depending on the slice `i`  
`Triple [i]` - [1..20] \* 3 depending on the slice `i`  

## Input

`x` - the number of points needed to finish the game (positive integer, `x <= 501`).

## Output

First print `n` - number of ways to finish the game on the first line.

Then, for each of `n` ways you should first print `k` - number of throws, followed by `k`- lines, each one of them giving the name of throw. The order of the throws does matter.

## Example

Sample Input

```
3
```

Sample Output

```
7
1
Single 3
1
Triple 1
2
Single 1
Single 2
2
Single 1
Double 1
2
Single 2
Single 1
2
Double 1
Single 1
3
Single 1
Single 1
Single 1

```
