﻿
namespace BuildingBlocks.CrossCutting.Logging
{
    public interface ILoggingService
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message, Exception? exception = null);
    }
}
