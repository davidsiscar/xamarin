﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace xamarin.Views
{
    public partial class MainView : ContentPage
    {
        int count = 1;
        public MainView()
        {
            InitializeComponent();
            MyButton.Clicked += (sender, args) =>
            {
                lblPrueba.Text = string.Format("{0} clicks!", count++);
            };
        }
    }
}
