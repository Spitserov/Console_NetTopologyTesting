namespace Console_NetTopologyTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Command: " +
                "\r\n1 = Measure the distance between points" +
                "\r\n2 = Create a point..." +
                "\r\n3 = Etc...");

            string myCommandInput = Console.ReadLine();

            switch (myCommandInput)
            {
                case "1":
                    Console.WriteLine("Distance between points is: " + TestingUtils.MeasureDistanceBetweenPoints());
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Your NetTopologySuite Point is: " + TestingUtils.CreatePoint());
                    Console.ReadLine();
                    break;

                default:
                    break;
            }



            //

            //Console.WriteLine("you selected a different command");


        }
    }
}