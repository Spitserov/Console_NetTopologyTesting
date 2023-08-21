using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//don't have to call for NetTopologySuite library 

namespace Console_NetTopologyTesting
{
    internal class TestingUtils
    {

        public static NetTopologySuite.Geometries.Point CreatePoint()
        {
            double xInput = Convert.ToDouble(Console.ReadLine());
            double yInput = Convert.ToDouble(Console.ReadLine());
            return new NetTopologySuite.Geometries.Point(xInput, yInput);
        }

        public static double MeasureDistanceBetweenPoints()
        {
            Console.WriteLine("Insert Point1 X,Y values");
            NetTopologySuite.Geometries.Point myPoint1 = CreatePoint();
            Console.WriteLine("Insert Point2 X,Y values");
            NetTopologySuite.Geometries.Point myPoint2 = CreatePoint();

            return myPoint1.Distance(myPoint2);
        }
    }
}
