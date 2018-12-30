def multiply_array(num1):
    l=len(num1)
    i=0
    j=1
    while i<l:
        j*=num1[i]
        i+=1
    return j
num=[10,20,30,40]
x = multiply_array(num)
print (x)