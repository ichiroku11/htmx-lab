using System.ComponentModel.DataAnnotations;

namespace HtmxWebApp.Models.ClickToEdit;

public class Contract {
	public long Id { get; set; }

	[Required]
	public string Surname { get; set; } = "";

	[Required]
	public string GivenName { get; set; } = "";

	[Required]
	public string MailAddress { get; set; } = "";
}
