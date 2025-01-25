using System.Collections.Concurrent;

namespace HtmxWebApp.Models.ClickToEdit;

public class ContractRepository {
	// テスト用データ
	private static readonly ConcurrentDictionary<long, Contract> _contracts = GetInitialContracts();

	private static ConcurrentDictionary<long, Contract> GetInitialContracts() {
		var contracts = new Contract[] {
			new() {
				Id = 1,
				GivenName = "Taro",
				Surname = "Yamada",
				MailAddress = "taro@example.jp",
			},
		};
		return new ConcurrentDictionary<long, Contract>(contracts.ToDictionary(contract => contract.Id));
	}

	public Task<Contract?> GetContractByIdAsync(long id) {
		return Task.FromResult(
			_contracts.TryGetValue(id, out var contract)
				? contract
				: null);
	}

	public Task<bool> UpdateContractById(Contract contract) {
		if (!_contracts.ContainsKey(contract.Id)) {
			return Task.FromResult(false);
		}

		_contracts[contract.Id] = contract;

		return Task.FromResult(true);
	}
}
