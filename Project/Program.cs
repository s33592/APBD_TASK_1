namespace TASK_1 {
    public class Application
    {
        public double CalculateAverage(int[] values)
        {
            double sum = 0.0;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            return sum / values.Length;
        }

        public int CalculateMax(int[] values)
        {
            if (values == null || values.Length == 0)
                return int.MinValue;

            int max = int.MinValue;

            for(int i = 0; i < values.Length; i++)
            {
                if(max < values[i])
                    max = values[i];
            }

            return max;
        }
    }
}
