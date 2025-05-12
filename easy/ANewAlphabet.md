# A New Alphabet

Write the text with a new alphabet.

The new alphabet is a one-to-many translation (one character of the English alphabet translates to anywhere between 1 and 6 other characters), with each character translation as follows:

| a -> @      | b -> 8     | c -> (      |
| ----------- | ---------- | ----------- |
| d -> \|)    | e -> 3     | f -> #      |
| g -> 6      | h -> [-]   | i -> \|     |
| j -> \_\|   | k -> \|<   | l -> 1      |
| m -> []\/[] | n-> []\\[] | o -> 0      |
| p -> \|D    | q-> (,)    | r -> \|Z    |
| s -> $      | t -> ']['  | u -> \|\_\| |
| v -> \/     | w -> \/\/  | x -> }{     |
| y -> `/     | z -> 2     |

Example: Hellow World! -> [-]3110 \/\/0|Z1|)!

## Input

Text that may contain any characters in the ASCII range `32 - 126` (`space` through `tilde`), as well as `9` (tab). Only characters listed in the table (`A–Z, a–z`) should be translated; any non-alphabet characters should be printed (and not modified). Input has at most `10 000` characters.

## Output

Output the input text with each letter (lowercase and uppercase) translated into its New Alphabet counterpart.

## Example

Sample Input

```
What's the Frequency, Kenneth?
```

Sample Output

```
\/\/[-]@'][''$ ']['[-]3 #|Z3(,)|_|3[]\[](`/, |<3[]\[][]\[]3']['[-]?
```
