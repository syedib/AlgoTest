def main():
    N = int(input())
    S = [None]*int(N)
    S = list(map(int,raw_input().split(' ')))
    R = [None]*int(N)
    strR = ""

    for i in range(len(S)):
        SS = [x for x in S if S[i]%x == 0 ]
        if(len(SS) < 2):
            R[i] = S[i]
    print " ".join(map(str,[r for r in R if r!=None]))
    
if __name__ == "__main__":
    main()
