using System;

{

    var x = Convert.ToInt32(Console.ReadLine());
    var y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("{0}+{1}={2}", x,y, x+y);
    Console.WriteLine("{0}-{1}={2}", x, y, x-y);
    Console.WriteLine("{0}*{1}={2}", x, y, x*y);
    Console.WriteLine("{0}/{1}={2}", x, y, x/y);
    Console.WriteLine("{0} mod {1}={2}", x, y, x%y);

}