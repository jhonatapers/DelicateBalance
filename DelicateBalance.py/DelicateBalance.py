
tree = []
balancedCount = 0
balancedComputers = ''

op = 0

//teste
//teste2

def makeTree(fileName):
    global tree

    for computerInfo in open(fileName).read().split("\n"):
        try:
            computer = [ computerInfo.split(' ')[0], computerInfo.split(' ')[1], computerInfo.split(' ')[2] ]
            tree.append(computer)
        except:
            return

def calculateBalance(id):
    global tree, balancedCount, balancedComputers, op

    op += 1
    if tree[id][1][0] == 'X':
        op += 1
        tree[id][1] = calculateBalance(id * 2 + 1)
        
    op += 1
    if tree[id][2][0] == 'X':
        op += 1
        tree[id][2] = calculateBalance(id * 2 + 2)

    #op += 1
    op += 3
    if tree[id][1] == tree[id][2]:
        #op += 2
        balancedCount += 1
        balancedComputers += tree[id][0] + ','
    
    op += 2
    return int(tree[id][1]) + int(tree[id][2])


analise = open('analise.csv','w')
result = open('result.txt', 'w')

for fileNumber in range(4, 14, 1):

    tree = []
    balancedCount = 0 
    balancedComputers = "" 
    op = 0

    makeTree("teste" + str(fileNumber) +".txt")
    calculateBalance(0)
    analise.write(str(len(tree)-1) + ";" + str(op) + "\n")
    result.write("teste"+ str(fileNumber) + ".txt\n" + "Balanceados: " + str(balancedCount) + "\nComputadores: " + balancedComputers + "\n\n")

analise.close()
result.close()