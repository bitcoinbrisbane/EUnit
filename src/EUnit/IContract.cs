using System;

namespace EUnit
{
    public interface IContract
    {
        String ContractName { get; }
        
        String ContractAddress { get; }
    }
}