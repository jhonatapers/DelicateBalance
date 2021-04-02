using System;
class BinaryTree
{
    public static Node[] makeTree(string[] nodes)
    {
        try
        {
            Node[] binaryTree = new Node[nodes.Length];

            for(int i = 0; i <= nodes.Length - 1; i++)
            {
                string[] nodeInfo = nodes[i].Split(' ');

                binaryTree[i] = new Node
                {
                    LValue = nodeInfo[1].StartsWith('X') ? -1 : Convert.ToInt32(nodeInfo[1]),
                    RValue = nodeInfo[1].StartsWith('X') ? -2 : Convert.ToInt32(nodeInfo[2])
                };
            }

            return binaryTree;
        }
        catch
        {
            throw;
        }        
    }
}