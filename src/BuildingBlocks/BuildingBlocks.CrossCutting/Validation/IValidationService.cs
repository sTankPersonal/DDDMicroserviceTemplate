namespace BuildingBlocks.CrossCutting.Validation
{
    public interface IValidationService
    {
        Task ValidateAsync<TDto>(TDto dto);
    }
}
