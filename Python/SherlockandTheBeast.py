def noOfThree(n):
    t = ''
    for i in range(n):
        t += '3'

    return t
def noOfFive(n):
    t = ''
    for i in range(n):
        t += '5'

    return t

def calc(n):
    fivelist = [ i for i in range(1,n+1) if i%5==0]
    threelist = [ i for i in range(1,n+1) if i%3==0]
    
    t = [fivelist[i] for i in range(len(fivelist)) if (n-fivelist[i])%3==0]
    f = [threelist[i] for i in range(len(threelist)) if (n-threelist[i])%5==0]

    ##print(t,f)
    
    if t != [] and f == [] :
        print(int(noOfThree(t[0])))
    elif f != [] and t == [] :
        print(int(noOfFive(f[0])))
    elif f != [] and t != [] and f[0] + t[0] == n:
        print(int(noOfFive(f[0])+noOfThree(t[0])))
    else:
        print(-1)

def main():
    N = int(raw_input())
    for i in range(N):
        inp = int(raw_input())
        calc(inp)
if __name__ == "__main__":
    main()
