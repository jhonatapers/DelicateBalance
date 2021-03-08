using System;

namespace DelicateBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            BalanceCalculator balanceCalculator = new BalanceCalculator();

            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste13.txt")));
            balanceCalculator.Start();
        }
    }

}
