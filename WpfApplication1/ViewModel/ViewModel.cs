using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApplication1.ViewModel.Command;

namespace WpfApplication1.ViewModel
{
	/// <summary>
	/// MainWindowに対するViewModel
	/// </summary>
	class MainWindowViewModel : ViewModelBase
	{
		// バインディング対象のプロパティ
		public DelegateCommand Button { get; set; }

		// バインディングされる値を保持するフィールド
		private string sampleText;

		// バインディング対象のプロパティ
		public string SampleText
		{
			get
			{
				return sampleText;
			}
			set
			{
				sampleText = value;

				// 変更をViewに通知する
				OnPropertyChanged(nameof(SampleText));

				// ボタンの無効表示に影響するので、CanExecuteChanged イベントを発行する
				Button?.RaiseCanExecuteChanged();

				// ラベルの値も連動させる
				SampleLabel = value;
			}
		}

		// バインディングされる値を保持するフィールド
		private string sampleLabel = "";

		// バインディング対象のプロパティ
		public string SampleLabel
		{
			get
			{
				return sampleLabel;
			}
			set
			{
				sampleLabel = value;

				// 変更をViewに通知する
				OnPropertyChanged(nameof(SampleLabel));
			}
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainWindowViewModel()
		{
			SampleText = "Sample";
			SampleLabel = "Sample";

			Button = new DelegateCommand(
				x => MessageBox.Show(SampleText),
				x => (SampleText == string.Empty ? false : true)
			);
		}
	}
}
