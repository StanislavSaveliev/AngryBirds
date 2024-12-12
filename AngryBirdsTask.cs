using System;

namespace AngryBirds
{
    public static class AngryBirdsTask
    {
        // Константа ускорения свободного падения
        private const double g = 9.8;

        public static double FindSightAngle(double speed, double distance)
        {
            // Угол прицеливания
            return 0.5 * Math.Asin(g * distance / (speed * speed));
        }
    }
}
