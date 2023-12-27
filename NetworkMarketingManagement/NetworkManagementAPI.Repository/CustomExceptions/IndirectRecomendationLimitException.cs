namespace NetworkManagementAPI.Repository.CustomExceptions
{
    public sealed class IndirectRecomendationLimitException : RecomendationLimitException
    {
        public IndirectRecomendationLimitException() : base("Indirect recomendations limit reached")
        {
        }
    }
}
