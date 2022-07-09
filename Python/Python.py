import math

count = math.pow(10, 4)
prime = [2]
next = 3

while len(prime) < count:
    root = math.sqrt(next)
    isPrime = True
    for i in range(2, int(root) + 1):
        if next % i == 0:
            isPrime = False
            break
    if isPrime:
        prime.append(next)
    next += 2
