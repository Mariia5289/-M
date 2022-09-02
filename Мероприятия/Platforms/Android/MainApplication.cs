using Android.App;
using Android.Runtime;

namespace Мероприятия;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => EventsViewModel.CreateMauiApp();
}
