using StarEmailAPI.Models;
using System.Collections.Generic;

namespace StarEmailAPI.EmailData 
{
    public class MockEmailData : IEmailData
    {
        Email IEmailData.AddEmail(Email email)
        {
            throw new System.NotImplementedException();
        }

        bool IEmailData.DeleteEmail(long emailId)
        {
            throw new System.NotImplementedException();
        }

        Email IEmailData.GetEmail(long emailId)
        {
            throw new System.NotImplementedException();
        }

        List<Email> IEmailData.GetEmails()
        {
            throw new System.NotImplementedException();
        }

        Email IEmailData.UpdateEmail(Email email)
        {
            throw new System.NotImplementedException();
        }
    }
}
