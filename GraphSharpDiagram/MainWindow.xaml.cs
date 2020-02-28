using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using GraphSharp.Controls;
using GraphSharpDiagram.Models;
using GraphSharpDiagram.ViewModels;

namespace GraphSharpDiagram
{
    //public class PocGraphLayout : GraphLayout<PocVertex, PocEdge, PocGraph> { }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Module Mod;
        public MainWindow()
        {

            InitializeComponent();
            Initialize();            
        }



        #region Private Methods
        // Get data from SQLite database and determine number of facilities
        private void Initialize()
        {        

            Mod = new Module();
            Mod.GetModules("EROTON.db", "Modules");
            Facility fac = new Facility();

            fac.GetValue("EROTON.db", "Facilities");
            foreach (var modval in Mod.Modules)
            {
                Debug.WriteLine("FlowStation = {0} \t WellName = {1} \t Module = {2} \t Reservoir = {3} \t Field = {3} \t", modval.Flow_station, modval.WellName, modval.Module_, modval.Reservoir, modval.Field);
            }

            var uniqueFac = Mod.Modules.Select(o => o.Flow_station).Distinct().ToList();

            var mainViewModel = new MainViewModel();
           


            for (int i = 0; i < uniqueFac.Count(); i++)
            {
                mainViewModel.Items.Add(new ItemViewModel(uniqueFac[i], Mod, i));                
            }

            
            this.DataContext = mainViewModel;          
        }
    }
    #endregion
}