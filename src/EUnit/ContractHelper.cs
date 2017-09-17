using System;
using System.IO;
using System.Text;

namespace EUnit
{
    public abstract class ContractHelper
    {
        protected Nethereum.Web3.Web3 _client;

        public String ContractAddress { get; private set; }

        protected string GetABIFromFile(String path)
        {
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                String text = streamReader.ReadToEnd();
                return text;
            }
        }

        protected string GetBytesFromFile(String path)
        {
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                String text = streamReader.ReadToEnd();
                return "0x" + text;
            }
        }
        
        protected string GetBytesFromFile(String path, String contractname)
        {
            var fileStream = new FileStream(String.Format("{0}/{1}.bin",path, contractname) , FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                String text = streamReader.ReadToEnd();
                return "0x" + text;
            }
        }

        protected Nethereum.Contracts.Contract GetContract(String path, String contractName)
        {
            if (!String.IsNullOrEmpty(ContractAddress))
            {
                String abi = GetABIFromFile(String.Format(@"{0}{1}.abi", path, contractName));
        
                return _client.Eth.GetContract(abi, ContractAddress);
            }
            else
            {
                throw new ArgumentNullException("No contract address");
            }
        }
    }
}