namespace lab1
{
    public class Problem1
    {
        public delegate void EventRaiser();
        public event EventRaiser OnMultipleOfTenReached;

        public int Add(int x, int y)
        {
            int iSum = x + y;
            if ((iSum % 10 == 0) && (OnMultipleOfTenReached != null))
            { OnMultipleOfTenReached(); }
            return iSum;
        }
    }
}
