namespace MauiApp1;

public class MainPageViewModel
{
    public List<WelcomePageCardViewModel> Items { get; }

    public MainPageViewModel()
    {
        Items = new List<WelcomePageCardViewModel>
        {
            new WelcomePageCardViewModel("Your New Mobile Study Companion",
                "Images.pc_and_app.svg",
                "Reinforce what you're learning via short mini-sessions while you're on the go or successfully reclaim some of that 'scrolling' time in the evening."),
            new WelcomePageCardViewModel("Review materials from a previous study session",
                "Images.study_session.svg",
                "Don't feel great about the last session you took? We'll serve up material to help you review and reinforce those concepts.")
        };
    }
}
