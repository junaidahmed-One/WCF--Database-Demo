using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JunaidAhmed_20181COM0065_7COM1
{
    
    public class Service1 : IService1
    {
        public double ShowCurrencyRate(string foriCurrency)
        {
            double ans = 0;

            SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91879\source\repos\JunaidAhmed_20181COM0065_7COM1\App_Data\Database1.mdf;Integrated Security=True");

            SqlCommand scom = new SqlCommand("", scon);
            scom.CommandText = "Select * from CurrencyExchangeOffice where ForiegnCurrency=@foriCurrency";
            scom.Parameters.Add("@foriCurrency", System.Data.SqlDbType.VarChar).Value = foriCurrency;

            scon.Open();

            SqlDataReader reader = scom.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CurrencyExchange ce = new CurrencyExchange();
                    ce.IndiCurrency = reader.GetDouble(1);
                    ans = ce.IndiCurrency;
                }
            }
            else
            {
                //No Record
            }
            reader.Close();
            return ans;
        }

        
    }
}

