using System.Globalization;

namespace GamesOfPairs;

    public class  StringToColorConverter : IValueConverter
    {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                string valueAsString = value.ToString();
                //switch (valueAsString)
                //{
                //    case ("DarkGray"):
                //        {
                //            return Colors.DarkGray;
                //        }
                //    case ("Orange"):
                //        {
                //            return Colors.Orange;
                //        }
                //    case ("Green"):
                //        {
                //            return Colors.Green;
                //        }

                //    default:
                //        {
                            return Colors.DarkCyan;

                //        }
                //}
            }
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                return Binding.DoNothing;
            }
     }

    
