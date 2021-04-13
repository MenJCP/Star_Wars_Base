﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Star_Wars_Base.Models;
using System.Windows.Input;
using Prism.Services;
using Prism.Navigation;
using Star_Wars_Base.Views;
using Star_Wars_Base.Constants;
using Prism.Commands;

namespace Star_Wars_Base.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.HomeTitle;
        public MenuOption Films { get; set; } = new MenuOption();
        public MenuOption People { get; set; } = new MenuOption();
        public MenuOption Planets { get; set; } = new MenuOption();
        public MenuOption Species { get; set; } = new MenuOption();
        public MenuOption Starships { get; set; } = new MenuOption();
        public MenuOption Vehicles { get; set; } = new MenuOption();

        public HomeViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

            Films.Title = "Films"; Films.Image = "films.png";
            People.Title = "People"; People.Image = "people.png";
            Planets.Title = "Planets"; Planets.Image = "planets.png";
            Species.Title = "Species"; Species.Image = "species.png";
            Starships.Title = "Starships"; Starships.Image = "starships.png";
            Vehicles.Title = "Vehicles"; Vehicles.Image = "vehicles.png";

        }

        public DelegateCommand FilmsCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("Films"));
        public DelegateCommand PeopleCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("People"));
        public DelegateCommand PlanetsCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("Planets"));
        public DelegateCommand SpeciesCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("Species"));
        public DelegateCommand StarshipsCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("Starships"));
        public DelegateCommand VehiclesCommand => new DelegateCommand(async () => await NavigationService.NavigateAsync("Vehicles"));

    }
}
