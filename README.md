# HuntingTheManticoreMiniGame

A little fun mini game to practice/reinforce using methods within C#.

The aim of this game is to destroy the Manticore sjip before it reaches the city. Player One will enter a distance between 0 and 100.
Player two will then guess when inputting the range of the cannon, after every guess the round increases and the city takes 1 damage if manticore still alive.

## Requirments ##
* Player 1 inputs a number between 0 and 100.
* Player 2 guesses distance player 1 inputted.
* Display what damage the cannon will do this round.
* If the round is a multiple of 3 or 5 the cannon will do 3 damage
* If the round is a multiple of 3 & 5 then do 10 damage 
* If normal round cannon does 1 damage.
* For every round manticore is still alive the city takes damage
* End game if city or manticore is destroyed

## Thoughts/Improvements ##

I had fun making this small project which helped me to solidfy my knowkege in using methods and using the %(remainder) operator for finding mutiples of numbers.
To improve this challenge I could use the random class in order to allow the game to be single player - the distance will be randome each time.
Also I could make it so that the ship moves between a certain distance each round (1-5) to increase the difficulty.
