def getValue(L):
    n = 1
    for i in range(len(L)):
       if i+1> len(L):
           return n
       if L[i] != L[i+1]:
           n=n+1
    return n
        
def funString():
    T = int(input())
    for i in range(T):
        L = list(str(raw_input()))
        print (getValue(L))
        
if __name__ == "__main__":
    funString()

