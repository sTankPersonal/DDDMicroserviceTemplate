namespace BuildingBlocks.CrossCutting.Tracing
{
    public interface ITracingService
    {
        void StartTrace(string traceName);
        void EndTrace(string traceName);
    }
}
