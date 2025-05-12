# Guess the Number

You need to guess a number between `1` and `1000`. After each guess, you will receive a response, whether the guess is too low, too high or correct. You have only 10 guesses.

## Interaction

The program should output guesses for the correct number, in the form of an integer between `1` and `1000` on a line on its own. After making each guess, you need to make sure to flush standard out.

After each guess, there will be a response to be read from standard in:

`lower` if the number is lower than the guess

`higher` if the number is higher than the guess

`correct` if the guess is correct

After having guessed the right answer the program should exit.
