using StarEmailAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarEmailAPI.EmailData
{
    public class PGEmailData : IEmailData
    {
        private EmailContext _emailContext;
        public PGEmailData(EmailContext emailContext)
        {
            _emailContext = emailContext;
        }

        public Email AddEmail(Email email)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmail(long emailId)
        {
            throw new NotImplementedException();
        }

        public Email GetEmail(long emailId)
        {
           var result = _emailContext.Emails.Find(emailId);
            return result;
        }

        public List<Email> GetEmails()
        {
            return _emailContext.Emails.ToList();
        }

        public Email UpdateEmail(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
