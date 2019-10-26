using System;
using System.Collections.Generic;
using System.Text;

namespace BTCPayServer.Hwi
{
	public enum HwiCommands
	{
		Enumerate,
		GetMasterXpub,
		SignTx,
		GetXpub,
		SignMessage,
		GetKeypool,
		DisplayAddress,
		Setup,
		Wipe,
		Restore,
		Backup,
		PromptPin,
		SendPin
	}
}
