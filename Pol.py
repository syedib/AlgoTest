word = list(raw_input())
lst = {}
for i in word:
    if lst.get(i):
        lst[i] = (lst[i]+1)%2
    else:
        lst[i] = 1
print lst
sm = 0
for i in lst:
    sm = sm +lst[i]
if (len(word)%2 ==0 and sm ==0) or (len(word)%2 ==1 and sm ==1):
    print "YES"
else:
    print "NO"
