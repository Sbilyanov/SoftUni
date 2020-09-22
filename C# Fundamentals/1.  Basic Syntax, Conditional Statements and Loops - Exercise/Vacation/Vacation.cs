using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());
            String groupType = Console.ReadLine();
            String day = Console.ReadLine();

            double ticket = 0.00;
         

            switch (day)
            {
                case ("Friday"):
                    {
                        if (groupType.Equals("Students"))
                        {
                            ticket = 8.45;
                            if (groupNum >= 30)
                            {
                                ticket = ticket * 0.85;
                            }

                        }

                        else if (groupType.Equals("Business"))
                        {
                            ticket = 10.90;
                            if (groupNum >= 100)
                            {
                                groupNum = groupNum - 10;
                            }

                        }
                        else if (groupType.Equals("Regular"))
                        {
                            ticket = 15;
                            if (groupNum >= 10 && groupNum <= 20)
                            {
                                ticket = ticket * 0.95;
                            }
                        }

                        break;
                    }
                case ("Saturday"):
                    {
                        if (groupType.Equals("Students"))
                        {
                            ticket = 9.80;
                            if (groupNum >= 30)
                            {
                                ticket = ticket * 0.85;
                            }
                        }

                        else if (groupType.Equals("Business"))
                        {
                            ticket = 15.60;
                            if (groupNum >= 100)
                            {
                                groupNum = groupNum - 10;
                            }
                        }
                        else if (groupType.Equals("Regular"))
                        {
                            ticket = 20;
                            if (groupNum >= 10 && groupNum <= 20)
                            {
                                ticket = ticket * 0.95;
                            }
                        }
                        break;
                    }
                case ("Sunday"):
                    {
                        if (groupType.Equals("Students"))
                        {
                            ticket = 10.46;
                            if (groupNum >= 30)
                            {
                                ticket = ticket * 0.85;
                            }
                        }
                        else if (groupType.Equals("Business"))
                        {
                            ticket = 16;
                            if (groupNum >= 100)
                            {
                                groupNum = groupNum - 10;
                            }
                        }
                        else if (groupType.Equals("Regular"))
                        {
                            ticket = 22.50;
                            if (groupNum >= 10 && groupNum <= 20)
                            {
                                ticket = ticket * 0.95;
                            }
                        }
                        break;
                    }
            }
            Console.WriteLine($"Total price: {ticket * groupNum:F2}");




        }

    }
}

