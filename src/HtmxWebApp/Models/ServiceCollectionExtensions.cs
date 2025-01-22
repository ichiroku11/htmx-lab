using HtmxWebApp.Models.ClickToEdit;

namespace HtmxWebApp.Models;

public static class ServiceCollectionExtensions {
	public static IServiceCollection AddAppModels(this IServiceCollection services) {
		services.AddScoped<ContractRepository>();
		return services;
	}
}
