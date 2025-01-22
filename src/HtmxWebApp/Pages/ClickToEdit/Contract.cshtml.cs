using HtmxWebApp.Models.ClickToEdit;
using Microsoft.AspNetCore.Mvc;

namespace HtmxWebApp.Pages.ClickToEdit;

public class ContractModel(ContractRepository repository) : PageModel {
	// テスト用のID
	private static readonly long _contractId = 1L;
	private readonly ContractRepository _repository = repository;

	public bool IsEdit { get; set; } = false;

	public Contract Contract { get; set; } = new Contract();

	public async Task<IActionResult> OnGetAsync() {
		var contract = await _repository.GetContractByIdAsync(_contractId);
		if (contract is null) {
			return NotFound();
		}

		Contract = contract;

		return Page();
	}

	public async Task<IActionResult> OnGetEditAsync() {
		IsEdit = true;

		var contract = await _repository.GetContractByIdAsync(_contractId);
		if (contract is null) {
			return NotFound();
		}

		Contract = contract;

		return Page();

	}

	// - OnPost
}
