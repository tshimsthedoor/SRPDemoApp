namespace SRPDemoApp
{
    class SeniorityChecker
    {
        public string CheckSeniority(double experience)
        {
            if (experience > 5)
                return "Senior";
            else
                return "Junior";
        }
    }
}
