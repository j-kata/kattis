# Kleptography

John encrypted a letter with an _autokey_ cipher, but Mary saw the end of his original text.

**Autokey** cipher uses a secret key _k_ of _n_ letters, which is prefixed to a portion of the plaintext itself to generate the full key. This extended key is then added to the plaintext to produce the ciphertext.
Encryption of the plaintext _a_ to the ciphertext _b_ follows the formula: `b[i] = a[i] + k[i] mod 26`, where letters are represented as numbers from 0 to 25 (A=0, B=1,..., Z=25).

## Input

**First line**: _n_ and _m_ (1 <= _n_ <= 30, _n + 1_ <= _m_ <= 100), where _n_ is the length of the keyword as well as the number of letters Mary saw, and _m_ is the length of the text.

**Second line**: _n_ lower-case letters, the last _n_ letters of the plaintext.

**Third line**: _m_ lower-case letters, the whole cipertext.

## Output

Print the original text.

## Example

Sample Input

```
5 16
again
pirpumsemoystoal
```

Sample Output

```
marywasnosyagain
```
