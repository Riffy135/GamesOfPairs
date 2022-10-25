using GamesOfPairs.Views;

namespace GamesOfPairs;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(MatchPairsPage), typeof(MatchPairsPage));

    }
}
