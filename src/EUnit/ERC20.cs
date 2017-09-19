using System;
using Nethereum;
using System.Threading.Tasks;
using System.Numerics;

namespace EUnit
{
    ///Proxy class
    public class ERC20 : ContractHelper, IContract, IERC20
    {
        public Nethereum.Contracts.Contract Contract { get; set; }

        public String ContractName { get; private set; }

        public String Name { get; private set; }

        public BigInteger TotalSupply { get; private set; }

        public ERC20(String contractAddress, String contractName, String abi, String bin, String url)
        {
            ContractName = contractName;
            _client = new Nethereum.Web3.Web3(url);
            
            //this.Contract = new Nethereum.Contracts.Contract()
        }

        public ERC20(String contractAddress, String contractName, String path, String url)
        {
            ContractName = contractName;
            _client = new Nethereum.Web3.Web3(url);

            Contract = base.GetContract(contractName, path);
        }
        
        public async Task Load()
        {
            var functionToTest = Contract.GetFunction("totalSupply");
            TotalSupply = await functionToTest.CallAsync<BigInteger>();
        }

        public async Task<BigInteger> BalanceOf(string address)
        {
            var functionToTest = Contract.GetFunction("balanceOf");
            return await functionToTest.CallAsync<BigInteger>();
        }

        public async Task<Boolean> Transfer(string address, ulong _value)
        {
            throw new NotImplementedException();
        }
    }
}