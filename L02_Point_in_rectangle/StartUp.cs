using System;
using System.Linq;

namespace L02_Point_in_rectangle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var recangleCoordinates = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();
            Rectangle rectangle = new Rectangle(
                new Point(recangleCoordinates[0], recangleCoordinates[1]),
                new Point(recangleCoordinates[2], recangleCoordinates[3]));
            int numberOfPoints = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPoints; i++)
            {
                var pointCoords = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();
                Point point = new Point(pointCoords[0], pointCoords[1]);
                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
