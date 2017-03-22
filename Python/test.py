def main():
    S = raw_input().split(' ')
    N = int(S[0]) ##bananas
    K = int(S[1]) ##Lemurs

    r = 1000000

    for i in range(1,K*2):
        res = min( r, abs(K - i) + min(N % i , i - N % i) )

    print r

    
if __name__ == "__main__":
    main()
