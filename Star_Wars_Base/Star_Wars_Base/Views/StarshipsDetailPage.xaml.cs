﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Star_Wars_Base.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarshipsDetailPage : ContentPage
    {
        public StarshipsDetailPage(string name, string cost, string passengers, string speed, string crew)
        {
            InitializeComponent();
            LabelName.Text = name;
            LabelCost.Text = cost;
            LabelPassengers.Text = passengers;
            LabelSpeed.Text = speed;
            LabelCrew.Text = crew;
        }
    }
}