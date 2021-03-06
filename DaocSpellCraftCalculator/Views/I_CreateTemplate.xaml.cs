﻿using DaocSpellCraftCalculator.ViewModels;
using System;
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
using Telerik.Windows.Controls;

namespace DaocSpellCraftCalculator.Views
{
    /// <summary>
    /// Logique d'interaction pour I_CreateTemplate.xaml
    /// </summary>
    public partial class I_CreateTemplate : RadWindow
    {
        public I_CreateTemplate()
        {
            InitializeComponent();
            this.Owner = App.Current.MainWindow;
            
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Keyboard.Focus(Chp_Name);
            Chp_Name.SelectAll();
            var vm = (TemplateViewModel)this.DataContext;
            vm.RequestClose += (s, ev) => this.Close();
        }
    }
}
