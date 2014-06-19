using System;
namespace ShipDamage
{
    class ShipDamage
    {
        static int maxX;
        static int maxY;
        static int minX;
        static int minY;

        public static void Main()
        {
            #region ReadInputData
            int shipX1 = int.Parse(Console.ReadLine());
            int shipY1 = int.Parse(Console.ReadLine());
            int shipX2 = int.Parse(Console.ReadLine());
            int shipY2 = int.Parse(Console.ReadLine());

            int horizon = int.Parse(Console.ReadLine());

            int catapultX1 = int.Parse(Console.ReadLine());
            int catapultY1 = int.Parse(Console.ReadLine());

            int catapultX2 = int.Parse(Console.ReadLine());
            int catapultY2 = int.Parse(Console.ReadLine());

            int catapultX3 = int.Parse(Console.ReadLine());
            int catapultY3 = int.Parse(Console.ReadLine());

            #endregion

            int targetX1 = catapultX1;
            int targrtY1 = 2 * horizon - catapultY1;

            int targetX2 = catapultX2;
            int targrtY2 = 2 * horizon - catapultY2;

            int targetX3 = catapultX3;
            int targrtY3 = 2 * horizon - catapultY3;

            #region FindingTopAndBottomLinesOfShip

            maxX = Math.Max(shipX1, shipX2);
            maxY = Math.Max(shipY1, shipY2);
            minX = Math.Min(shipX1, shipX2);
            minY = Math.Min(shipY1, shipY2);

            #endregion

            int damageFromC1 = CalculateDamage(targetX1, targrtY1);
            int damageFromC2 = CalculateDamage(targetX2, targrtY2);
            int damageFromC3 = CalculateDamage(targetX3, targrtY3);

            Console.WriteLine("{0}%", damageFromC1 + damageFromC2 + damageFromC3);

        }

        public static int CalculateDamage(int x, int y)
        {
            int damage = 0;

            if (x < maxX && x > minX && y < maxY && y > minY)
            {
                damage = 100;
            }

            else if ( ((x == maxX || x == minX) && y < maxY && y > minY) ||
                        (x < maxX && x > minX && (y == maxY || y == minY)) )
            {
                damage = 50; 
            }

            else if ((x == maxX || x == minX) && (y == maxY || y == minY))
            {
                damage = 25;
            }
            else
            {
                damage = 0;
            }

            return damage;
        }
    }
}