namespace PopupTest;

using CommunityToolkit.Maui.Views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        var popup = new Popup
        {
            Content = new VerticalStackLayout
            {
                Children =
        {
            new Label
            {
                Text = "This is a very important message!"
            }
        }
            }
        };

        this.ShowPopup(popup);

		;
	}

	
}

