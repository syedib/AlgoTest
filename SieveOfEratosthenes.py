import time
def GenPrime(N):
    primes = [True]*N
    primes[0] = primes[1] = False
    
    for(i,isPrime) in enumerate(primes):
        if isprime:
            yield i
            for n in xrange(i*i, limit, i):
                primes[n] = False
##    print primes
##    for p in range(2,N):
##        if(primes[p] == True):
##            print p
if __name__ == "__main__":
    start_time = time.time()
    GenPrime(10000)
    print("--- %s seconds ---" % (time.time() - start_time))
    
        
