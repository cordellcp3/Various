using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace CustomControls.Converters
{
	public class IsLockedConverter : TextBox, IValueConverter
	{
		#region IValueConverter Member

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (Boolean) value ? IsReadOnly = true : IsReadOnly = false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
