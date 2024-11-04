using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		FirebaseApp.Create(new AppOptions()
		{
			Credential = GoogleCredential.FromFile("path/to/your/serviceAccountKey.json"),
		});

		// Other services
		services.AddControllersWithViews();
	}
}
