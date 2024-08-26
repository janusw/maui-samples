using ListViewDemos.ViewModels;

namespace ListViewDemos.Views;

public partial class VerticalListView : ContentView
{
	public VerticalListView()
	{
		InitializeComponent();
		BindingContext = new MonkeysViewModel();
	}
}
