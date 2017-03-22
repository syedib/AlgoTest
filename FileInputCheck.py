def Check():
    S=raw_input()
    n=len(S)
    i=0
    j=n-1
    res=0
    while(i<j):
        while((i<j) and (S[i]!='R')):
            i+=1
        while((j>i) and (S[j]!='K')):
            j-=1

        if(i<j):
            res+=2

        i+=1
        j-=1
    print res
def main():
    T = int(input())
    for i in range(T):
        Check()
if __name__ == '__main__':
    main()
