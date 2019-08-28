using ProxyServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyServer.ViewModels
{
	public class AdminViewModel
	{
		public int AvaibleBitcountPayment { get; set; }
		public List<BitcoinPayment> bitcoinPaymentsList { get; set; }
	}
}
