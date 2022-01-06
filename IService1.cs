using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JunaidAhmed_20181COM0065_7COM1
{
    
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double ShowCurrencyRate(string foriegnCurrency);

    }


    [DataContract]
    public class CurrencyExchange
    {
        string foriCurrency;
        double indianCurrency;

        [DataMember]
        public string ForiCurrency
        {
            get { return foriCurrency; }
            set { foriCurrency = value; }
        }

        [DataMember]
        public double IndiCurrency
        {
            get { return indianCurrency; }
            set { indianCurrency = value; }
        }
    }
}
