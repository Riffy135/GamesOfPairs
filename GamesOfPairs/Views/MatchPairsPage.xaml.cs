using GamesOfPairs.ViewModels;

namespace GamesOfPairs.Views;

public partial class MatchPairsPage : ContentPage
{
        MatchPairsViewModel _viewModel;

        public MatchPairsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MatchPairsViewModel();

        }
    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

}