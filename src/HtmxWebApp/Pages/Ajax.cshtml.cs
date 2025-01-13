using Microsoft.AspNetCore.Mvc;

namespace HtmxWebApp.Pages;

public class AjaxModel : PageModel {
	public void OnGet() {
	}

	public IActionResult OnGetPartial() {
		return Partial("_Ajax");
	}
}
