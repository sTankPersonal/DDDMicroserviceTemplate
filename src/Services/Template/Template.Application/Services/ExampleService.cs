
using BuildingBlocks.SharedKernel.DomainServices;
using BuildingBlocks.SharedKernel.Repositories;

namespace Template.Application.Services
{
    public class ExampleService(IRepository ExampleRepository) : IDomainService
    {

    }
}
