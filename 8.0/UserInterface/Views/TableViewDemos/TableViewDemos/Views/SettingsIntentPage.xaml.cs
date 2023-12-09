namespace TableViewDemos
{
	public partial class SettingsIntentPage : ContentPage
	{
		public SettingsIntentPage ()
		{
			InitializeComponent ();
		}

        void Button_Clicked(Object sender, EventArgs e)
        {
			pckr.ItemsSource = new List<String> { "AAA", "BBB", "CCC" };
        }
    }
}
