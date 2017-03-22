def main():
    T = int(input())
    for i in range(T):
        s = raw_input()
        N = int(s.split( ' ' )[0])
        a = int(s.split( ' ' )[1])

        if (N%2 == 0):
            Pol = [x for x in range(getMinOrMaxValue(bool(1),N),getMinOrMaxValue(bool(0),N)) if AlternativeElementsAreEqual(str(x))]
        else:
            Pol = [x for x in range(getMinOrMaxValue(bool(1),N),getMinOrMaxValue(bool(0),N)) if str(x)[0] == str(x)[N-1] and str(x)[1] == str(x)[N-2] and str(x)[0] != str(x)[1]]
        Pol
        try:
            print Pol[a-1]
        except:
            print -1
def AlternativeElementsAreEqual(x):
    bValue = False
    for i in range(len(x)):
        if x[i] != x[i+1] and x[i] == x[i+2]:
            bValue = True

    return bValue
        
def getMinOrMaxValue(isMin,digit):
    s = ""
    if isMin:
       s = "1"
       for i in range(digit-1):
           s+="0"
    else:
        for i in range(digit):
            s+="9"

    return int(s)
if __name__ == "__main__":

    main()
