namespace NetworkManagementAPI.Repository.CustomExceptions
{
    public sealed class DirectRecomendationLimitException : RecomendationLimitException
    {
        public DirectRecomendationLimitException() : base("Direct recomendations limit reached")
        {
        }
    }
}
