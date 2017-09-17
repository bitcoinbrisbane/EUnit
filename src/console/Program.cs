using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Nethereum.Web3;
using System.Numerics;
using Nethereum.Util;

namespace console
{
    //Test RPC accounts
    //testrpc --account="0x221bbb8b9b508c2841a60f862e9d03c1997097f99ee83db94e077ff180265247,100000000000000000000" --account="0x9790dbc40d24723c34cf942f4dafac69ceb9e52bb9c92135221596ac25ba4270,100000000000000000000" --account="0x68296c6629c546483664ea232e33f187f60ca4ba123692c707168f2ac330dacf,100000000000000000000"
    class Program
    {
        //0x221bbb8b9b508c2841a60f862e9d03c1997097f99ee83db94e077ff180265247
        static String puntaa = "0xe2356d29d5dfecb4ee43c031204aeded24749959";

        //0x9790dbc40d24723c34cf942f4dafac69ceb9e52bb9c92135221596ac25ba4270
        static String alice = "0xa5f8ff129c19dbc0849619916c16010738ab5b1f";

        //0x68296c6629c546483664ea232e33f187f60ca4ba123692c707168f2ac330dacf
        static String bob = "0xaa727c20b128c298c13d56de8f087e998da28ab1";

        //0xb5b03722b215f55bd753814b6bce7b7ff98704b312a49b95fafa5ccfbee08ab9
        static String team = "0xe7b2bdd46ee2a540436773e5127c77b160a9af0c";

        //0xfd74b2d5b56010a52fa6f84fe7ed7f7b72b22cc5cd978172d83f6c27144996ae
        static String growth = "0xbcd5e9679b654db151c62b1f5669231f2aa8dcb9";

        static String contractAddress;

        static string contractPath;

        static string contractName;

        static void Main(string[] args)
        {
            //contractPath = "../../bin/src/contracts/";
            //contractPath = "/Users/lucascullen/Projects/Puntta/skrilla-smart-contract/bin/src/contracts/";
            contractPath = "/home/lucascullen/Projects/skrilla-smart-contract/bin/src/contracts/";

            if (args.Length > 0)
            {
                contractName = args[0];
            }
            else
            {
                contractName = "JincorToken";
            }

            EUnit.IERC20 token = new EUnit.ERC20(contractName, "0xd0E6B0d1E5a788347b8783607fba8634d13c7112");
            //Assert.AreEqual(token.Name, "Test");
        }
    }
}