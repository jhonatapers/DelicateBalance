using System;
class BinaryTree
{
    Node[] binaryTree;
    
    public Node[] makeTree(string[] nodes)
    {
        try
        {
            binaryTree = new Node[nodes.Length];

            for(int i = 0; i >= nodes.Length - 1; i++)
            {
                string[] nodeInfo = nodes[i].Split(' ');

                binaryTree[i] = new Node
                {
                    Id = Convert.ToInt64(nodeInfo[0].Remove(0,1)),
                    LValue = nodeInfo[1].StartsWith('X') ? -1 : Convert.ToInt32(nodeInfo[1]),
                    RValue = nodeInfo[1].StartsWith('X') ? -1 : Convert.ToInt32(nodeInfo[2])
                };
            }

            return this.binaryTree;
        }
        catch(Exception makeTree)
        {
            Console.WriteLine(makeTree.Message);
            throw makeTree;
        }        
    }
}