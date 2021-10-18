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

		//public Email(string _emailto, long _emailid, string _emailfrom, string _subject, string _body, bool _sent, bool _read, bool _delete, DateTime _maildate, int _importance, int _status, string _mailcc, string _mailbcc, int _replytype, long _refemailid, DateTime _logdatetime, DateTime _dispatched, string _bodyformat, DateTime _delivered, int _tries, string _exception)
		//{
		//	this.EmailTo = _emailto;
		//	this.EmailId = _emailid;
		//	this.EmailFrom = _emailfrom;
		//	this.Subject = _subject;
		//	this.Body = _body;
		//	this.Sent = _sent;
		//	this.Read = _read;
		//	this.Delete = _delete;
		//	this.MailDate = _maildate;
		//	this.Importance = _importance;
		//	this.Status = _status;
		//	this.MailCC = _mailcc;
		//	this.MailBCC = _mailbcc;
		//	this.ReplyType = _replytype;
		//	this.RefemailId = _refemailid;
		//	this.LogDateTime = _logdatetime;
		//	this.Dispatched = _dispatched;
		//	this.BodyFormat = _bodyformat;
		//	this.Delivered = _delivered;
		//	this.Tries = _tries;
		//	this.Exception = _exception;
		//}
	}
}
