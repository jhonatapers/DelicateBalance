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
        if(this.tree is null)
            calculateBalanced(0);
    }

    public void calculateBalanced(Int64 id)
    {
        if(tree[id].LValue == -1) { calculateBalanced(id * 2 + 1); }

        if(tree[id].RValue == -1) { calculateBalanced(id * 2 + 2); }
        else
        {
            if (tree[id].LValue == tree[id].RValue) { balancedCount++; balancedIDs = balancedIDs + ";X" + tree[id]; }
            
                if (id % 2 == 0 && tree[id].Id !=0) //par
                {
                    tree[tree[id].Id/2 -1].RValue = tree[id].LValue + tree[id].RValue;
                    calculateBalanced(tree[id].Id/2 - 1);
                }
                else if(tree[id].Id !=0) //impar
                {
                    tree[tree[id].Id/2].LValue = tree[id].LValue + tree[id].RValue;
                    calculateBalanced(tree[id].Id/2);
                }
        }   
    }

}
