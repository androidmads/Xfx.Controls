﻿using System.Diagnostics;
using Xamarin.Forms;

namespace Xfx.Controls.Example
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Email_OnFocused(object sender, FocusEventArgs e)
        {
            Debug.WriteLine("Email Focused");
        }

        private void Email_OnUnfocused(object sender, FocusEventArgs e)
        {
            Debug.WriteLine("Email Unfocused");
        }
    }
}