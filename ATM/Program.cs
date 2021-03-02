﻿using System;

namespace Main
{
    class Card
    {
        private decimal Money_ = 0;
        private int Id;
        private String Owner;
        private String Login, Password;

        public Card() { }
        public Card(decimal money, int id, string log, string pass)
        {
            this.Money_ = money;
            this.Id = id;
            this.Login = log;
            this.Password = pass;
        }

        public decimal AddMoney()
        {
            decimal money;
            Console.WriteLine("Enter count : ");
            money = decimal.Parse(Console.ReadLine());
            if (money != 0)
            {
                this.Money_ = money;
            }
            else
            {
                Console.WriteLine("Error add money....");
            }
            return money;
        }
        public decimal WithDraw()
        {
            decimal money;
            money = decimal.Parse(Console.ReadLine());
            if (money != 0)
            {
                this.Money_ -= money;
            }
            else
            {
                Console.WriteLine("Error add money....");
            }
            return money;
        }
        
        public int getId()
        {
            return Id;
        }

        public String getOwner()
        {
            return Owner;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is {Money_}");
        }

        public void Menu()
        {
            char action = ' ';
            Console.WriteLine("Enter login :");
            Login = Console.ReadLine();
            if (Login == "admin")
            {
                Console.WriteLine("Enter password :");
                Password = Console.ReadLine();
                if (Password == "admin")
                {
                    do
                    {
                        Console.WriteLine("1. Add money");
                        Console.WriteLine("2. Minus money");
                        Console.WriteLine("3. Show balance");
                        Console.WriteLine("q - for exit");
                        Console.WriteLine("Enter action : ");
                        action = char.Parse(Console.ReadLine());
                        switch (action)
                        {
                            case '1':
                                Console.WriteLine($"You enter add money function...");
                                AddMoney();
                                break;
                            case '2':
                                Console.WriteLine($"You enter minus money function...");
                                WithDraw();
                                break;
                            case '3':
                                ShowBalance();
                                break;

                        }

                    } while (action != 'q');
                }
                else
                {
                    Console.WriteLine("Error password...");
                }
            }
            else
            {
                Console.WriteLine("Error login...");
            }
        }
    }

    class ATM : Card 
    {
        private bool state;
        public void CardInfo()
        {
            Console.WriteLine($"ID : {getId()}");
            Console.WriteLine($"Name owner: {getOwner()}");
        }

        public bool isInsert()
        {
            return state;
        }

        public void CardOperation()
        {
            if(isInsert())
            {
                CardInfo();
                Menu();
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.Menu();
        }
    }
}
