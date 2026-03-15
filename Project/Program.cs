namespace TASK_1 {
    public class Application
    {
        public double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0)
                throw new Exception("Invalid input parameter");

            double sum = 0.0;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            return sum / values.Length;
        }

        public int CalculateMax(int[] values)
        {
            if (values == null || values.Length == 0)
                throw new Exception("Invalid input parameter");

            int max = int.MinValue;

            for(int i = 0; i < values.Length; i++)
            {
                if(max < values[i])
                    max = values[i];
            }

            return max;
        }

        public int CalculateMin(int[] values) {
            if (values == null || values.Length == 0)
                throw new Exception("Invalid input parameter");

            int min = int.MaxValue;

            for (int i = 0; i < values.Length; i++) {
                if (values[i] < min)
                    min = values[i];
            }
            return min;
        }
    }
}
