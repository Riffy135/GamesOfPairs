using GamesOfPairs.Views;
using GamesOfPairs;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace GamesOfPairs.ViewModels;

public class MatchPairsViewModel : BaseMatchViewModel
{
    public MatchPairsPage matchPairsPage;

    public Command RestCommand { get; private set; }

    public Command PageAppearCommand { get; set; }
    //public MatchPairsViewModel(MatchPairsPage matchPairsPage)
    //{
    //    this.matchPairsPage = matchPairsPage;
    //    PageAppearCommand = new Command(OnAppearing);
    //}

    public class MatchVars
    {
            public static int ExcludePhrasesCount = 0;
            public static int[] ExclPhrasesNumbers = new int[102];
            public static int ExcludeCellCount;
            public static int[] ExclCellNumbers = new int[16];

            public static int CorrectCount = 0;
            public static int WrongCount = 0;

        }

        readonly List<(int, string Desc, string Meang)> MatchItems = new List<(int, string Desc, string Meang)>();
        public int PhraseMin = 0;
        public int PhraseMax = 44;
        public int CellMin = 1;
        public int CellMax = 17;
        int RandNo = 0;
        public bool FirstTime = true;
        public bool DataLoaded = false;

        public ICommand ResetCommand { private set; get; }

        public MatchPairsViewModel()
        {
            ResetCommand = new Command(() => ResetCellsData());

            LoadData();
        }

        void LoadData()
        {

            SubTitle = "Countries and Capitals";
            int ItemNo = 0;
            MatchItems.Add((++ItemNo, "Afghanistan", "Kabul"));
            MatchItems.Add((++ItemNo, "Albania", "Tirana"));
            MatchItems.Add((++ItemNo, "Algeria", "Algiers"));
            MatchItems.Add((++ItemNo, "Andorra", "Andorra la Vella"));
            MatchItems.Add((++ItemNo, "Angola", "Luanda"));
            MatchItems.Add((++ItemNo, "Antigua and Barbuda", "Saint John's"));
            MatchItems.Add((++ItemNo, "Argentina", "Buenos Aires"));
            MatchItems.Add((++ItemNo, "Armenia", "Yerevan"));
            MatchItems.Add((++ItemNo, "Australia", "Canberra"));
            MatchItems.Add((++ItemNo, "Austria", "Vienna"));
            MatchItems.Add((++ItemNo, "Azerbaijan", "Baku"));
            MatchItems.Add((++ItemNo, "Bahamas", "Nassau"));
            MatchItems.Add((++ItemNo, "Bahrain", "Manama"));
            MatchItems.Add((++ItemNo, "Bangladesh", "Dhaka"));
            MatchItems.Add((++ItemNo, "Barbados", "Bridgetown"));
            MatchItems.Add((++ItemNo, "Belarus", "Minsk"));
            MatchItems.Add((++ItemNo, "Belgium", "Brussels"));
            MatchItems.Add((++ItemNo, "Belize", "Belmopan"));
            MatchItems.Add((++ItemNo, "Benin", "Porto-Novo"));
            MatchItems.Add((++ItemNo, "Bhutan", "Thimphu"));
            MatchItems.Add((++ItemNo, "Bosnia and Herzegovina", "Sarajevo"));
            MatchItems.Add((++ItemNo, "Botswana", "Gaborone"));
            MatchItems.Add((++ItemNo, "Brazil", "Brasilia"));
            MatchItems.Add((++ItemNo, "Brunei", "Bandar Seri Begawan"));
            MatchItems.Add((++ItemNo, "Bulgaria", "Sofia"));
            MatchItems.Add((++ItemNo, "Burkina Faso", "Ouagadougou"));
            MatchItems.Add((++ItemNo, "Burundi", "Gitega"));
            MatchItems.Add((++ItemNo, "Cabo Verde", "Praia"));
            MatchItems.Add((++ItemNo, "Cambodia", "Phnom Penh"));
            MatchItems.Add((++ItemNo, "Cameroon", "Yaounde"));
            MatchItems.Add((++ItemNo, "Canada", "Ottawa"));
            MatchItems.Add((++ItemNo, "Central African Republic", "Bangui"));
            MatchItems.Add((++ItemNo, "Chad", "N'Djamena"));
            MatchItems.Add((++ItemNo, "Chile", "Santiago"));
            MatchItems.Add((++ItemNo, "China", "Beijing"));
            MatchItems.Add((++ItemNo, "Colombia", "Bogotá"));
            MatchItems.Add((++ItemNo, "Comoros", "Moroni"));
            MatchItems.Add((++ItemNo, "Congo Democratic Republic of the", "Kinshasa"));
            MatchItems.Add((++ItemNo, "Congo Republic of the", "Brazzaville"));
            MatchItems.Add((++ItemNo, "Costa Rica", "San Jose"));
            MatchItems.Add((++ItemNo, "Cote d'Ivoire", "Yamoussoukro"));
            MatchItems.Add((++ItemNo, "Croatia", "Zagreb"));
            MatchItems.Add((++ItemNo, "Cuba", "Havana"));
            MatchItems.Add((++ItemNo, "Cyprus", "Nicosia"));
            MatchItems.Add((++ItemNo, "Czechia", "Prague"));

            MatchVars.CorrectCount = 0;
            MatchVars.WrongCount = 0;
            RestCommand = new Command(() => ResetCellsData());

            ResetCellsData();
        }


    public void OnAppearing()
    {
        //PageAppearCommand = new Command(OnAppearing);
        //ResetCellsData();
        IsBusy = true;
    }
    public void SelectMData()
        {
            MatchVars.ExcludePhrasesCount = 0;
            MatchVars.ExclPhrasesNumbers = new int[44];
            MatchVars.ExcludeCellCount = 0;
            MatchVars.ExclCellNumbers = new int[16];

            MatchVars.CorrectCount = 0;
            MatchVars.WrongCount = 0;

            IsCorrectCntVisible = false;
            IsWrongCntVisible = false;

            int y;
            int randomNumber;
            string Text1;
            int CellMatchNo = 0;

            for (y = 0; y < 8; y++)
            {
                RandNo = GetPhrasesRandomNumber(PhraseMin, PhraseMax);

                Text1 = MatchItems[RandNo].Desc;
                randomNumber = GetCellsRandomNumber(CellMin, CellMax);
                PopulateCell(randomNumber, Text1, ++CellMatchNo);
                Text1 = MatchItems[RandNo].Meang;
                randomNumber = GetCellsRandomNumber(CellMin, CellMax);
                PopulateCell(randomNumber, Text1, CellMatchNo);
            }
        }

        public void PopulateCell(int randomNumber, string Text1, int CellMatchNo)
        {
            switch (randomNumber)
            {
                case 1:

                    MText1 = Text1;
                    MButtBckColor1 = Colors.DarkCyan;
                    MId1 = CellMatchNo.ToString();
                    break;
                case 2:
                    MText2 = Text1;
                    MButtBckColor2 = Colors.DarkCyan;
                    MId2 = CellMatchNo.ToString();
                    break;
                case 3:
                    MText3 = Text1;
                    MButtBckColor3 = Colors.DarkCyan;
                    MId3 = CellMatchNo.ToString();
                    break;
                case 4:
                    MText4 = Text1;
                    MButtBckColor4 = Colors.DarkCyan;
                    MId4 = CellMatchNo.ToString();
                    break;
                case 5:
                    MText5 = Text1;
                    MButtBckColor5 = Colors.DarkCyan;
                    MId5 = CellMatchNo.ToString();
                    break;
                case 6:
                    MText6 = Text1;
                    MButtBckColor6 = Colors.DarkCyan;
                    MId6 = CellMatchNo.ToString();
                    break;
                case 7:
                    MText7 = Text1;
                    MButtBckColor7 = Colors.DarkCyan;
                    MId7 = CellMatchNo.ToString();
                    break;
                case 8:
                    MText8 = Text1;
                    MButtBckColor8 = Colors.DarkCyan;
                    MId8 = CellMatchNo.ToString();
                    break;
                case 9:
                    MText9 = Text1;
                    MButtBckColor9 = Colors.DarkCyan;
                    MId9 = CellMatchNo.ToString();
                    break;
                case 10:
                    MText10 = Text1;
                    MButtBckColor10 = Colors.DarkCyan;
                    MId10 = CellMatchNo.ToString();
                    break;
                case 11:
                    MText11 = Text1;
                    MButtBckColor11 = Colors.DarkCyan;
                    MId11 = CellMatchNo.ToString();
                    break;
                case 12:
                    MText12 = Text1;
                    MButtBckColor12 = Colors.DarkCyan;
                    MId12 = CellMatchNo.ToString();
                    break;
                case 13:
                    MText13 = Text1;
                    MButtBckColor13 = Colors.DarkCyan;
                    MId13 = CellMatchNo.ToString();
                    break;
                case 14:
                    MText14 = Text1;
                    MButtBckColor14 = Colors.DarkCyan;
                    MId14 = CellMatchNo.ToString();
                    break;
                case 15:
                    MText15 = Text1;
                    MButtBckColor15 = Colors.DarkCyan;
                    MId15 = CellMatchNo.ToString();
                    break;
                case 16:
                    MText16 = Text1;
                    MButtBckColor16 = Colors.DarkCyan;
                    MId16 = CellMatchNo.ToString();
                    break;
                default:
                    break;
            }
        }
        public ICommand ChangeColorMCommand { private set; get; }

    public void ResetCellsData()
        {
            SelectMData();

            MButtBckColor1 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor2 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor3 = Colors.BlueViolet;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor4 = Colors.Blue;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor5 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor6 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor7 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor8 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor9 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor10 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor11 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor12 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor13 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor14 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor15 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
            MButtBckColor16 = Colors.DarkCyan;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));
        }

        public static int GetPhrasesRandomNumber(int PhraseMin, int PhraseMax)
        {
            Random randomGenerator = new Random();
            int currentNumber = randomGenerator.Next(PhraseMin, PhraseMax);

            while (MatchVars.ExclPhrasesNumbers.Contains(currentNumber))
            {
                currentNumber = randomGenerator.Next(PhraseMin, PhraseMax);
            }
            MatchVars.ExclPhrasesNumbers[MatchVars.ExcludePhrasesCount] = currentNumber;
            MatchVars.ExcludePhrasesCount++;

            return currentNumber;
        }

        public static int GetCellsRandomNumber(int CellMin, int CellMax)
        {
            Random randomGenerator = new Random();
            int currentNumber = randomGenerator.Next(CellMin, CellMax);

            while (MatchVars.ExclCellNumbers.Contains(currentNumber))
            {
                currentNumber = randomGenerator.Next(CellMin, CellMax);
            }
            MatchVars.ExclCellNumbers[MatchVars.ExcludeCellCount] = currentNumber;
            MatchVars.ExcludeCellCount++;

            return currentNumber;
        }
        private void ChangeClickEvne(object sender)
        {
            var ButtClicked = sender as Button;
            ChangeColorMCommand = new Command((o) => ChangeClickEvne(o));

            MButton_Clicked(ButtClicked);
        }

        string PrevId;
        int CellCount = 0;
        private Button PreviousButton = null;
        private Button FirstButton = null;

        private void MButton_Clicked(object sender)
        {
            CellCount++;
            string ButtId = (sender as Button).ClassId;
            if (CellCount == 1)
            {
                (sender as Button).BackgroundColor = Colors.Gray;
                //(sender as Button).IsEnabled = false;
                FirstButton = (Button)sender;
            }
            else
            {
                if (ButtId == PrevId)
                {
                    PreviousButton.BackgroundColor = Colors.Green;
                    (sender as Button).BackgroundColor = Colors.Green;
                    PreviousButton.IsEnabled = false;
                    (sender as Button).IsEnabled = false;
                    ++MatchVars.CorrectCount;
                    //CorrectCntName.Text = MatchVars.CorrectCount.ToString();

                }
                else
                {
                    FirstButton.BackgroundColor = Colors.DarkCyan;
                    //FirstButton.IsEnabled = true;
                    ++MatchVars.WrongCount;
                    //WrongCntName.Text = MatchVars.WrongCount.ToString();
                    Application.Current.MainPage.DisplayAlert("Sorry - Wrong Match", "Please try again", "Ok");
                }
            }
            PrevId = ButtId;


            PreviousButton = (Button)sender;
            if (CellCount == 2)
            {
                if (MatchVars.CorrectCount > 0)
                {

                    //CorrectCntName.IsVisible = true;
                }
                if (MatchVars.WrongCount > 0)
                {

                    //WrongCntName.IsVisible = true;
                }
                CellCount = 0;
            }
        }
}