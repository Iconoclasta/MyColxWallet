using System;

namespace mycolxwallet.org.Models
{
	public class SigningRawTxFailed : Exception
	{
		public SigningRawTxFailed(string message) : base(message) {}
	}
}