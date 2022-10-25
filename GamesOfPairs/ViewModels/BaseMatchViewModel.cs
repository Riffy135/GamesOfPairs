using Microsoft.Maui.Graphics;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GamesOfPairs.ViewModels;

public class BaseMatchViewModel : INotifyPropertyChanged
{


    bool isBusy = false;
    public bool IsBusy
    {
        get { return isBusy; }
        set { SetProperty(ref isBusy, value); }
    }

    string subtitle = string.Empty;

    public string SubTitle
    {

        get { return subtitle; }
        set { SetProperty(ref subtitle, value); }
    }

    string mtext1 = string.Empty;
    public string MText1
    {
        get { return mtext1; }
        set { SetProperty(ref mtext1, value); }
    }
    string mtext2 = string.Empty;

    public string MText2
    {
        get { return mtext2; }
        set { SetProperty(ref mtext2, value); }
    }

    string mtext3 = string.Empty;

    public string MText3
    {
        get { return mtext3; }
        set { SetProperty(ref mtext3, value); }
    }

    string mtext4 = string.Empty;

    public string MText4
    {
        get { return mtext4; }
        set { SetProperty(ref mtext4, value); }
    }

    string mtext5 = string.Empty;

    public string MText5
    {
        get { return mtext5; }
        set { SetProperty(ref mtext5, value); }
    }
    string mtext6 = string.Empty;

    public string MText6
    {
        get { return mtext6; }
        set { SetProperty(ref mtext6, value); }
    }
    string mtext7 = string.Empty;

    public string MText7
    {
        get { return mtext7; }
        set { SetProperty(ref mtext7, value); }
    }
    string mtext8 = string.Empty;

    public string MText8
    {
        get { return mtext8; }
        set { SetProperty(ref mtext8, value); }
    }
    string mtext9 = string.Empty;

    public string MText9
    {
        get { return mtext9; }
        set { SetProperty(ref mtext9, value); }
    }
    string mtext10 = string.Empty;
    public string MText10
    {
        get { return mtext10; }
        set { SetProperty(ref mtext10, value); }
    }

    public string mtext11 = string.Empty;
    public string MText11
    {
        get { return mtext11; }
        set { SetProperty(ref mtext11, value); }
    }

    private string mtext12 = string.Empty;
    public string MText12
    {
        get { return mtext12; }
        set { SetProperty(ref mtext12, value); }
    }

    string mtext13 = string.Empty;

    public string MText13
    {
        get { return mtext13; }
        set { SetProperty(ref mtext13, value); }
    }

    string mtext14 = string.Empty;

    public string MText14
    {
        get { return mtext14; }
        set { SetProperty(ref mtext14, value); }
    }

    string mtext15 = string.Empty;
    public string MText15
    {
        get { return mtext15; }
        set { SetProperty(ref mtext15, value); }
    }
    string mtext16 = string.Empty;
    public string MText16
    {
        get { return mtext16; }
        set { SetProperty(ref mtext16, value); }
    }
    bool mBEnabled1 = false;
    public bool MBEnabled1
    {
        get { return mBEnabled1; }
        set { SetProperty(ref mBEnabled1, value); }
    }
    Color mButtBckColor1 = Colors.Orange;
    public Color MButtBckColor1
    {
        get { return mButtBckColor1; }
        set
        {
            mButtBckColor1 = value;
            OnPropertyChanged(nameof(mButtBckColor1));
        }
    }
    Color mButtBckColor2 = Colors.White;
    public Color MButtBckColor2
    {
        get { return mButtBckColor2; }
        set
        {
            mButtBckColor2 = value;
            OnPropertyChanged(nameof(mButtBckColor2));
        }
    }

    Color mButtBckColor3 = Colors.White;
    public Color MButtBckColor3
    {
        get { return mButtBckColor3; }
        set
        {
            mButtBckColor3 = value;
            OnPropertyChanged(nameof(mButtBckColor3));
        }
    }

    Color mButtBckColor4 = Colors.DarkRed;
    public Color MButtBckColor4
    {
        get { return mButtBckColor4; }
        set
        {
            mButtBckColor4 = value;
            OnPropertyChanged(nameof(mButtBckColor4));
        }
    }

    Color mButtBckColor5 = Colors.White;
    public Color MButtBckColor5
    {
        get { return mButtBckColor5; }
        set
        {
            mButtBckColor5 = value;
            OnPropertyChanged(nameof(mButtBckColor5));
        }
    }

    Color mButtBckColor6 = Colors.White;
    public Color MButtBckColor6
    {
        get { return mButtBckColor6; }
        set
        {
            mButtBckColor6 = value;
            OnPropertyChanged(nameof(mButtBckColor6));
        }
    }

    Color mButtBckColor7 = Colors.White;
    public Color MButtBckColor7
    {
        get { return mButtBckColor7; }
        set
        {
            mButtBckColor7 = value;
            OnPropertyChanged(nameof(mButtBckColor7));
        }
    }

    Color mButtBckColor8 = Colors.White;
    public Color MButtBckColor8
    {
        get { return mButtBckColor8; }
        set
        {
            mButtBckColor8 = value;
            OnPropertyChanged(nameof(mButtBckColor8));
        }
    }

    Color mButtBckColor9 = Colors.White;
    public Color MButtBckColor9
    {
        get { return mButtBckColor9; }
        set
        {
            mButtBckColor9 = value;
            OnPropertyChanged(nameof(mButtBckColor9));
        }
    }

    Color mButtBckColor10 = Colors.White;
    public Color MButtBckColor10
    {
        get { return mButtBckColor10; }
        set
        {
            mButtBckColor10 = value;
            OnPropertyChanged(nameof(mButtBckColor10));
        }
    }

    Color mButtBckColor11 = Colors.White;
    public Color MButtBckColor11
    {
        get { return mButtBckColor11; }
        set
        {
            mButtBckColor11 = value;
            OnPropertyChanged(nameof(mButtBckColor11));
        }
    }

    Color mButtBckColor12 = Colors.White;
    public Color MButtBckColor12
    {
        get { return mButtBckColor12; }
        set
        {
            mButtBckColor12 = value;
            OnPropertyChanged(nameof(mButtBckColor12));
        }
    }

    Color mButtBckColor13 = Colors.White;
    public Color MButtBckColor13
    {
        get { return mButtBckColor13; }
        set
        {
            mButtBckColor13 = value;
            OnPropertyChanged(nameof(mButtBckColor13));
        }
    }

    Color mButtBckColor14 = Colors.White;
    public Color MButtBckColor14
    {
        get { return mButtBckColor14; }
        set
        {
            mButtBckColor14 = value;
            OnPropertyChanged(nameof(mButtBckColor14));
        }
    }

    Color mButtBckColor15 = Colors.White;
    public Color MButtBckColor15
    {
        get { return mButtBckColor15; }
        set
        {
            mButtBckColor15 = value;
            OnPropertyChanged(nameof(mButtBckColor15));
        }
    }
    Color mButtBckColor16 = Colors.White;
    public Color MButtBckColor16
    {
        get { return mButtBckColor16; }
        set
        {
            mButtBckColor16 = value;
            OnPropertyChanged(nameof(mButtBckColor16));
        }
    }


    string mId1 = string.Empty;

    public string MId1
    {
        get { return mId1; }
        set { SetProperty(ref mId1, value); }
    }
    string mId2 = string.Empty;

    public string MId2
    {
        get { return mId2; }
        set { SetProperty(ref mId2, value); }
    }

    string mId3 = string.Empty;

    public string MId3
    {
        get { return mId3; }
        set { SetProperty(ref mId3, value); }
    }

    string mId4 = string.Empty;

    public string MId4
    {
        get { return mId4; }
        set { SetProperty(ref mId4, value); }
    }

    string mId5 = string.Empty;

    public string MId5
    {
        get { return mId5; }
        set { SetProperty(ref mId5, value); }
    }

    string mId6 = string.Empty;

    public string MId6
    {
        get { return mId6; }
        set { SetProperty(ref mId6, value); }
    }

    string mId7 = string.Empty;

    public string MId7
    {
        get { return mId7; }
        set { SetProperty(ref mId7, value); }
    }

    string mId8 = string.Empty;

    public string MId8
    {
        get { return mId8; }
        set { SetProperty(ref mId8, value); }
    }

    string mId9 = string.Empty;

    public string MId9
    {
        get { return mId9; }
        set { SetProperty(ref mId9, value); }
    }

    string mId10 = string.Empty;

    public string MId10
    {
        get { return mId10; }
        set { SetProperty(ref mId10, value); }
    }

    string mId11 = string.Empty;

    public string MId11
    {
        get { return mId11; }
        set { SetProperty(ref mId11, value); }
    }

    string mId12 = string.Empty;

    public string MId12
    {
        get { return mId12; }
        set { SetProperty(ref mId12, value); }
    }

    string mId13 = string.Empty;

    public string MId13
    {
        get { return mId13; }
        set { SetProperty(ref mId13, value); }
    }

    string mId14 = string.Empty;

    public string MId14
    {
        get { return mId14; }
        set { SetProperty(ref mId14, value); }
    }

    string mId15 = string.Empty;

    public string MId15
    {
        get { return mId15; }
        set { SetProperty(ref mId15, value); }
    }

    string mId16 = string.Empty;

    public string MId16
    {
        get { return mId16; }
        set { SetProperty(ref mId16, value); }
    }

    bool isCorrectCntVisible = false;
    public bool IsCorrectCntVisible
    {
        get { return isCorrectCntVisible; }
        set { SetProperty(ref isCorrectCntVisible, value); }
    }

    bool isWrongCntVisible = false;
    public bool IsWrongCntVisible
    {
        get { return isWrongCntVisible; }
        set { SetProperty(ref isWrongCntVisible, value); }
    }


    protected bool SetProperty<T>(ref T backingStore, T value,
        [CallerMemberName] string propertyName = "",
        Action onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
            return false;

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }

    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        var changed = PropertyChanged;
        if (changed == null)
            return;

        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}
