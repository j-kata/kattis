# Kleptography

Decrypt a text, encrypted with an _autokey_ cipher, given the last `n` letters of the plaintext.

**Autokey** cipher uses a secret key `k` of `n` letters, which is prefixed to a portion of the plaintext itself to generate the full key. This extended key is then added to the plaintext to produce the ciphertext.
Encryption of the plaintext `a` to the ciphertext `b` follows the formula: `b[i] = a[i] + k[i] mod 26`, where letters are represented as numbers from `0` to `25` (`A=0, B=1,..., Z=25`).

## Input

**First line**: `n` and `m` (`1 <= n <= 30`, `n + 1 <= m <= 100`), where `n` is the length of the keyword as well as the number last known letters of the plaintext, and `m` is the length of the text.

**Second line**: `n` lower-case letters, the last `n` letters of the plaintext.

**Third line**: `m` lower-case letters, the whole cipertext.

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
