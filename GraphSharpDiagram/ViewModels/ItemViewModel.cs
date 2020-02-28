using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Input;
using System.Diagnostics;
using System.Collections.ObjectModel;
using GraphSharpDiagram.Views;
using GraphSharpDiagram.Models;
using System.Collections.Generic;

namespace GraphSharpDiagram.ViewModels
{
    public class ItemViewModel : ViewModelBase
    {
        #region Variables and collections
        //static int tabs = 1;
        //public GraphViewModel _graphViewModel { get; set; }
        public ObservableCollection<GraphView> Network { get; set; }

        private int selectedindex;

        #endregion

        #region Data
        private string layoutAlgorithmType;
        private PocGraph graph;
        private List<string> layoutAlgorithmTypes = new List<string>();
        private int _facility_ID;
        private Module _module;
        #endregion

        public ItemViewModel(string tabname, Module module, int FacNum)
        {
            TabName = tabname;
            mod = module;
            Facility_ID = FacNum;
        }
             private void AddTabItem(int t, List<string> FacList)
        {

            //for (int j = 0; j < t; j++)
            //{
            //    SelectedIndex = j;
            //}

        }

        #region Private Methods
        private PocEdge AddNewGraphEdge(PocVertex from, PocVertex to)
        {
            string edgeString = string.Format("{0}-{1} Connected", from.ID, to.ID);

            PocEdge newEdge = new PocEdge(edgeString, from, to);
            Graph.AddEdge(newEdge);
            return newEdge;
        }

        private void CreateGraph()
        {

            Graph = new PocGraph(true);

            //Module mod = _module;
            var uniqueFac = mod.Modules.Select(o => o.Flow_station).Distinct().ToList();
            //NumberOfFacs = uniqueFac.Count();

            //for (int j = 0; j < uniqueFac.Count; j++)
            //{
            List<string> _UniqueFS = new List<string>();
            List<string> _UniqueWN = new List<string>();
            List<string> _UniqueM = new List<string>();
            List<string> _UniqueDP = new List<string>();
            List<string> _UniqueRE = new List<string>();
            List<string> _UniqueF = new List<string>();

            List<string> _RawFS = new List<string>();
            List<string> _RawWN = new List<string>();
            List<string> _RawM = new List<string>();
            List<string> _RawDP = new List<string>();
            List<string> _RawRE = new List<string>();
            List<string> _RawF = new List<string>();

            Dictionary<string, PocVertex> _NewVerticesFlow_station = new Dictionary<string, PocVertex>();
            Dictionary<string, PocVertex> _NewVerticesWellName = new Dictionary<string, PocVertex>();
            Dictionary<string, PocVertex> _NewVerticesModule_ = new Dictionary<string, PocVertex>();
            Dictionary<string, PocVertex> _NewVerticesDrainage_Point = new Dictionary<string, PocVertex>();
            Dictionary<string, PocVertex> _NewVerticesReservoir = new Dictionary<string, PocVertex>();
            Dictionary<string, PocVertex> _NewVerticesField = new Dictionary<string, PocVertex>();

            Dictionary<string, string> _FS_WN = new Dictionary<string, string>();
            Dictionary<string, string> _WN_M = new Dictionary<string, string>();
            Dictionary<string, string> _M_DP = new Dictionary<string, string>();
            Dictionary<string, string> _DP_R = new Dictionary<string, string>();
            Dictionary<string, string> _R_F = new Dictionary<string, string>();

            Dictionary<string, PocVertex> _NewVerticesAM = new Dictionary<string, PocVertex>();


            #region Root Node(s) - All Levels
            foreach (var modval in mod.Modules)
            {
                if (modval.Flow_station.ToString() == uniqueFac[Facility_ID])
                {
                    if (!_NewVerticesFlow_station.ContainsKey(modval.Flow_station))
                    {
                        _NewVerticesFlow_station.Add(modval.Flow_station, new PocVertex(modval.Flow_station, 0)); //0
                        _UniqueFS.Add(modval.Flow_station);
                    }
                    _RawFS.Add(modval.Flow_station);
                    _RawWN.Add(modval.WellName);
                    _RawM.Add(modval.Module_);
                    _RawDP.Add(modval.Drainage_Point);
                    _RawRE.Add(modval.Reservoir);
                    _RawF.Add(modval.Field);

                    if (!_NewVerticesWellName.ContainsKey(modval.WellName))
                    {
                        _NewVerticesWellName.Add(modval.WellName, new PocVertex(modval.WellName, 1)); //1 

                        _UniqueWN.Add(modval.WellName);
                    }
                    if (!_NewVerticesModule_.ContainsKey(modval.Module_))
                    {
                        _NewVerticesModule_.Add(modval.Module_, new PocVertex(modval.Module_, 2)); //2
                        _UniqueM.Add(modval.Module_); //
                    }
                    if (!_NewVerticesDrainage_Point.ContainsKey(modval.Drainage_Point))
                    {
                        _NewVerticesDrainage_Point.Add(modval.Drainage_Point, new PocVertex(modval.Drainage_Point, 3)); //3
                        _UniqueDP.Add(modval.Drainage_Point); //                            
                    }
                    if (!_NewVerticesReservoir.ContainsKey(modval.Reservoir))
                    {
                        _NewVerticesReservoir.Add(modval.Reservoir, new PocVertex(modval.Reservoir, 4)); //4                          
                        _UniqueRE.Add(modval.Reservoir);

                    }
                    if (!_NewVerticesField.ContainsKey(modval.Field))
                    {
                        _NewVerticesField.Add(modval.Field, new PocVertex(modval.Field, 5)); //5                           
                        _UniqueF.Add(modval.Field);
                    }
                }

            }
            #endregion
            int width_ = _NewVerticesModule_.Count;
            foreach (KeyValuePair<string, PocVertex> vertex in _NewVerticesFlow_station)
                Graph.AddVertex(vertex.Value);
            foreach (KeyValuePair<string, PocVertex> vertex in _NewVerticesWellName)
                Graph.AddVertex(vertex.Value);
            foreach (KeyValuePair<string, PocVertex> vertex in _NewVerticesModule_)
                Graph.AddVertex(vertex.Value);
            foreach (KeyValuePair<string, PocVertex> vertex in _NewVerticesDrainage_Point)
                Graph.AddVertex(vertex.Value);
            foreach (KeyValuePair<string, PocVertex> vertex in _NewVerticesReservoir)
                Graph.AddVertex(vertex.Value);
            foreach (KeyValuePair<string, PocVertex> vertex in _NewVerticesField)
                Graph.AddVertex(vertex.Value);
            for (int a = 0; a < _RawWN.Count(); a++)
            {
                AddNewGraphEdge(_NewVerticesFlow_station[_RawFS[a]], _NewVerticesWellName[_RawWN[a]]);
                AddNewGraphEdge(_NewVerticesWellName[_RawWN[a]], _NewVerticesModule_[_RawM[a]]);
                AddNewGraphEdge(_NewVerticesModule_[_RawM[a]], _NewVerticesDrainage_Point[_RawDP[a]]);
                AddNewGraphEdge(_NewVerticesDrainage_Point[_RawDP[a]], _NewVerticesReservoir[_RawRE[a]]);
                AddNewGraphEdge(_NewVerticesReservoir[_RawRE[a]], _NewVerticesField[_RawF[a]]);
            }

            //Add Layout Algorithm Types
            layoutAlgorithmTypes.Add("BoundedFR");
            layoutAlgorithmTypes.Add("Circular");
            layoutAlgorithmTypes.Add("CompoundFDP");
            layoutAlgorithmTypes.Add("EfficientSugiyama");
            layoutAlgorithmTypes.Add("FR");
            layoutAlgorithmTypes.Add("ISOM");
            layoutAlgorithmTypes.Add("KK");
            layoutAlgorithmTypes.Add("LinLog");
            layoutAlgorithmTypes.Add("Tree");
            //Pick a default Layout Algorithm Type
            LayoutAlgorithmType = "Tree";
            //}
        }
        private void ActionMethod()
        {
            Console.WriteLine("Parent method executed");
        }
        #endregion

        #region Public Properties


        public string TabName
        {
            get;
            private set;
        }

        public Module mod
        {
            get { return _module; }
            set { _module = value; }
        }
        public int Facility_ID
        {
            get { return _facility_ID; }
            set
            {
                _facility_ID = value;
                //NotifyPropertyChanged("Facility_ID");
                CreateGraph();
            }
        }

        public List<String> LayoutAlgorithmTypes
        {
            get { return layoutAlgorithmTypes; }
        }

        public string LayoutAlgorithmType
        {
            get { return layoutAlgorithmType; }
            set
            {
                layoutAlgorithmType = value;
                OnPropertyChanged("LayoutAlgorithmType");
            }
        }
        public PocGraph Graph
        {
            get { return graph; }
            set
            {
                graph = value;
                OnPropertyChanged("Graph");
            }
        }
        #endregion 

    }
}