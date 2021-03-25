using System;

namespace DelicateBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            BalanceCalculator balanceCalculator = new BalanceCalculator();

            //Console.WriteLine("Digite um caso de teste ( 0 à 13 ), e aperte enter\n\n");
            //string caso = Console.ReadLine();
            //Console.WriteLine(caso);
        
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 0 + ".txt")));
            balanceCalculator.Start();

            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 5 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 6 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 7 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 8 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 9 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 10 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 11 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 12 + ".txt")));
            balanceCalculator.Start();
            
            balanceCalculator.setTree(BinaryTree.makeTree(Reader.readData("teste" + 13 + ".txt")));
            balanceCalculator.Start();
        }
    }

}
