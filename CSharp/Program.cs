List<int> primes = new List<int>();
primes.Add(2);
int nextPrime = 3;
while (primes.Count < Math.Pow(10, 4))
{
    int sqrt = (int)Math.Sqrt(nextPrime);
    bool isPrime = true;
    for (int i = 0; primes[i] <= sqrt; i++)
    {
        if (nextPrime % primes[i] == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        primes.Add(nextPrime);
    }
    nextPrime += 2;
}
