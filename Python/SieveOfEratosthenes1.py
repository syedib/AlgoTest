import time
def eratosthenes2(n):
    multiples = set()
    for i in range(2, n+1):
        if i not in multiples:
            yield i
            multiples.update(range(i*i, n+1, i))
if __name__ == "__main__":
     start_time = time.time()
     print(list(eratosthenes2(10)))
     print("--- %s seconds ---" % (time.time() - start_time))
##     for i in range(len(p)):
##         print p[i]
    
     
