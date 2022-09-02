using Foundation;

namespace Мероприятия;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => EventsViewModel.CreateMauiApp();
}
