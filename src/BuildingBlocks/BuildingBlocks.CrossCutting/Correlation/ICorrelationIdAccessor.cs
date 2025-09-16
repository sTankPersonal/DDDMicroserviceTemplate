namespace BuildingBlocks.CrossCutting.Correlation
{
    internal interface ICorrelationIdAccessor
    {
        string? GetCorrelationId();
        void SetCorrelationId(string correlationId);
    }
}
