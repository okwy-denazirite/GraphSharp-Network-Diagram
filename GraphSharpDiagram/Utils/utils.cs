using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphSharpDiagram.Utils
{
    public static class utils
    {


        public static double ToDouble(object value)
        {

            return value is DBNull ? 0 : ((IConvertible)value).ToDouble(null);


            //else
            //{

            //    return value != string.Empty ? Convert.ToDouble(value.ToString()) : ((IConvertible)value).ToDouble(null);

            //}
        }
    }
}
