﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityDtoLayer.Dtos.CustomerAccountProcessDtos
{
	public class SendMoneyForCustomerAccountProcssDto
	{
		public string ProcessType { get; set; }
		public decimal Amout { get; set; }
		public DateTime ProcessDate { get; set; }
		public int SenderID { get; set; }
		public int ReceiverId { get; set; }
		public string ReceiverAccountNumber { get; set; }
		public string CustomerAccountID { get; set; }

















	}
}
