﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _519.Pages
{
	/// <summary>
	/// Логика взаимодействия для AuthPage.xaml
	/// </summary>
	public partial class AuthPage : Page
	{
		public AuthPage()
		{
			InitializeComponent();
		}

		private void TextBoxLogin_Changed(object sender, RoutedEventArgs e)
		{
			txtHintLogin.Visibility = Visibility.Visible;
			if (TextBoxLogin.Text.Length > 0)
			{
				txtHintLogin.Visibility = Visibility.Hidden;
			}
		}

		private void TextBoxPassword_Changed(object sender, RoutedEventArgs e)
		{
			txtHintPassword.Visibility = Visibility.Visible;
			if (TextBoxPassword.Password.Length > 0)
			{
				txtHintPassword.Visibility = Visibility.Hidden;
			}
		}
	}
}
