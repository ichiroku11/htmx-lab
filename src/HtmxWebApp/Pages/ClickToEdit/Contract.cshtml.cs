namespace HtmxWebApp.Pages.ClickToEdit;

public class Contract {
	public string Surname { get; set; } = "";
	public string GivenName { get; set; } = "";
	public string MailAddress { get; set; } = "";
}

public class ContractModel : PageModel {
	public bool IsEdit { get; set; } = false;

	public Contract Contract { get; set; } = new Contract();

	public void OnGet() {
		Contract.GivenName = "Taro";
		Contract.Surname = "Yamada";
		Contract.MailAddress = "taro@example.jp";
	}

	// todo:
	public void OnGetEdit() {
		IsEdit = true;
		Contract.GivenName = "Taro";
		Contract.Surname = "Yamada";
		Contract.MailAddress = "taro@example.jp";
	}

	// - OnPost
}
