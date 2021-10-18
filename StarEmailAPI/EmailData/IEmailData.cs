using StarEmailAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarEmailAPI.EmailData
{
    public interface IEmailData
    {
        /// <summary>
        /// Return single email record
        /// </summary>
        /// <param name="emailid"></param>
        /// <returns></returns>
        Email GetEmail(long emailId);

        /// <summary>
        /// Get all emails 
        /// </summary>
        /// <returns></returns>
        List<Email> GetEmails();

        /// <summary>
        /// Add a new record
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Email AddEmail(Email email);

        /// <summary>
        /// Delete an email record /soft delete
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        bool DeleteEmail(long emailId);
        
        /// <summary>
        /// Update email record
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Email UpdateEmail(Email email);

    }
}
