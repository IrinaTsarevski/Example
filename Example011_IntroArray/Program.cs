double Max (double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
 double[] array = { 45, 63, 2, 96, 45.6, 98, 359, 67, 33 };

 double max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
 Console.WriteLine(max);
