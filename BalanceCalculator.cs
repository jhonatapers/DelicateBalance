using System;
class BalanceCalculator
{
    Node[] tree;

    int balancedCount;

    string balancedIDs;

    public void setTree(Node[] tree)
    {
        this.tree = tree;
        this.balancedCount = 0;
        this.balancedIDs = "";
    }

    public void Start()
    {
        calculateBalanced(0);

        Console.WriteLine("Em equilibrio: " +balancedCount + "\nComputadores: " + balancedIDs);
    }

    public void calculateBalanced(Int64 id)
    {        
        //GAMBIARRA
        if(balancedIDs.Contains(";X" + id))
        {
            return;
        }
        
        if (tree[id].LValue == tree[id].RValue) 
        {                 
            balancedCount++; 
            balancedIDs = balancedIDs + ";X" + id;                 
        }

            
        if(tree[id].LValue == -1) 
        { 
            calculateBalanced(id * 2 + 1);
        }

        if(tree[id].RValue == -2) 
        { 
            calculateBalanced(id * 2 + 2); 
        }
        else
        {

            if(id !=0)
            {
                if (id % 2 == 0) //par
                {
                    tree[id/2 -1].RValue = tree[id].LValue + tree[id].RValue;
                    calculateBalanced(id/2 - 1);
                }
                else //impar
                {
                    tree[id/2].LValue = tree[id].LValue + tree[id].RValue;
                    calculateBalanced(id/2);
                }
            }
        }   
    }

}
