namespace MauiApp1;

public class WelcomePageCardViewModel
{
    public WelcomePageCardViewModel(string title, string image, string contentText)
    {
        Title = title;
        Image = image;
        ContentText = contentText;
    }

    public string Title { get; }
    public string Image { get; }
    public string ContentText { get; }
}
