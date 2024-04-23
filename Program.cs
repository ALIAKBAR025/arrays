//1 tsk.
//int[,] array =
//{
//    {10, 20, 30 },
//    {60, 50, 40 },
//    {90, 80, 70 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//2tsk.

//int sum = 0;
//int[,] array =
//{
//    {10, 20, 30},
//    {40, 50, 60},
//    {70, 80, 90 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum += array[i, j];

//    }
//}
//Console.WriteLine(sum);
//3tsk.
//int[,] array =
//{
//    {10, 20, 30 },
//    {30, 40, 50 },
//    {50, 60, 70 },
//};
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j==0)
//        sum += array[i, j];
//    }
//}
//Console.WriteLine(sum);

//int sum = 0;    
//int[,] array =
//{
//    {10, 20, 30},
//    {30, 40, 50},
//    {50, 60, 70},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    sum += array[i,0];

//}
//Console.WriteLine(sum);
//4tsk.
//int[,] array =
//{
//    {10, -40, 30},
//    {20, -50, 60},
//    {30, -52, 70},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] < 0)
//        { Console.WriteLine(array[i, j]); }
//    }
//};

//5tsk.

//int[,] array =
//{
//    {100,30,50},
//    {20,60,70},
//    {30,90,100},
//};
//int min = array[0,0];
//int max = array[0,0];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i,j]>max)
//        {
//            max = array[i, j];
//        }
//        else if (array[i,j]<min)
//        {
//            min = array[i, j];
//        }
//    }
//}
//Console.WriteLine($"Minimum: {min} Maximum: {max}");

//6tsk.

//int[,] array =
// {   {10, 25, -40},
//    {-71, 50, 79},
//    { -90, 30, 0},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] % 2 == 0 && array[i,j]>0)
//        {
//             array[i, j] = 2; 

//        }
//        else if (array[i, j] %2 != 0 && array[i, j] > 0)
//        {
//                array[i, j] = 1;

//        }
//        if (array[i, j] %2 == 0 && array[i, j] < 0)
//        {
//                array[i, j] = -2;

//        }
//       else if (array[i, j] % 2 != 0 && array[i,j] < 0)
//        { 
//                array[i, j] = -1;

//        }
//else if (array[i, j] == 0)
//        {
//            array[i, j] = 0;
//        }
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    { Console.Write(array[i, j] + " "); }

//    Console.WriteLine();
//}

//7tsk.

//int[,] array =
//{
//    {1, 2, 3, 4 },
//    {5, 6, 7, 8 },
//    {9, 10, 11, 12 },
//    {8, 18, 19, 22 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[1, j] = 0;
//    }

//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    { Console.Write(array[i, j] + " "); }

//    Console.WriteLine();
//}

//8tsk.
//int[,] array =
//{
//    {1, 2, 3  },
//    { 4, 5, 6 },
//    { 6, 7, 8 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, 2] = 0;
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " " );
//    }
//    Console.WriteLine();
//}

using System.Diagnostics.CodeAnalysis;

//9tsk.
//int[,] array =
//{
//    { 1, 2, 3 },
//    { 4, 5, 6 },
//    { 6, 7, 8 },
//};
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i==j)
//        {
//            sum += array[i, j];
//        }
//    }
//}
/*Console.WriteLine(sum)*/;
//for (int i = 0; 0 < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " " );
//            }
//    Console.WriteLine();
//}

//10tsk.

//int[,] array =
//{
//    {1, 2, 3, 4 },
//    {5, 6, 7, 8 },
//    {9, 10, 11, 12 },
//    {13, 14, 15, 16 },
//};
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum = array[0,3] + array[1,2] + array[2,1] + array[3,0];
//    }
//}
//Console.WriteLine(sum);

//11tsk.

//int[,] array =
//{
//    {1,2,3,4,5},
//    {1,2,3,4,6},
//    {8,9,5,6,7},
//    {6,5,4,3,2},
//    {7,8,9,2,1},
//};
//
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j < i)
//            array[i, j] = 0;

//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();

//12tsk.
//int[,] array =
//{
//    {1, 2, 3, 4, 5 },
//    {1, 2, 3, 5, 6 },
//    {1, 4, 6, 7, 8 },
//    {0, 1, 1, 2, 3 },
//    {5, 8, 13, 21, 34 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i < j)
//            array[i, j] = 0;
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}




// 14tsk.

//int[,] array =
//{
//    {1,5,8 },
//    {3,12,7},
//    {4,13,9},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int sum = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum+= array[i,j];
//    }
//    Console.WriteLine(sum);
//}

//15tsk.
//int[,] array =
//{
//    {1, 2, 3},
//    {4, 5, 6},
//    {5, 6, 7},
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int sum = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum += array[j,i];
//    }
//    Console.WriteLine(sum);
//}

//16 tsk.
//int[,] array =
//{
//    {1,1,5,0,1,1 },
//    {1,1,2,0,1,1 },
//    {1,1,3,0,1,1 },
//    {1,1,4,0,1,1 },
//};
//int shift = 3;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j - shift > 0)
//        {
//            array[i, j] = array[i, j - shift];
//        }
//        else
//            array[i, j] = 0;
//    }
//}
//for (int i = 0;i < array.GetLength(0); i++)
//{
//    for(int j = 0;j < array.GetLength(1); j++)
//    {
//        Console.Write($"{array[i, j]}  " );
//    }

//    Console.WriteLine();
//}


//18tsk.
//bool iscomplex = false;
//int[,] array =
//{
//    {1,2,3},
//    {4,5,6},
//    {5,6,7},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] <= 1)
//        {
//            continue;
//        }
//        else
//        {
//            iscomplex = false;
//            int squarefoot = Convert.ToInt32(Math.Sqrt(array[i, j]));
//            for (int k = 0; k < squarefoot; k++)
//            {
//                if (array[i, j] % k == 0)
//                {
//                    iscomplex = true;
//                }

//            }
//            if (!iscomplex)
//            {
//                Console.WriteLine(array[i, j]);
//            }

//        }
//    }
//}
