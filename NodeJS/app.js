const count = Math.pow(10, 4)
let prime = [2]
let next = 3
while (prime.length < count) {
    let square = Math.sqrt(next)
    let isPrime = true;
    for (let i = 2; i <= square; i++) {
        if (next % i == 0) {
            isPrime = false;
            break;
        }
    }
    if (isPrime) {
        prime.push(next);
    }
    next += 2;
}
