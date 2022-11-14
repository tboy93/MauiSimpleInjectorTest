using static MauiSimpleInjectorTest.MauiProgram;

namespace MauiSimpleInjectorTest;

public partial class MainPage : ContentPage
{
	private readonly ISampleService service;

	public MainPage(ISampleService service)
	{
		InitializeComponent();
		this.service = service;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
		CounterBtn.Text = service.GetSampleData();

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

