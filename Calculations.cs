using System;

public class Calculations
{
	public static bool CalculateHit(int ac, int thaco, int roll)
	{
        bool wasHit = false;
        if (roll > thaco + (ac * -1))
        {
            wasHit = true;
        }
        return wasHit;
    }
}
