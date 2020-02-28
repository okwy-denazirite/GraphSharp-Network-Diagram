using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using GraphSharpDiagram.Utils;

namespace GraphSharpDiagram.Models
{
    public class Module
    {
        public List<Module> Modules { get; set; }

        #region properties
        #region Resource Class
        private string _Resource_Class;

        public string Resource_Class
        {
            get { return _Resource_Class; }
            set { _Resource_Class = value; }
        }
        #endregion       
        #region Manifold
        private string manifold;

        public string Manifold
        {
            get { return manifold; }
            set { manifold = value; }
        }
        #endregion
        #region Flow station
        private string _Flow_station;

        public string Flow_station
        {
            get { return _Flow_station; }
            set { _Flow_station = value; }
        }
        #endregion

        #region TRANCHE
        private string _TRANCHE;

        public string TRANCHE
        {
            get { return _TRANCHE; }
            set { _TRANCHE = value; }
        }
        #endregion
        #region Module
        private string _Module;

        public string Module_
        {
            get { return _Module; }
            set { _Module = value; }
        }
        #endregion
        #region Drainage Point
        private string _Drainage_Point;

        public string Drainage_Point
        {
            get { return _Drainage_Point; }
            set { _Drainage_Point = value; }
        }
        #endregion

        #region WellName
        private string _WellName;

        public string WellName
        {
            get { return _WellName; }
            set { _WellName = value; }
        }
        #endregion
        #region Reservoir
        private string _Reservoir;

        public string Reservoir
        {
            get { return _Reservoir; }
            set { _Reservoir = value; }
        }
        #endregion
        #region Field
        private string _Field;

        public string Field
        {
            get { return _Field; }
            set { _Field = value; }
        }
        #endregion
        #region Asset Team
        private string _Asset_Team;

        public string Asset_Team
        {
            get { return _Asset_Team; }
            set { _Asset_Team = value; }
        }
        #endregion

        #region On-stream Date-3P/3C
        private DateTime _On_stream_Date_3P_3C;

        public DateTime On_stream_Date_3P_3C
        {
            get { return _On_stream_Date_3P_3C; }
            set { _On_stream_Date_3P_3C = value; }
        }
        #endregion
        #region On-stream Date-2P/2C
        private DateTime _On_stream_Date_2P_2C;

        public DateTime On_stream_Date_2P_2C
        {
            get { return _On_stream_Date_2P_2C; }
            set { _On_stream_Date_2P_2C = value; }
        }
        #endregion
        #region On-stream Date-1P/1C
        private DateTime _On_stream_Date_1P_1C;

        public DateTime On_stream_Date_1P_1C
        {
            get { return _On_stream_Date_1P_1C; }
            set { _On_stream_Date_1P_1C = value; }
        }
        #endregion

        #region GOR inclination rate
        private double alphaGOR;

        public double AlphaGOR
        {
            get { return alphaGOR; }
            set { alphaGOR = value; }
        }
        #endregion
        #region WC inclination rate
        private double alphaWC;

        public double AlphaWC
        {
            get { return alphaWC; }
            set { alphaWC = value; }
        }
        #endregion
        #region Weight Fraction BSW/WGR
        private double _Weight_Fraction_BSW_WGR;

        public double Weight_Fraction_BSW_WGR
        {
            get { return _Weight_Fraction_BSW_WGR; }
            set { _Weight_Fraction_BSW_WGR = value; }
        }
        #endregion

        #region Decline Oil Rate (/year)
        private double _Decline_Oil_Rate_year;

        public double Decline_Oil_Rate_year
        {
            get { return _Decline_Oil_Rate_year; }
            set { _Decline_Oil_Rate_year = value; }
        }
        #endregion
        #region Weight Fraction GOR/CGR
        private double _Weight_Fraction_GOR_CGR;

        public double Weight_Fraction_GOR_CGR
        {
            get { return _Weight_Fraction_GOR_CGR; }
            set { _Weight_Fraction_GOR_CGR = value; }
        }
        #endregion
        #region Cummulative oil produced
        private double nP;

        public double NP
        {
            get { return nP; }
            set { nP = value; }
        }
        #endregion

        #region Abandonment GOR 3P/3C
        private double _Abandonment_GOR_3P_3C;

        public double Abandonment_GOR_3P_3C
        {
            get { return _Abandonment_GOR_3P_3C; }
            set { _Abandonment_GOR_3P_3C = value; }
        }
        #endregion
        #region Abandonment GOR 2P/2C
        private double _Abandonment_GOR_2P_2C;

        public double Abandonment_GOR_2P_2C
        {
            get { return _Abandonment_GOR_2P_2C; }
            set { _Abandonment_GOR_2P_2C = value; }
        }
        #endregion
        #region Abandonment GOR 1P/1C
        private double _Abandonment_GOR_1P_1C;

        public double Abandonment_GOR_1P_1C
        {
            get { return _Abandonment_GOR_1P_1C; }
            set { _Abandonment_GOR_1P_1C = value; }
        }
        #endregion
        #region Initial GOR
        private double gORi;

        public double GORi
        {
            get { return gORi; }
            set { gORi = value; }
        }
        #endregion

        #region Abandonment BSW 3P/3C
        private double _Abandonment_BSW_3P_3C;

        public double Abandonment_BSW_3P_3C
        {
            get { return _Abandonment_BSW_3P_3C; }
            set { _Abandonment_BSW_3P_3C = value; }
        }
        #endregion
        #region Abandonment BSW 2P/2C
        private double _Abandonment_BSW_2P_2C;

        public double Abandonment_BSW_2P_2C
        {
            get { return _Abandonment_BSW_2P_2C; }
            set { _Abandonment_BSW_2P_2C = value; }
        }
        #endregion
        #region Abandonment BSW 1P/1C
        private double _Abandonment_BSW_1P_1C;

        public double Abandonment_BSW_1P_1C
        {
            get { return _Abandonment_BSW_1P_1C; }
            set { _Abandonment_BSW_1P_1C = value; }
        }
        #endregion
        #region Initial Plateau [Oil/Gas]
        private double plateau_OilGas;

        public double Plateau_OilGas
        {
            get { return plateau_OilGas; }
            set { plateau_OilGas = value; }
        }
        #endregion
        #region Initial BSW
        private double _BSWi;

        public double BSWi
        {
            get { return _BSWi; }
            set { _BSWi = value; }
        }
        #endregion

        #region Abandonment GOR
        private double gORaband;

        public double GORaband
        {
            get { return gORaband; }
            set { gORaband = value; }
        }
        #endregion

        #region Initial Oil Rate 3P/3C
        private double _Initial_Oil_Rate_3P_3C;

        public double Initial_Oil_Rate_3P_3C
        {
            get { return _Initial_Oil_Rate_3P_3C; }
            set { _Initial_Oil_Rate_3P_3C = value; }
        }
        #endregion
        #region Initial Oil Rate 2P/2C
        private double _Initial_Oil_Rate_2P_2C;

        public double Initial_Oil_Rate_2P_2C
        {
            get { return _Initial_Oil_Rate_2P_2C; }
            set { _Initial_Oil_Rate_2P_2C = value; }
        }
        #endregion
        #region Initial Oil Rate 1P/1C
        private double _Initial_Oil_Rate_1P_1C;

        public double Initial_Oil_Rate_1P_1C
        {
            get { return _Initial_Oil_Rate_1P_1C; }
            set { _Initial_Oil_Rate_1P_1C = value; }
        }
        #endregion
        #region Initial OilRate
        private double _qoi;

        public double qoi
        {
            get { return _qoi; }
            set { _qoi = value; }
        }
        #endregion

        #region Abandonment Oil Rate 3P/3C
        private double _Abandonment_Oil_Rate_3P_3C;

        public double Abandonment_Oil_Rate_3P_3C
        {
            get { return _Abandonment_Oil_Rate_3P_3C; }
            set { _Abandonment_Oil_Rate_3P_3C = value; }
        }
        #endregion
        #region Abandonment Oil Rate 2P/2C
        private double _Abandonment_Oil_Rate_2P_2C;

        public double Abandonment_Oil_Rate_2P_2C
        {
            get { return _Abandonment_Oil_Rate_2P_2C; }
            set { _Abandonment_Oil_Rate_2P_2C = value; }
        }
        #endregion
        #region Abandonment Oil Rate 1P/1C
        private double _Abandonment_Oil_Rate_1P_1C;

        public double Abandonment_Oil_Rate_1P_1C
        {
            get { return _Abandonment_Oil_Rate_1P_1C; }
            set { _Abandonment_Oil_Rate_1P_1C = value; }
        }
        #endregion
        #region Abandonment OilRate
        private double _qoaband;

        public double qoabandoi
        {
            get { return _qoaband; }
            set { _qoaband = value; }
        }
        #endregion

        #region Ultimate Oil Recovery_2P_2C
        private double _URo2P_2C;

        public double URo2P_2C
        {
            get { return _URo2P_2C; }
            set { _URo2P_2C = value; }
        }
        #endregion
        #region Ultimate Oil Recovery_3P_3C
        private double _URo3P_3C;

        public double URo3P_3C
        {
            get { return _URo3P_3C; }
            set { _URo3P_3C = value; }
        }
        #endregion
        #region Ultimate Oil Recovery_1P_1C
        private double _URo1P_1C;

        public double URo1P_1C
        {
            get { return _URo2P_2C; }
            set { _URo2P_2C = value; }
        }
        #endregion
        #region Ultimate Oil Recovery
        private double uR;

        public double UR
        {
            get { return uR; }
            set { uR = value; }
        }
        #endregion


        #region Percentage Deferment
        private double _Percentage_Deferment;

        public double Percentage_Deferment
        {
            get { return _Percentage_Deferment; }
            set { _Percentage_Deferment = value; }
        }
        #endregion
        #region Decline Deferment Factor
        private double _Decline_Deferment_Factor;

        public double Decline_Deferment_Factor
        {
            get { return _Decline_Deferment_Factor; }
            set { _Decline_Deferment_Factor = value; }
        }
        #endregion

        #region Water Priority Factor
        private double _Water_Priority_Factor;

        public double Water_Priority_Factor
        {
            get { return _Water_Priority_Factor; }
            set { _Water_Priority_Factor = value; }
        }
        #endregion
        #region Oil Priority Factor
        private double _Oil_Priority_Factor;

        public double Oil_Priority_Factor
        {
            get { return _Oil_Priority_Factor; }
            set { _Oil_Priority_Factor = value; }
        }
        #endregion
        #region Decline Exponent
        private double _DeclineExponent;

        public double DeclineExponent
        {
            get { return _DeclineExponent; }
            set { _DeclineExponent = value; }
        }
        #endregion
        #region Water Fraction Inclination Type
        private string _Water_Fraction_Inclination_Type;

        public string Water_Fraction_Inclination_Type
        {
            get { return _Water_Fraction_Inclination_Type; }
            set { _Water_Fraction_Inclination_Type = value; }
        }
        #endregion

        #region Water Cut Inclination Rate
        private double _Water_Cut_Inclination_Rate;

        public double Water_Cut_Inclination_Rate
        {
            get { return _Water_Cut_Inclination_Rate; }
            set { _Water_Cut_Inclination_Rate = value; }
        }
        #endregion
        #region Gas Fraction Inclination Type
        private string _Gas_Fraction_Inclination_Type;

        public string Gas_Fraction_Inclination_Type
        {
            get { return _Gas_Fraction_Inclination_Type; }
            set { _Gas_Fraction_Inclination_Type = value; }
        }
        #endregion
        #region WGR Inclination Rate
        private double _WGR_Inclination_Rate;

        public double WGR_Inclination_Rate
        {
            get { return _WGR_Inclination_Rate; }
            set { _WGR_Inclination_Rate = value; }
        }
        #endregion
        #region GOR Inclination Rate
        private double _GOR_Inclination_Rate;

        public double GOR_Inclination_Rate
        {
            get { return _GOR_Inclination_Rate; }
            set { _GOR_Inclination_Rate = value; }
        }
        #endregion

        #region Activity Entity
        private string _Activity_Entity;

        public string Activity_Entity
        {
            get { return _Activity_Entity; }
            set { _Activity_Entity = value; }
        }
        #endregion
        #region 1P Technique
        private string _ONEP_Technique;

        public string ONEP_Technique
        {
            get { return _ONEP_Technique; }
            set { _ONEP_Technique = value; }
        }
        #endregion
        #region Change Category
        private string _Change_Category;

        public string Change_Category
        {
            get { return _Change_Category; }
            set { _Change_Category = value; }
        }
        #endregion
        #region Project
        private string _Project;

        public string Project
        {
            get { return _Project; }
            set { _Project = value; }
        }
        #endregion
        #region PEEP Project
        private string _PEEP_Project;

        public string PEEP_Project
        {
            get { return _PEEP_Project; }
            set { _PEEP_Project = value; }
        }
        #endregion
        #region String
        private string _String;

        public string String
        {
            get { return _String; }
            set { _String = value; }
        }
        #endregion
        #region Block
        private string _Block;

        public string Block
        {
            get { return _Block; }
            set { _Block = value; }
        }
        #endregion
        #region CGR Inclination Rate
        private double _CGR_Inclination_Rate;

        public double CGR_Inclination_Rate
        {
            get { return _CGR_Inclination_Rate; }
            set { _CGR_Inclination_Rate = value; }
        }
        #endregion

        #region URg Low
        private double _URg_Low;

        public double URg_Low
        {
            get { return _URg_Low; }
            set { _URg_Low = value; }
        }
        #endregion

        #region Gp
        private double _Gp;

        public double Gp
        {
            get { return _Gp; }
            set { _Gp = value; }
        }
        #endregion
        #region URg 3P/3C
        private double _URg_3P_3C;

        public double URg_3P_3C
        {
            get { return _URg_3P_3C; }
            set { _URg_3P_3C = value; }
        }
        #endregion
        #region URg 2P/2C
        private double _URg_2P_2C;

        public double URg_2P_2C
        {
            get { return _URg_2P_2C; }
            set { _URg_2P_2C = value; }
        }
        #endregion
        #region URg 1P/1C
        private double _URg_1P_1C;

        public double URg_1P_1C
        {
            get { return _URg_1P_1C; }
            set { _URg_1P_1C = value; }
        }
        #endregion

        #region URo Low
        private double _URo_Low;

        public double URo_Low
        {
            get { return _URo_Low; }
            set { _URo_Low = value; }
        }
        #endregion
        #region Initial CGR
        private double _Initial_CGR;

        public double Initial_CGR
        {
            get { return _Initial_CGR; }
            set { _Initial_CGR = value; }
        }
        #endregion
        #region Initial WGR
        private double _Initial_WGR;

        public double Initial_WGR
        {
            get { return _Initial_WGR; }
            set { _Initial_WGR = value; }
        }
        #endregion
        #region Gas Priority Factor
        private double _Gas_Priority_Factor;

        public double Gas_Priority_Factor
        {
            get { return _Gas_Priority_Factor; }
            set { _Gas_Priority_Factor = value; }
        }
        #endregion


        #region Initial Gas Rate 3P/3C
        private double _Initial_Gas_Rate_3P_3C;

        public double Initial_Gas_Rate_3P_3C
        {
            get { return _Initial_Gas_Rate_3P_3C; }
            set { _Initial_Gas_Rate_3P_3C = value; }
        }
        #endregion
        #region Initial Gas Rate 2P/2C
        private double _Initial_Gas_Rate_2P_2C;

        public double Initial_Gas_Rate_2P_2C
        {
            get { return _Initial_Gas_Rate_2P_2C; }
            set { _Initial_Gas_Rate_2P_2C = value; }
        }
        #endregion
        #region Initial Gas Rate 1P/1C
        private double _Initial_Gas_Rate_1P_1C;

        public double Initial_Gas_Rate_1P_1C
        {
            get { return _Initial_Gas_Rate_1P_1C; }
            set { _Initial_Gas_Rate_1P_1C = value; }
        }
        #endregion

        #region Abandonment Gas Rate 3P/3C
        private double _Abandonment_Gas_Rate_3P_3C;

        public double Abandonment_Gas_Rate_3P_3C
        {
            get { return _Abandonment_Gas_Rate_3P_3C; }
            set { _Abandonment_Gas_Rate_3P_3C = value; }
        }
        #endregion
        #region Abandonment Gas Rate 2P/2C
        private double _Abandonment_Gas_Rate_2P_2C;

        public double Abandonment_Gas_Rate_2P_2C
        {
            get { return _Abandonment_Gas_Rate_2P_2C; }
            set { _Abandonment_Gas_Rate_2P_2C = value; }
        }
        #endregion
        #region Abandonment Gas Rate 1P/1C
        private double _Abandonment_Gas_Rate_1P_1C;

        public double Abandonment_Gas_Rate_1P_1C
        {
            get { return _Abandonment_Gas_Rate_1P_1C; }
            set { _Abandonment_Gas_Rate_1P_1C = value; }
        }
        #endregion

        #region Abandonment WGR 3P/3C
        private double _Abandonment_WGR_3P_3C;

        public double Abandonment_WGR_3P_3C
        {
            get { return _Abandonment_WGR_3P_3C; }
            set { _Abandonment_WGR_3P_3C = value; }
        }
        #endregion
        #region Abandonment WGR 2P/2C
        private double _Abandonment_WGR_2P_2C;

        public double Abandonment_WGR_2P_2C
        {
            get { return _Abandonment_WGR_2P_2C; }
            set { _Abandonment_WGR_2P_2C = value; }
        }
        #endregion
        #region Abandonment WGR 1P/1C
        private double _Abandonment_WGR_1P_1C;

        public double Abandonment_WGR_1P_1C
        {
            get { return _Abandonment_WGR_1P_1C; }
            set { _Abandonment_WGR_1P_1C = value; }
        }
        #endregion

        #region Abandonment CGR 3P/3C
        private double _Abandonment_CGR_3P_3C;

        public double Abandonment_CGR_3P_3C
        {
            get { return _Abandonment_CGR_3P_3C; }
            set { _Abandonment_CGR_3P_3C = value; }
        }
        #endregion
        #region Abandonment CGR 2P/2C
        private double _Abandonment_CGR_2P_2C;

        public double Abandonment_CGR_2P_2C
        {
            get { return _Abandonment_CGR_2P_2C; }
            set { _Abandonment_CGR_2P_2C = value; }
        }
        #endregion
        #region Abandonment CGR 1P/1C
        private double _Abandonment_CGR_1P_1C;

        public double Abandonment_CGR_1P_1C
        {
            get { return _Abandonment_CGR_1P_1C; }
            set { _Abandonment_CGR_1P_1C = value; }
        }
        #endregion

        #region Lift Gas Rate
        public double Lift_Gas_Rate { get; set; }
        #endregion
        #region In Year Bookin
        public double In_Yr_Booking { get; set; }
        #endregion
        #region LE-LV
        public double LE_LV { get; set; }
        #endregion
        #region PRCS
        public double PRCS { get; set; }
        #endregion
        #region Forecast Period
        public double Forecast_Period { get; set; }
        #endregion

        #region Max Liquid
        public double Max_Liquid { get; set; }
        #endregion
        #region Remarks
        public double Remarks { get; set; }
        #endregion
        #region Decline Gas Rate
        public string Decline_Gas_Rate { get; set; }
        #endregion
        #region Water Disposal Fraction
        public double Water_Disposal_Fraction { get; set; }
        #endregion
        #endregion

        public void GetModules(string Connection, string TableName)
        {
            string Query = string.Format("SELECT * FROM {0}", TableName);

            using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0}", Connection)))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                {
                    using (SQLiteDataReader myReader = command.ExecuteReader())
                    {
                        Modules = new List<Module>();
                        while (myReader.Read())
                        {
                            Module myModule = new Module()
                            {
                                #region reader
                                Asset_Team = Convert.ToString(myReader["Asset Team"]),
                                Field = Convert.ToString(myReader["Field"]),
                                Reservoir = Convert.ToString(myReader["Reservoir"]),
                                WellName = Convert.ToString(myReader["WellName"]),
                                Drainage_Point = Convert.ToString(myReader["Drainage Point"]),
                                Module_ = Convert.ToString(myReader["Module"]),
                                TRANCHE = Convert.ToString(myReader["TRANCHE"]),
                                Manifold = Convert.ToString(myReader["Manifold"]),
                                Flow_station = Convert.ToString(myReader["Flow station"]),
                                Resource_Class = Convert.ToString(myReader["Resource Class"]),
                                URo1P_1C = utils.ToDouble(myReader["URo 1P/1C"]),
                                URo2P_2C = utils.ToDouble(myReader["URo 2P/2C"]),
                                URo3P_3C = utils.ToDouble(myReader["URo 3P/3C"]),
                                NP = utils.ToDouble(myReader["Np"]),
                                Initial_Oil_Rate_1P_1C = utils.ToDouble(myReader["Initial Oil Rate 1P/1C"]),
                                Initial_Oil_Rate_2P_2C = utils.ToDouble(myReader["Initial Oil Rate 2P/2C"]),
                                Initial_Oil_Rate_3P_3C = utils.ToDouble(myReader["Initial Oil Rate 3P/3C"]),
                                Abandonment_Oil_Rate_1P_1C = utils.ToDouble(myReader["Abandonment Oil Rate 1P/1C"]),
                                Abandonment_Oil_Rate_2P_2C = utils.ToDouble(myReader["Abandonment Oil Rate 2P/2C"]),
                                Abandonment_Oil_Rate_3P_3C = utils.ToDouble(myReader["Abandonment Oil Rate 3P/3C"]),
                                BSWi = utils.ToDouble(myReader["Initial BSW"]),
                                Abandonment_BSW_1P_1C = utils.ToDouble(myReader["Abandonment BSW 1P/1C"]),
                                Abandonment_BSW_2P_2C = utils.ToDouble(myReader["Abandonment BSW 2P/2C"]),
                                Abandonment_BSW_3P_3C = utils.ToDouble(myReader["Abandonment BSW 3P/3C"]),
                                GORi = utils.ToDouble(myReader["Initial GOR"]),
                                Abandonment_GOR_1P_1C = utils.ToDouble(myReader["Abandonment GOR 1P/1C"]),
                                Abandonment_GOR_2P_2C = utils.ToDouble(myReader["Abandonment GOR 2P/2C"]),
                                Abandonment_GOR_3P_3C = utils.ToDouble(myReader["Abandonment GOR 3P/3C"]),
                                Plateau_OilGas = utils.ToDouble(myReader["Plateau [Oil/Gas]"]),
                                On_stream_Date_1P_1C = Convert.ToDateTime(myReader["On-stream Date-1P/1C"]),
                                On_stream_Date_2P_2C = Convert.ToDateTime(myReader["On-stream Date-2P/2C"]),
                                On_stream_Date_3P_3C = Convert.ToDateTime(myReader["On-stream Date-3P/3C"]),
                                Decline_Oil_Rate_year = utils.ToDouble(myReader["Decline Oil Rate (/year)"]),
                                DeclineExponent = utils.ToDouble(myReader["Decline Exponent"]),

                                Weight_Fraction_GOR_CGR = utils.ToDouble(myReader["Weight Fraction GOR/CGR"]),
                                Weight_Fraction_BSW_WGR = utils.ToDouble(myReader["Weight Fraction BSW/WGR"]),
                                Water_Fraction_Inclination_Type = Convert.ToString(myReader["Water Fraction Inclination Type"]),
                                Water_Cut_Inclination_Rate = utils.ToDouble(myReader["Water Cut Inclination Rate"]),
                                WGR_Inclination_Rate = utils.ToDouble(myReader["WGR Inclination Rate"]),
                                Gas_Fraction_Inclination_Type = Convert.ToString(myReader["Gas Fraction Inclination Type"]),
                                GOR_Inclination_Rate = utils.ToDouble(myReader["GOR Inclination Rate"]),
                                CGR_Inclination_Rate = utils.ToDouble(myReader["CGR Inclination Rate"]),
                                Decline_Deferment_Factor = utils.ToDouble(myReader["Decline Deferment Factor"]),
                                Percentage_Deferment = utils.ToDouble(myReader["Percentage Deferment"]),
                                Gas_Priority_Factor = utils.ToDouble(myReader["Gas Priority Factor"]),
                                Oil_Priority_Factor = utils.ToDouble(myReader["Oil Priority Factor"]),
                                Water_Priority_Factor = utils.ToDouble(myReader["Water Priority Factor"]),
                                Block = Convert.ToString(myReader["Block"]),
                                String = Convert.ToString(myReader["String"]),
                                PEEP_Project = Convert.ToString(myReader["PEEP Project"]),
                                Activity_Entity = Convert.ToString(myReader["Activity Entity"]),
                                Project = Convert.ToString(myReader["Project"]),
                                Change_Category = Convert.ToString(myReader["Change Category"]),
                                ONEP_Technique = Convert.ToString(myReader["1P Technique"]),
                                URo_Low = utils.ToDouble(myReader["URo Low"]),
                                URg_1P_1C = utils.ToDouble(myReader["URg 1P/1C"]),
                                URg_2P_2C = utils.ToDouble(myReader["URg 2P/2C"]),
                                URg_3P_3C = utils.ToDouble(myReader["URg 3P/3C"]),
                                Gp = utils.ToDouble(myReader["Gp"]),
                                Initial_Gas_Rate_1P_1C = utils.ToDouble(myReader["Initial Gas Rate 1P/1C"]),
                                Initial_Gas_Rate_2P_2C = utils.ToDouble(myReader["Initial Gas Rate 2P/2C"]),
                                Initial_Gas_Rate_3P_3C = utils.ToDouble(myReader["Initial Gas Rate 3P/3C"]),

                                Abandonment_Gas_Rate_1P_1C = utils.ToDouble(myReader["Abandonment Gas Rate 1P/1C"]),
                                Abandonment_Gas_Rate_2P_2C = utils.ToDouble(myReader["Abandonment Gas Rate 2P/2C"]),
                                Abandonment_Gas_Rate_3P_3C = utils.ToDouble(myReader["Abandonment Gas Rate 3P/3C"]),
                                Initial_WGR = utils.ToDouble(myReader["Initial WGR"]),
                                Initial_CGR = utils.ToDouble(myReader["Initial CGR"]),

                                Abandonment_WGR_1P_1C = utils.ToDouble(myReader["Abandonment WGR 1P/1C"]),
                                Abandonment_WGR_2P_2C = utils.ToDouble(myReader["Abandonment WGR 2P/2C"]),
                                Abandonment_WGR_3P_3C = utils.ToDouble(myReader["Abandonment WGR 3P/3C"]),

                                Abandonment_CGR_1P_1C = utils.ToDouble(myReader["Abandonment CGR 1P/1C"]),
                                Abandonment_CGR_2P_2C = utils.ToDouble(myReader["Abandonment CGR 2P/2C"]),
                                Abandonment_CGR_3P_3C = utils.ToDouble(myReader["Abandonment CGR 3P/3C"]),

                                Lift_Gas_Rate = utils.ToDouble(myReader["lift Gas Rate"]),
                                In_Yr_Booking = utils.ToDouble(myReader["In-year Booking"]),
                                LE_LV = utils.ToDouble(myReader["LE / LV"]),
                                PRCS = utils.ToDouble(myReader["PRCS"]),
                                Forecast_Period = utils.ToDouble(myReader["Forecast Period (Year)"]),
                                Max_Liquid = utils.ToDouble(myReader["Maximum Liquid (stb/d)"]),
                                Remarks = utils.ToDouble(myReader["Remarks"]),
                                Decline_Gas_Rate = Convert.ToString(myReader["Decline Gas Rate"]),
                                Water_Disposal_Fraction = utils.ToDouble(myReader["Water Disposal Fraction"])
                                #endregion
                            };

                            Modules.Add(myModule);
                        }
                    }
                }
                connection.Close();
            }
        }

    }
}
