using System;
using System.Threading.Tasks;
using System.Numerics;

namespace EUnit
{
    public interface IERC20
    {
        String Name { get; }
        
        BigInteger TotalSupply { get; }

        Task<BigInteger> BalanceOf(String address);

        Task<Boolean> Transfer(String address, UInt64 _value);
    }
}