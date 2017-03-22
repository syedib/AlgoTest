import math
def sqrt(n):
    h=float(n+1)
    l=0.0
    while abs(h-l)>0.000001:
        m=(h+l)/2
        if m*m<=n:
            l=m
        else:
            h=m

    return l
if __name__=="__main__":
    for i in range(3,9+1):
        print(math.ceil(sqrt(i)))
