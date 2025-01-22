namespace HtmxWebApp.Models.ClickToEdit;

public class ContractRepository {
	// テスト用データ
	private static readonly Dictionary<long, Contract> _contracts = new Contract[] {
		new() {
			Id = 1,
			GivenName = "Taro",
			Surname = "Yamada",
			MailAddress = "taro@example.jp",
		},
	}.ToDictionary(contract => contract.Id);

	public Task<Contract?> GetContractByIdAsync(long id) {
		return Task.FromResult(
			_contracts.TryGetValue(id, out var contract)
				? contract
				: null);
	}
}
