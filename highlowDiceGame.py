#This program is a game in which a player bets money and then attempts to guess if the dice roll is a value higher than seven, lower than seven, or seven exactly
b = float(100) #balance
c = "Y" #condition on if the program loops or not
bet = "" #betting option selected
ab = "" #amount bet
hs = 100 #high score
low = [2 , 3 , 4 , 5 , 6] #list of numbers that are considered low dice rolls
high = [8 , 9 , 10 , 11 , 12] #list of numbers that are considered high dice rolls
import random #built in module or command that can randomly select a number within the parameters specified by the programmer
roll = "" #will be used to store the roll from the random module
while c == "Y":
    roll = random.randint(2 , 12) #"rolls" a random integer ranging from 2-12
    print("Your balance is:" , "${:.2f}".format(b)) #prints the variable balance with monetary formating
    print("The payout ratios are:" , "\n High (1:1)" , "\t Low (1:1)" , "\t Seven (1:4)")
    ab = float(input("How much would you like to bet? ")) #receives the amount of the balance the player would like to bet
    if b < ab:
        print("Invalid amount.") #prints "invalid amount" if the player inputs a value higher than the balance
    else:
        b = b - ab #subtracts the amount bet from the balance
        bet = input('Would you like to bet high (8-12), low (2-6) or seven(7). (Enter "H" ,"L" or "S".) ')
        bet = bet[0]
        bet = bet.upper() #these two lines ensure that the player's answer is correctly received in case they answer with a full word or incorrect capitalization
        if bet == "H":
            if roll in high:
                ab = ab * 2
                b = b + ab
                print("Successful roll!")
            else:
                print("Unsuccessful roll!")
        elif bet == "L":
            if roll in low:
                ab = ab * 2
                b = b + ab
                print("Successful roll!")
            else:
                print("Unsuccessful roll!")
        else:
            if roll == 7:
                print("Successful roll!")
                ab = ab * 5
                b = b + ab
            else:
                print("Unsuccessful roll!")#the previous if statements check to see if what the user inputs matches the roll, and distribute the "money" accordingly
    print("The roll was:" , roll)
    print("Your balance is:" , b)
    if b > hs:
        hs = b #if the balance is higher than the high score of the current play session, the balance then becomes the high score
    elif b <=0: #checks to see if the balance is 0 or less, and terminates the game if that is the case
        break
    c = input("Would you like to go again?(Y/N)") #allows the user to continue or stop playing
    c = c.upper()
    c = c[0]#these two lines ensure that a player's answer of "yes" or "y" will not be misinterpreted

print("Game over! \n Your highest balance was:" , "${:.2f}".format(hs)) #prints the high score in monetary form
