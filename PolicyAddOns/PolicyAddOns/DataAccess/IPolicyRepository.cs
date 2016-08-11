namespace PolicyAddOns.DataAccess
{
    internal interface IWritePolicyAction
    {
        void AddAddOnToPolicy(AddOns policyWithAddOn, Policy policy);
    }
}