# MyColxWallet
Web wallet for the ColossusXT cryptocurrency (COLX) 

It is based on MyEtherWallet and MyDashWallet and free to use.

This project is open-source, free to use and development was funded by COLX team :)

# Runs locally
You can simply download the website https://MyColxWallet.org and run it locally, the whole wallet functionality (including addresses, private keys and generating keystore wallets, unlocking, etc.) all runs offline and in your browser. However when you want to see the current COLX amount or send out COLX you need to be online as the website communicates with https://chainz.cryptoid.info for the COLX amount in your addresses and will communicate with the full COLX node on MyColxWallet when sending out locally signed transactions.

If you have your own full node you can simply replace it by opening up the source code and either change the connection parameters in ColxNode.cs or simply derive from that class and enter your own rpc username, password and IP (and use it in Startup.cs for your own hosted or local website). Please note that all signing happens locally in your browser, this will not increase the security of your transaction in any way, but if it makes you happy not to rely on third parties for sending signed transactions into the Dash network, feel free to run your own. Obviously anyone can simply copy the website and host it on their own server, we cannot gurantee that such sites don't change how the service works, thus you should ONLY trust this url https://MyColxWallet.org.

If you want to host it yourself, setup a COLX node with RPC access and use those parameters in the ColxNode.cs to broadcast tx out to the COLX network.
The website can be compiled with Visual Studio 2017 and can be hosted on any IIS version compatible with ASP.NET Core 2.0.