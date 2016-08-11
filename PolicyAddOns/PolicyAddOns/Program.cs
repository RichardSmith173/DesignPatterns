using PolicyAddOns.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyAddOns
{
    class Program
    {
        static void Main(string[] args)
        {
            var policyAction = new PolicyAction();
            var action = new AddOnsActions();

            Policy policy = new HomePolicy();

            var policyWithLegalCover = action.ReturnAddOn(policy, AddOnName.LegalCover) as LegalCover;
            policyAction.AddAddOnToPolicy(policyWithLegalCover, policy);

            var policyWithBikeProtection = action.ReturnAddOn(policyWithLegalCover, AddOnName.BikeProtection) as BikeProtection;
            policyAction.AddAddOnToPolicy(policyWithBikeProtection, policy);

            PrintPolicyDetails(policyWithBikeProtection, policy);

            Console.ReadLine();
        }
                
        private static void PrintPolicyDetails(IPolicy iPolicy, Policy policy)
        {
            Console.WriteLine($"Price: {policy.Price}.");

            Console.Write("AddOns: ");
            foreach (var item in policy.AddOns)
            {
                Console.Write($"{item.Name.ToString()} ");
            }
        }
    }
}
