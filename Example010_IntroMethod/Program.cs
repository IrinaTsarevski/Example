double Max (double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
 double a1 = 45;
 double b1 = 23; 
 double c1 = 4;
 double a2 = 78;
 double b2 = 12;
 double c2 = 16;
 double a3 = 96;
 double b3 = 116;
 double c3 = 9.99;

 //double max1 = Max(a1, b1, c1);
 //double max2 = Max(a2, b2, c2);
 //double max3 = Max(a3, b3, c3);

 double max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
 Console.WriteLine(max);
