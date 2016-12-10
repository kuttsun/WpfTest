using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApplication1.ViewModel
{
	/// <summary>
	/// ViewModelの親クラス
	/// プロパティが変更されたことを通知するため、INotifyPropertyChangedインターフェースを実装する
	/// プロパティ変更時OnPropertyChangedを呼び出す
	/// </summary>
	abstract class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// プロパティの変更をViewに通知
		/// </summary>
		/// <param name="propertyName">プロパティ名</param>
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
