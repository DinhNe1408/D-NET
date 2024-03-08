using SDCores;

namespace API._Services.Interfaces
{
    [DependencyInjection(ServiceLifetime.Scoped)]
    public interface I_Demo
    {
        Task<OperationResult> Demo();
    }
}