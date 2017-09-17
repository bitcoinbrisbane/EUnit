using System;
using Nethereum;

namespace EUnit
{
    ///Proxy class
    public class ERC20 : ContractHelper, IContract, IERC20
    {
        private readonly Nethereum.Contracts.Contract _contract;
        private readonly String _contractName;

        public String Name 
        { 
            get 
            { 
                var functionToTest = _contract.GetFunction("name");

                return functionToTest.CallAsync<String>().Result;
            }
        }

        public ERC20(String contractAddress, String contractName, String abi, String bin, String url)
        {
            _contractName = contractName;
            _client = new Nethereum.Web3.Web3(url);
        }

        public ERC20(String contractAddress, String contractName, String path, String url)
        {
            _contractName = contractName;
            _client = new Nethereum.Web3.Web3(url);

            _contract = base.GetContract(contractName, path);
        }
    }
}