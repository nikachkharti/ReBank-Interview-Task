namespace NetworkManagementAPI.Repository.CustomExceptions
{
    public class RecomendationLimitException : Exception
    {
        public RecomendationLimitException()
        {
        }

        public RecomendationLimitException(string message) : base(message)
        {
        }
    }
}
