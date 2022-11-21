print('+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')
print('=+=+=+=+=+=+=+=+=+=+! EDUARDO HIPOLITO ANACLETO !=+=+=+=+=+=+=+=+=+=+')
print('+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++')

print('Select your language/ Selecione o idioma : ')
print(' English (E) or Portugues (P) ')
lang = input(' ')
if (lang.upper() == 'E') :
    print("So... you're not from Brazil(probably)... WELCOME!")
    print('Where are you from?')
    country = input()
    print( country + "  ? Cool, what's your name?")
    name = input()
    print ("Nice to meet you " + name + ", I'm Eduardo, welcome to my page, sorry there's not to much to see here for now, but maybe this page will grow soon.")
    bol1 = input("Do you want to know a few things about me? (Y/N) ")
    if (bol1.upper() == 'Y'):
        print("Well, i'm from brazil, born on 1994 in Iguazu Falls, have you ever heard of it? Look it up! if you google it you will see a Wonder of Nature, pretty cool")
        print("I also like coding, travelling, gaming and some other stuff too, but i guess everyone likes travelling and gaming, kinda standard nowadays right?")
        print("...")
        print("I don't know what to say anymore... huhhhh")
        print("Let's do some random stuff i guess")
    randnum = input("Alrighty then, wanna do some random calculating just to test some code? Alright, tell me a number, any number : ")
    if not isinstance(randnum,int) or not isinstance(randnum,float) :
        randnum = input ("Sorry, i guess you missunderstood, i asked you to input a number, try again : ")
        if not isinstance(randnum,int) or not isinstance(randnum,float) :
            print("Messing with me are you? Alright, two can play this game you know ")
            randnum = input("I'm waiting you to input a number, and i'm going to keep asking you until you input one : ")
            while not isinstance(randnum,int) or not isinstance(randnum,float) :
                randnum = input ("Try again, i can do this all day: ") 
    print("OKAY, LET'S DO SOME QUICK MATH !!!")
            



        

