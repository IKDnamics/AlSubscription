using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almal.Core
{
    public enum DeleteResult
    {
        Failed, Successded, HasConstraints, None
    }

    public enum MessageType
    {
        Success, Error, Info, Warning
    }
    public enum OperationType
    {
        Add, Edit, Delete
    }
    public enum EnumDirection : int
    {
        Inbound = 0,
        Outbound = 1
    }

    public enum EnumCallStatus
    {
        Planned = 0,
        Helled = 1,
        NotHelled = 2
    }

    public enum EnumRelatedTo
    {
        Customer = 0,
        Order = 1
    }

    public enum OrderRating : int
    {
        NoRating = 0,
        Verybad = 1,
        Bad = 2,
        Average = 3,
        Good = 4,
        Verygood = 5
    }

    public enum FrequentOrder
    {
        No = 1,
        Weekly = 2,
        Monthly = 3,
        Yearly = 4
    }

    public enum PushNotificationType
    {
        General=1,
        Offer=2
    }

    public enum NetPromoterScore 
    {
        
        Zero =0,
        One =1,
        Two =2,
        Three =3,
        Four =4,
        Five =5,
        Six =6,
        Seven =7,
        Eight =8,
        Nine =9,
        Ten =10

        
       
    }

    public struct SMSItem
    {
       public string mobile;
       public string smstext;
    }


    public static class Constants
    {
      
    }
}
