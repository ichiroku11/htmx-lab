using Microsoft.AspNetCore.Mvc;

namespace HtmxWebApp.Pages;

// 動作確認のため
// GET以外で送信されたリクエストに対しては
// AntiforgeryTokenの検証を無効化する
[IgnoreAntiforgeryToken]
public class AjaxModel : PageModel {
	public void OnGet() {
	}

	private IActionResult PartialAjax() => Partial("_Ajax");

	public IActionResult OnGetPartial() => PartialAjax();

	public IActionResult OnPost() => PartialAjax();
	public IActionResult OnPut() => PartialAjax();
	public IActionResult OnPatch() => PartialAjax();
	public IActionResult OnDelete() => PartialAjax();
}
