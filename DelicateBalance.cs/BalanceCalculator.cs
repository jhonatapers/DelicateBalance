using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System;
class BalanceCalculator
{
    Node[] tree;

    int balancedCount;

    private double op;
    private int chamadas;
    private double n;

    string balancedIDs;

    public void setTree(Node[] tree)
    {
        this.tree = tree;
        this.balancedCount = 0;
        this.balancedIDs = "";
    }

    public void Start()
    {
        this.op = -1;
        chamadas = -1;
        n = tree.Length-1;

        calculateBalanced3(0);

        Console.WriteLine("N: " + n);
        Console.WriteLine("Operações: " + op + "   Op/N: " + op/n);
        
        Console.WriteLine("Em equilibrio: " +balancedCount);
        Console.WriteLine("Computadores: " + balancedIDs);
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
            //TENTAR RETORNAR O VALOR AQUI
            calculateBalanced(id * 2 + 1);
        }

        if(tree[id].RValue == -2) 
        { 
            //TENTAR RETORNAR O VALOR AQUI
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

    public Int64 calculateBalanced2(Int64 id)
    {          
        if(tree[id].LValue == -1) 
        { 
            tree[id].LValue = calculateBalanced2(id * 2 + 1);
        }

        if(tree[id].RValue == -2) 
        { 
            tree[id].RValue = calculateBalanced2(id * 2 + 2); 
        }
        else
        {
            if (tree[id].LValue == tree[id].RValue) 
            {                 
                balancedCount++; 
                balancedIDs = balancedIDs + ";X" + id;                 
            }            
        }  

        if(id == 0)
        {
            if (tree[id].LValue == tree[id].RValue) 
            {                 
                balancedCount++; 
                balancedIDs = balancedIDs + ";X" + id;                 
            }   
        }            

        return tree[id].LValue + tree[id].RValue;

    }

    public Int64 calculateBalanced3(Int64 id)
    { 
        this.chamadas++;
        //this.op++;
        if(tree[id].LValue == -1) 
        { 
            op++;
            tree[id].LValue = calculateBalanced3(id * 2 + 1);
        }

        //this.op++;
        if(tree[id].RValue == -2) 
        { 
            this.op++;
            tree[id].RValue = calculateBalanced3(id * 2 + 2); 
        }

        //this.op++;
        if (tree[id].LValue == tree[id].RValue) 
        {              
            balancedCount++; 
            balancedIDs = balancedIDs + ";X" + id;                              
        }

        //this.op++;
        return tree[id].LValue + tree[id].RValue;
    }

}
