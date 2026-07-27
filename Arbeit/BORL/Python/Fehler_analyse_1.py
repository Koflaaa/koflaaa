print("Hello world!")

msg = "Hello, hello, world!"
print(msg)

name = "Max"
nachname = "Mustermann"

fullname = name+' '+nachname
print(fullname)


name = input("Name eingeben\n")#python 3 only input, raw_input for python2
nachname = input ("Nachname eingeben\n")
fullname = name+' '+nachname
print(fullname)

age = int(input("Alter eingeben\n"))
print(age)
print(str(age))

print(str(fullname) + ' ist ' +str(age)+ ' alt!')   #Fehler war das string nicht in int konvertiert werden kann. age muss man nach string konvertieren um den Fehler zu beheben
