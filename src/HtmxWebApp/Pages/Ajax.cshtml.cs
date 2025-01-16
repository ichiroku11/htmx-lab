using Microsoft.AspNetCore.Mvc;

namespace HtmxWebApp.Pages;

// hx-postで送信されたリクエストに対して、AntiforgeryTokenの検証を無効化
[IgnoreAntiforgeryToken]
public class AjaxModel : PageModel {
	public void OnGet() {
	}

	private IActionResult PartialAjax() => Partial("_Ajax");

	public IActionResult OnGetPartial() => PartialAjax();

	public IActionResult OnPost() => PartialAjax();
}
