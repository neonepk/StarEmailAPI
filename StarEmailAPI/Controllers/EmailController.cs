using Microsoft.AspNetCore.Mvc;
using StarEmailAPI.EmailData;
using StarEmailAPI.Models;

namespace StarEmailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IEmailData _emailData;

        public EmailController(IEmailData emailData)
        {
            this._emailData = emailData;
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public IActionResult GetEmails() {
            return Ok(_emailData.GetEmails());
        }

        [HttpGet]
        [Route("api/[Controller]/{id}")]
        public IActionResult GetEmail(long emailId)
        {
            return Ok(_emailData.GetEmail(emailId));
        }

        [HttpPost]
        [Route("api/[Controller]")]
        public IActionResult AddEmail(Email email)
        {
            _emailData.AddEmail(email);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + email.EmailId, email);
        }

        [HttpPatch]
        [Route("api/[Controller]")]
        public IActionResult DeleteEmail(Email email)
        {
            return Ok(_emailData.UpdateEmail(email));
        }

        [HttpPatch]
        [Route("api/[Controller]/{id}")]
        public IActionResult UpdateEmail(Email email)
        {
            var emailObj = _emailData.GetEmail(email.EmailId);
            if (emailObj != null)
            {
                _emailData.UpdateEmail(email);
            }
            return Ok(email);
        }
    }
}
