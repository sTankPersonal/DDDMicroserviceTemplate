namespace BuildingBlocks.CrossCutting.Resilience
{
    public interface IResiliencePolicyProvider
    {
        object GetPolicy(string policyName);
    }
}
