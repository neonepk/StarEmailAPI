using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarEmailAPI.Models
{
    public class Email
    {
		[Key]
		[Required]
		public long EmailId { get; set; }
		[Required]
		public string EmailTo { get; set; }
		[Required]
		public string EmailFrom { get; set; }
		[Required]
		public string Subject { get; set; }
		public string Body { get; set; }
		[Required]
		public bool Sent { get; set; }
		public bool Read { get; set; }
		[Required]
		public bool Delete { get; set; }
		[Required]
		public DateTime MailDate { get; set; }
		public int Importance { get; set; }
		public int Status { get; set; }
		public string MailCC { get; set; }
		public string MailBCC { get; set; }
		public int ReplyType { get; set; }
		public long RefemailId { get; set; }
		public DateTime LogDateTime { get; set; }
		public DateTime Dispatched { get; set; }
		public string BodyFormat { get; set; }
		public DateTime Delivered { get; set; }
		public int Tries { get; set; }
		public string Exception { get; set; }

	}
}
