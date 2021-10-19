using System;
using System.Threading;

namespace MATRIXV2._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            int Input_x = int.Parse(Console.ReadLine());
            int Input_y = int.Parse(Console.ReadLine());
            int number_of_living_cels = int.Parse(Console.ReadLine());

            int[,] Matrix = new int[Input_x, Input_y];
            Matrix[Input_x / 2, Input_y / 2] = 1;
            int height_y = Matrix.GetLength(0);
            int width_x = Matrix.GetLength(1);

            while (count < number_of_living_cels)
            {
                Random rnd = new Random();
                int dice_x = rnd.Next(0, Input_x);
                int dice_y = rnd.Next(0, Input_y);


                if (dice_x == Input_x - 1 && (dice_y != 0 && dice_y != Input_y - 1))
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x - 1, dice_y] == 1 || Matrix[dice_x, dice_y - 1] == 1 || Matrix[dice_x, dice_y + 1] == 1
                    || Matrix[dice_x - 1, dice_y + 1] == 1 || Matrix[dice_x - 1, dice_y - 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }
                else if (dice_x == Input_x - 1 && dice_y == 0)
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x - 1, dice_y] == 1 || Matrix[dice_x - 1, dice_y + 1] == 1 || Matrix[dice_x, dice_y + 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }

                else if (dice_x == 0 && dice_y == Input_y - 1)
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x + 1, dice_y] == 1 || Matrix[dice_x + 1, dice_y - 1] == 1 || Matrix[dice_x, dice_y - 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }

                else if (dice_y == Input_y - 1 && (dice_x != 0 && dice_x != Input_x - 1))
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x - 1, dice_y] == 1 || Matrix[dice_x, dice_y - 1] == 1
                    || Matrix[dice_x - 1, dice_y - 1] == 1 || Matrix[dice_x + 1, dice_y - 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }

                else if (dice_y == Input_y - 1 && dice_x == Input_x - 1)
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x - 1, dice_y] == 1 || Matrix[dice_x, dice_y - 1] == 1
                      || Matrix[dice_x - 1, dice_y - 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }

                else if (dice_x == 0 && (dice_y != 0 && dice_y != Input_y - 1))
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[0, dice_y + 1] == 1 || Matrix[0, dice_y - 1] == 1
                      || Matrix[dice_x + 1, dice_y + 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }

                else if (dice_y == 0 && (dice_x != 0 && dice_x != Input_x - 1))
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x - 1, dice_y] == 1 || Matrix[dice_x + 1, dice_y] == 1 || Matrix[dice_x, dice_y + 1] == 1
                    || Matrix[dice_x - 1, dice_y + 1] == 1 || Matrix[dice_x + 1, dice_y + 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }

                else if (dice_x == 0 && dice_y == 0)
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x + 1, dice_y] == 1 || Matrix[dice_x, dice_y + 1] == 1
                      || Matrix[dice_x + 1, dice_y + 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }

                }


                else if ((dice_x != 0 && dice_x != Input_x - 1) && (dice_y != 0 && dice_y != Input_y))
                {
                    if (Matrix[dice_x, dice_y] == 0 && (Matrix[dice_x - 1, dice_y] == 1 || Matrix[dice_x + 1, dice_y] == 1 || Matrix[dice_x, dice_y - 1] == 1 || Matrix[dice_x, dice_y + 1] == 1
                    || Matrix[dice_x - 1, dice_y + 1] == 1 || Matrix[dice_x + 1, dice_y - 1] == 1 || Matrix[dice_x - 1, dice_y - 1] == 1 || Matrix[dice_x + 1, dice_y + 1] == 1))
                    {
                        Matrix[dice_x, dice_y] = 1;
                        count++;
                    }
                }

            }

            for (int y = 0; y < height_y; y++)
            {
                for (int x = 0; x < width_x; x++)
                {
                    Console.Write(Matrix[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int count_2 = 0;
            while (count_2 < 4)
            {
                int[,] Matrix_New = new int[Input_x, Input_y];
                count_2++;
                int y = 0;
                int x = 0;
                int count_cells = 0;

                while (y != Input_y)
                {
                    if (x == 0 && y == 0)
                    {
                        if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells < 2)
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                    }

                    else if (y == 0 && (x != 0 && x != Input_x - 1))
                    {
                        if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if ((count_cells < 2) || (count_cells > 3))
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x + 1, y] == 0)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                    }

                    else if (x == Input_x - 1 && y == 0)
                    {
                        if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells < 2)
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                    }

                    else if (x == 0 && y == Input_y - 1)
                    {
                        if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells < 2)
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                    }

                    else if (y == Input_y - 1 && (x != 0 && x != Input_x - 1))
                    {
                        if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if ((count_cells < 2) || (count_cells > 3))
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                    }

                    else if (y == Input_y - 1 && x == Input_x - 1)
                    {
                        if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells < 2)
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                    }

                    else if (x == 0 && (y != 0 && y != Input_y - 1))
                    {
                        if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if ((count_cells < 2) || (count_cells > 3))
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                    }

                    else if (y == 0 && (x != 0 && x != Input_x - 1))
                    {
                        if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if ((count_cells < 2) || (count_cells > 3))
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                    }

                    else if ((x != 0 && x != Input_x - 1) && (y != 0 && y != Input_y))
                    {
                        if (Matrix[x, y] == 1)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if ((count_cells < 2) || (count_cells > 3))
                            {
                                Matrix_New[x, y] = 0;
                            }
                            count_cells = 0;
                        }
                        else if (Matrix[x, y] == 0)
                        {
                            if (Matrix[x - 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y + 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x + 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (Matrix[x - 1, y - 1] == 1)
                            {
                                count_cells++;
                            }
                            if (count_cells == 3)
                            {
                                Matrix_New[x, y] = 1;
                            }
                            count_cells = 0;
                        }
                    }
                    x++;
                    if (x == Input_x)
                    {
                        x = 0;
                        y++;
                    }
                }
                for (int count_y = 0; count_y < height_y; count_y++)
                {
                    for (int count_x = 0; count_x < width_x; count_x++)
                    {
                        Console.Write(Matrix_New[count_y, count_x] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}


