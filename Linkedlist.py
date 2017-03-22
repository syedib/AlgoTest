class Node():
    def __init__(self):
        self.data = None
        self.next = None
class linkedlist():

    def __init__(self):
        self.currentnode = None

    def add(self,item):
        newnode = Node()
        newnode.data = item
        newnode.next = self.currentnode
        self.currentnode = newnode

    def getItemsFromList(self):
        node = self.currentnode

       ## print(node.data)
        while node:
            print(node.data)
            node = node.next
      
            

def main():
    li=linkedlist()
    li.add(1)
    li.add(2)
    li.getItemsFromList()

if __name__=="__main__":
        main()  
