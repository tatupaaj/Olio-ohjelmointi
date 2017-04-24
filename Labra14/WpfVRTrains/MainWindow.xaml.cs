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
using JAMK.IT;
using System.Threading;

namespace WpfVRTrains
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Train> trains = new List<Train>();
        string selectedstation = "";
        public MainWindow()
        {
            InitializeComponent();
            InitializeMyStuff();
        }
        #region METHODS
        void InitializeMyStuff()
        {
            //omat asetukset kootaan tänne
            //täytetään combobox asemilla
            GetStations();
        }
        private void GetStations()
        {
            List<Station> stations = new List<Station>();
            stations.Add(new Station("JY", "Jyväskylä"));
            stations.Add(new Station("HKI", "Helsinki"));
            stations.Add(new Station("TPE", "Tampere"));
            //todo kotitehtävä hakekaa asemapaikat apin jso:sta
            // kiinitetään stations kokoelma comboboxiin
            cbStations.DisplayMemberPath = "Name";
            cbStations.SelectedValuePath = "Code";
            cbStations.DataContext = stations;
        }
        private void GetTrainsAt()
        {
            try
            {
                //haetaan asemalta lähtevät junat
                string st = cbStations.SelectedValue.ToString();
                trains = JAMK.IT.TrainsVM.GetTrainsAt(st);
                dgTrains.DataContext = trains;
                tbMessage.Text = string.Format("Löytyi {0} junaa", trains.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void GetTrainsAtAsync()
        {
            //huom eri säikeessä ajettava metodi ei voi käsitellä GUIta
            // mutta muuttujia voi
            trains = JAMK.IT.TrainsVM.GetTrainsAt(selectedstation);
            UpdateUI();

        }
        private void UpdateUI()
        {
            Action action = () =>
            {
                dgTrains.DataContext = trains;
                tbMessage.Text = string.Format("Löytyi {0} junaa", trains.Count);
            };
            Dispatcher.BeginInvoke(action);
        }
        #endregion

        private void btnGetTrains_Click(object sender, RoutedEventArgs e)
        {
            if (cbStations.SelectedValue != null)
            {
                //V1: alkuperäinen
                tbMessage.Text = "Haetaan junat...";
                GetTrainsAt();
                //V2: asynkroninen omassa säikeessä
                selectedstation = cbStations.SelectedValue.ToString();
                new Thread(GetTrainsAtAsync).Start();
                tbMessage.Text = "haetaan junia, odota hetki...";
            }
        }
    }
}
