# MyPIVXWallet
Web wallet for the ColossusXT cryptocurrency (PIVX) 

This project is based on MyEtherWallet and MyDashWallet, it is open-source, free to use and development was funded by PIVX team :)

# Runs locally
You can simply download the website https://MyPIVXWallet.org and run it locally, the whole wallet functionality (including addresses, private keys and generating keystore wallets, unlocking, etc.) all runs offline and in your browser. However when you want to see the current PIVX amount or send out PIVX you need to be online as the website communicates with https://chainz.cryptoid.info for the PIVX amount in your addresses and will communicate with the full PIVX node on MyPIVXWallet when sending out locally signed transactions.

If you have your own full node you can simply replace it by opening up the source code and either change the connection parameters in PIVXNode.cs or simply derive from that class and enter your own rpc username, password and IP. Please note that all signing happens locally in your browser, this will not increase the security of your transaction in any way, but if it makes you happy not to rely on third parties for sending signed transactions into the PIVX network, feel free to run your own. Obviously anyone can simply copy the website and host it on their own server, we cannot guarantee that such sites don't change how the service works, thus you should ONLY trust this url https://MyPIVXWallet.org.

If you want to host it yourself, setup a PIVX node with RPC access and use those parameters in the PIVXNode.cs (for broadcasting tx out to the PIVX network).
The website can be compiled with Visual Studio 2017 and can be hosted on any IIS version compatible with ASP.NET Core 2.0.
