from pickle import TRUE


edad = 20


pago = False

if not edad > 18 and edad < 21 or edad ==100:
    print("es mayor de edad")
    if pago == True:
        print("entonces eres mayor y pagaste")
    else:
        print("eres mayor de edad y no pagaste")

else:
    print("no  eres mayor de edad") 

