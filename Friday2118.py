#wikibooks problem Python Programming/Text
#Problem 1
print(ord('a')-ord('A'))
print(ord('a'),ord('A'))

#Problem 2
character = input("Enter a chaarater:")
#realCharacter = chr(character)
print("Character is %s" % character)
#realCharacter = chr(character)
print("%s transformed to %s" % (character,chr(ord(character)-32)) )
for c in range(70,80): 
    print (chr(c))