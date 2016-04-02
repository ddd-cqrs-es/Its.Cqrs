// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Its.Domain;

namespace Test.Domain.Banking
{
    public partial class CheckingAccount
    {
        public class FundsWithdrawn : Event<CheckingAccount>
        {
            public decimal Amount { get; set; }

            public override void Update(CheckingAccount aggregate)
            {
                aggregate.Balance -= Amount;
                if (aggregate.Balance <= 0)
                {
                    aggregate.IsOverdrawn = true;
                }
            }
        }
    }
}
