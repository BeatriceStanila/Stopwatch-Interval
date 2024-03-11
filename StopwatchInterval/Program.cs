namespace Watch
{



    public class Program
    {
        public static void Main(string[] args)
        {
            //initialize  a new instance for StopWatch class
            var stopwatch = new StopWatch();

            //create a for loop to start/stop the watch 2 times
            for ( int i = 0; i < 2; i++)
            {
                stopwatch.StartTime();

                //add a delay of 1000ms
                Thread.Sleep(1000);


                stopwatch.StopTime();

                //console log the interval
                Console.WriteLine("Duration: " + stopwatch.GetInterval());

                Console.WriteLine("Press enter so start the watch one more time");

                Console.ReadLine();
            }



        }
    }
}