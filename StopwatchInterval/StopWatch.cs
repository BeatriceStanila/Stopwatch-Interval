namespace Watch
{
    public class StopWatch
    {
        /* 
         * create the private fields
         * create the public methods to access the fields
         */

        //private startTime
        private DateTime _startTime;

        //private endTime
        private DateTime _endTime;

        // boolean to check if the watch is running
        private bool _isRunning;


        //start method
        public void StartTime()
        {
            //check if the watch is running
            if (_isRunning)
            {
                //throw an error if it's running
                throw new InvalidOperationException("The watch is running.");
            }

            //set the startTime to the current time
            _startTime = DateTime.Now;
            _isRunning = true;
        }


        //stop method
        public void StopTime()
        {
            //check if the watch is not running
            if (!_isRunning)
            {
                throw new InvalidOperationException("Watch is not running");
             }
            _endTime = DateTime.Now;
            _isRunning = false;
        }

        //get interval method
        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}