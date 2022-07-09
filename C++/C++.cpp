#include <iostream>
#include <cmath>
int main()
{
	int count = pow(10, 4);
	int primes = 1;
	int next = 3;
	while (primes < count) {
		float square = sqrt(next);
		bool isPrime = true;
		for (int i = 2; i <= square; i++) {
			if (next % i == 0) {
				isPrime = false;
				break;
			}
		}
		if (isPrime) {
			primes++;
		}
		next += 2;
	}
}
