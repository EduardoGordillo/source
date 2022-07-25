a = 3
b = 8
c = 6

d = a > b
e = b < c
f = (c + 3) > a

op1 = d and e
op2 = f and e
op3 = (d or f) and (not e or f)

print(d)
print(op1)
print(op2)
print(op3)