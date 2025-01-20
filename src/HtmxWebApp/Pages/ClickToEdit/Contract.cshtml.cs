namespace HtmxWebApp.Pages.ClickToEdit;

public class ContractModel : PageModel {
	public bool IsEdit { get; set; } = false;

	public void OnGet() {
	}

	// todo:
	public void OnGetEdit() {
		IsEdit = true;
	}

	// - OnPost
}
