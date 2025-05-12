# A Pivotal Question

Given an array, determine all the values that could be the pivot value for quick sort assuming the array has been partitioned, or determine that the array has not been partitioned.

One of the major steps in the **quicksort** algorithm is the **partition** step: given an element `p` in the array (the _pivot_ element) rearrange the elements in the array so that all the values to the left of this element are `<= p` and all the elements to the right are `> p`.

## Input

Input is a single line, where the first number `n` (`1 <= n <= 10^6`) is the size of the array, that follows after. All values in the array are unique and `<= 10^6`.

## Output

Output is a single line, where the first number `m`is the size of the array of possible pivot elements, that follows after. All numbers should be in the order they appear in the input. If `m > 100` just output the first `100` of these pivot values. Note that a value of `0` indicates that the array is not partitioned.

## Example

Sample Input

```
10 1 11 8 13 53 20 63 99 79 94
```

Sample Output

```
3 1 13 63
```
