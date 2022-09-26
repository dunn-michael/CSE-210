
using System;
using System.Collections.Generic;
namespace Test
{
    public class Program
    {
        public static List<string> boardNumbers()
            {
            string one = "1";
            string two = "2";
            string three = "3";
            string four = "4";
            string five = "5";
            string six = "6";
            string seven = "7";
            string eight = "8";
            string nine = "9";
            List<string> numbers = new List<string>();
            numbers.Add(one);
            numbers.Add(two);
            numbers.Add(three);
            numbers.Add(four);
            numbers.Add(five);
            numbers.Add(six);
            numbers.Add(seven);
            numbers.Add(eight);
            numbers.Add(nine);
            return numbers;
            }

        public static void printBoard(List<string> board)
        {
            List<string> numbers = Program.boardNumbers();
            if (board != Program.boardNumbers())
            {
                numbers = board;
            }
            Console.WriteLine($"{numbers[0]} | {numbers[1]} | {numbers[2]}\n----------\n{numbers[3]} | {numbers[4]} | {numbers[5]}\n-----------\n{numbers[6]} | {numbers[7]} | {numbers[8]}");
        }

        
        public static List<string> makeMove(List<string> numbers, int i)
        {
            int numb = 0;
            Program.printBoard(numbers);
            Console.Write("Player x's move (1-9) : ");
            string move = Console.ReadLine();
            numb = int.Parse(move);
            numb -= 1;
            numbers[numb] = "x";
            Program.determineWinner(numbers);
            if (Program.determineWinner(numbers) == "x")
            {
                return numbers;
            }
            else
            {
                Program.printBoard(numbers);
                Console.Write("Player o's move (1-9) : ");
                string move1 = Console.ReadLine();
                numb = int.Parse(move1);
                numb -= 1;
                numbers[numb] = "o";   
                Program.determineWinner(numbers);         
                return numbers;
            }
        }
        public static string determineWinner(List<string> numbers)
        {
            string winner = null;
            if (numbers[0] == "x" && numbers[1] == "x" && numbers[2] == "x" || numbers[3] == "x" && numbers[4] == "x" && numbers[5] == "x" || numbers[6] == "x" && numbers[7] == "x" && numbers[8] == "x" || numbers[0] == "x" && numbers[3] == "x" && numbers[6] == "x" || numbers[1] == "x" && numbers[4] == "x" && numbers[7] == "x" || numbers[2] == "x" && numbers[5] == "x" && numbers[8] == "x" || numbers[0] == "x" && numbers[4] == "x" && numbers[8] == "x" || numbers[2] == "x" && numbers[4] == "x" && numbers[6] == "x")
            {
                winner = "x";
            }
            else if (numbers[0] == "o" && numbers[1] == "o" && numbers[2] == "o" || numbers[3] == "o" && numbers[4] == "o" && numbers[5] == "o" || numbers[6] == "o" && numbers[7] == "o" && numbers[8] == "o" || numbers[0] == "o" && numbers[3] == "o" && numbers[6] == "o" || numbers[1] == "o" && numbers[4] == "o" && numbers[7] == "o" || numbers[2] == "o" && numbers[5] == "o" && numbers[8] == "o" || numbers[0] == "o" && numbers[4] == "o" && numbers[8] == "o" || numbers[2] == "o" && numbers[4] == "o" && numbers[6] == "o")
            {
                winner = "o";
            }
            else
                winner = "draw";
            return winner;
        }
        
        public static void Main(string[] args)
        {
            string draw = "";
            List<string> numbers = Program.boardNumbers();
            bool gameOver = false;
            while (!gameOver)
            {
                for(int i = 0; i < 9; i ++)
                {
                    string winner = Program.determineWinner(numbers);
                    if(i != 4)
                    {
                    Program.makeMove(numbers, i);
                    Program.determineWinner(numbers);
                    }
                    else if(winner == "x")
                    {
                        gameOver = true;
                        break;
                    }
                    else if(winner == "o")
                    {
                        gameOver = true;
                        break;
                    }
                    else if(i == 4)
                    {
                        int numb = 0;
                        Program.printBoard(numbers);
                        Console.Write("Player x's move (1-9) : ");
                        string move = Console.ReadLine();
                        numb = int.Parse(move);
                        numb -= 1;
                        numbers[numb] = "x";
                        if(Program.determineWinner(numbers) != "x" || Program.determineWinner(numbers) != "o")
                        {
                            gameOver = true;
                            draw = "draw";
                            break;
                        }
                    }
                }
                if(draw == "draw")
                {
                    Program.printBoard(numbers);
                    Console.WriteLine("It's a draw you both suck!");
                }
                Program.printBoard(numbers);
                Console.WriteLine($"The winner is : {Program.determineWinner(numbers)}");

            }
            
        }
    }
}