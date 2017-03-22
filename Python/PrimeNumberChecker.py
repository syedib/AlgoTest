import math
import time
def GenPrime():
    N = list(map(int,raw_input().split(' ')))
    start_time = time.time()
    ##R = [x for x in range(N[0],N[1]+1) if x!=1 and isPrime(x)]
    for i in range(N[0],N[1]+1):
        if(i!=1 and isPrime(i)):
            print i

    print("--- %s seconds ---" % (time.time() - start_time))
def isPrime(n):
    if n % 2 == 0 and n > 2: 
        return False
    for i in range(3, int(math.sqrt(n)) + 1, 2):
        if n % i == 0:
            return False
    return True
def main():
    T = int(input())
    for i in range(T):
        GenPrime()
if __name__ == "__main__":
    main()     
