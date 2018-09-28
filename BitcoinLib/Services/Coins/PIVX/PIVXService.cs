using BitcoinLib.CoinParameters.PIVX;
using BitcoinLib.Services.Coins.Bitcoin;
using BitcoinLib.Services.Coins.Dash;

namespace BitcoinLib.Services.Coins.PIVX
{
	/// <summary>
	/// Mostly the same functionality as <see cref="BitcoinService"/>.
	/// </summary>
	public class PIVXService : DashService, IPIVXService
	{
		public PIVXService(bool useTestnet = false) : base(useTestnet) { }

		public PIVXService(string daemonUrl, string rpcUsername, string rpcPassword,
			string walletPassword) : base(daemonUrl, rpcUsername, rpcPassword, walletPassword) { }

		public PIVXService(string daemonUrl, string rpcUsername, string rpcPassword,
			string walletPassword, short rpcRequestTimeoutInSeconds) : base(daemonUrl, rpcUsername,
			rpcPassword, walletPassword, rpcRequestTimeoutInSeconds) { }
		
		public new PIVXConstants.Constants Constants => PIVXConstants.Constants.Instance;
	}
}