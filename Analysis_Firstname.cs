using System;

using static System.Math;

namespace Interview

{

public class Analysis

{

public double GetRandomNumber1()

{

Random random = new Random();

return Round((random.NextDouble() - 0.5) * 2);

}

public double GetRandomNumber2()

{

Random random = new Random();

return Round((random.NextDouble() - 0.5) * 2.99);

}

}

}
