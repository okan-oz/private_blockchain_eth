using System.Net.NetworkInformation;
using Nethereum.Hex.HexTypes;
using Nethereum.Web3;

namespace WrapNethereum;
public class WrapNethereumCore
{
    private  string rpcUrl = "https://mainnet.infura.io/v3/YOUR_INFURA_PROJECT_ID";
    private readonly Web3 web3;

    public WrapNethereumCore(string rpcUrl)
    {
        this.rpcUrl = rpcUrl;
        this.web3 = new Web3(rpcUrl);

    }

    public async Task<HexBigInteger> GetAccountBalanceAsync(string accountAddress)
    {
        // Hesap bakiyesini Wei cinsinden alıyoruz
        HexBigInteger balanceInWei = await web3.Eth.GetBalance.SendRequestAsync(accountAddress);

        // Bakiye, BigInteger türünde döndürülecek
        return balanceInWei;
    }
        


}

