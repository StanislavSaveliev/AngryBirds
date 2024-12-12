using System;

namespace AngryBirds
{
    public static class AngryBirdsTask
    {
        // ��������� ��������� ���������� �������
        private const double g = 9.8;

        public static double FindSightAngle(double speed, double distance)
        {
            // ���� ������������
            return 0.5 * Math.Asin(g * distance / (speed * speed));
        }
    }
}
