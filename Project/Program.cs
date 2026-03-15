namespace TASK_1 {
    public class Application
    {
        public double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0)
                return double.NaN;

            double sum = 0.0;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            return sum / values.Length;
        }

    }
}
