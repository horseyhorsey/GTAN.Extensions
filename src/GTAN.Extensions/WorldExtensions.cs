using GTAN.Data;
using GTANetworkAPI;
using GTANetworkMethods;
using System;
using System.Linq;
using System.Threading;

namespace GTAN.Extensions
{
    public static class WorldExtensions
    {
        #region Fields
        private static Timer _timer;
        private static TimeSpan Time;
        #endregion

        #region Public Methods
        /// <summary>
        /// Disposes of the timer for the world.
        /// </summary>
        /// <param name="world"></param>
        public static void DisposeWorldTimer(this World world)
        {
            _timer?.Dispose();
        }

        /// <summary>
        /// Get time from the local <see cref="Time"/>
        /// </summary>
        /// <param name="world"></param>
        /// <returns></returns>
        public static TimeSpan GetTimeGood(this World world)
        {
            return Time;
        }

        /// <summary>
        /// Finds nearest ATM in world to the given position.
        /// </summary>
        /// <param name="world"></param>
        /// <param name="position"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static Vector3 FindNearestAtm(this World world, Vector3 position, float radius = 1000f)
        {
            var closeAtms = GtaLocations.Atms.Values.Where(x => x.Y > (position.Y - radius) && x.Y < (position.Y + radius));
            Vector3 atm = null;
            float distance = radius;
            foreach (var item in closeAtms)
            {
                var caughtDistance = item.DistanceTo(position);
                if (caughtDistance < distance)
                {
                    distance = caughtDistance;
                    atm = item;
                }
            }

            return atm;
        }

        /// <summary>
        /// Sets the time
        /// </summary>
        /// <param name="world"></param>
        /// <returns></returns>
        public static void SetTime(this World world, int hours, int mins)
        {
            Time = new TimeSpan(hours, mins, 0);
        }

        /// <summary>
        /// Creates a timer for the world and adds a minute each time. Timer set to 60000 milliseconds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="world">Game world</param>
        /// <param name="multiplier">The multiplier * 60000</param>
        /// <returns>The tick time if set, otherwise -1 not started</returns>
        public static int StartWorldTimer(this World world, double multipler)
        {
            if (_timer == null)
            {
                var tickTime = (int)Math.Round(60000 * multipler);
                _timer = new Timer(OnTimerCallback, null, 0, tickTime);
                return tickTime;
            }
            else
                return -1;
        } 
        #endregion

        #region Private methods        

        /// <summary>
        /// Sets the time from the multiplier
        /// </summary>
        /// <param name="state"></param>
        private static void OnTimerCallback(object state)
        {
            Time = Time.Add(new TimeSpan(0, 1, 0));
            NAPI.World.SetTime(Time.Hours, Time.Minutes, Time.Seconds);
        }
        #endregion
    }
}
