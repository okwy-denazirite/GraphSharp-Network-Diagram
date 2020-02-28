using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using GraphSharpDiagram.Utils;

namespace GraphSharpDiagram.Models
{
    class Facility
    {
        #region properties

        List<Facility> Facilities { get; set; }

        #region Date
        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        #endregion
        #region Plant Name
        private string _Plant_Name;

        public string Plant_Name
        {
            get { return _Plant_Name; }
            set { _Plant_Name = value; }
        }
        #endregion


        #region Liquid Capacity (MSTB/D)
        private double _Liquid_Capacity;

        public double Liquid_Capacity
        {
            get { return _Liquid_Capacity; }
            set { _Liquid_Capacity = value; }
        }
        #endregion
        #region Secondary Plant (MSTB/D)
        private string _Secondary_Plant;

        public string Secondary_Plant
        {
            get { return _Secondary_Plant; }
            set { _Secondary_Plant = value; }
        }
        #endregion
        #region Gas Capacity (MSTB/D)
        private double _QG;

        public double QG
        {
            get { return _QG; }
            set { _QG = value; }
        }
        #endregion
        #region Liquid Capacity (MSTB/D)
        private double _QL;

        public double QL
        {
            get { return _QL; }
            set { _QL = value; }
        }
        #endregion

        #region Compressor Availability (%)
        private double _CA;

        public double CA
        {
            get { return _CA; }
            set { _CA = value; }
        }
        #endregion
        #region Pump Availability
        private double _Pump_A;

        public double Pump_A
        {
            get { return _Pump_A; }
            set { _Pump_A = value; }
        }
        #endregion

        #region Scheduled Deferment (%)
        private double _Scheduled_D;

        public double Scheduled_D
        {
            get { return _Scheduled_D; }
            set { _Scheduled_D = value; }
        }
        #endregion
        #region Unscheduled Deferment (%)
        private double _Unscheduled_D;

        public double Unscheduled_D
        {
            get { return _Unscheduled_D; }
            set { _Unscheduled_D = value; }
        }
        #endregion
        #region Third-Party Deferment (%)
        private double _ThirdParty_D;

        public double ThirdParty_D
        {
            get { return _ThirdParty_D; }
            set { _ThirdParty_D = value; }
        }
        #endregion

        #region Crude Losses (%)
        private double _Crude_Losses;

        public double Crude_Losses
        {
            get { return _Crude_Losses; }
            set { _Crude_Losses = value; }
        }
        #endregion


        #region Flared Gas
        private double _Flared_Gas;

        public double Flared_Gas
        {
            get { return _Flared_Gas; }
            set { _Flared_Gas = value; }
        }
        #endregion
        #region Gas Demand (MMscf/d)
        private double _Gas_Demand;

        public double Gas_Demand
        {
            get { return _Gas_Demand; }
            set { _Gas_Demand = value; }
        }
        #endregion
        #region Gas Own Use (MMscf/d)
        private double _Gas_Own_Use;

        public double Gas_Own_Use
        {
            get { return _Gas_Own_Use; }
            set { _Gas_Own_Use = value; }
        }
        #endregion

        #endregion


        public void GetValue(string Connection, string TableName)
        {
            string Query = string.Format("SELECT * FROM {0}", TableName);

            using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0}", Connection)))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                {
                    using (SQLiteDataReader myReader = command.ExecuteReader())
                    {
                        Facilities = new List<Facility>();
                        while (myReader.Read())
                        {
                            Facility myFacility = new Facility()
                            {
                                Date = Convert.ToDateTime(myReader["Date"]),
                                Plant_Name = Convert.ToString(myReader["Plant Name"]),
                                Secondary_Plant = Convert.ToString(myReader["Secondary Plant"]),
                                Liquid_Capacity = utils.ToDouble(myReader["Liquid Capacity (MSTB/D)"]),
                                QG = utils.ToDouble(myReader["Gas Capacity (MMscf/D)"]),
                                CA = utils.ToDouble(myReader["Compressor Availability (%)"]),
                                Pump_A = utils.ToDouble(myReader["Pump Availability"]),
                                Scheduled_D = utils.ToDouble(myReader["Scheduled Deferment (%)"]),
                                Unscheduled_D = utils.ToDouble(myReader["Unscheduled Deferment (%)"]),
                                ThirdParty_D = utils.ToDouble(myReader["Third-Party Deferment (%)"]),
                                Crude_Losses = utils.ToDouble(myReader["Crude Losses (%)"]),
                                Gas_Own_Use = utils.ToDouble(myReader["Gas Own Use (MMscf/d)"]),
                                Gas_Demand = utils.ToDouble(myReader["Gas Demand (MMscf/d)"]),
                                Flared_Gas = utils.ToDouble(myReader["Flared Gas "]),
                            };

                            Facilities.Add(myFacility);
                        }
                    }
                }
                connection.Close();
            }
        }


    }
}
