from random import randint, random

def main():
    random = randint(0,10)
    guess = int(input("What would you like your guess to be? : "))
    happy = input("Happy")
    if happy == 'Happy':
        print(True)
    while(guess != random):
        guess = int(input("Wrong guess try again! : "))
        if (guess == random):
            print("Congrats you guess right!")
            break
main()