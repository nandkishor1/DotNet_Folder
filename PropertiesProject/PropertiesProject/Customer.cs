using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProject
{
    public class Customer
    {
        int _Custid;
        bool _Status;
        string _Cname,_State;
        double _Balance;
        Cites _City;
        

        public Customer(int Custid, bool Status, string Cname, double Balance,Cites City,string State)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
            _State = State;
           
        }
        public int Custid
        {
            get { return _Custid; }
            // set { _Custid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set
            {
                if (_Status == true)
                    _Cname = value;
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value >= 500)

                        _Balance = value;
                }
            }
        }
        public Cites City
        {
            get { return _City; }
            set
            {
                if (_Status == true) ;
                _City = value;
            }

        }
        public string State {

            get { return _State; }
            protected set
            {
                if (Status == true);
                _State = value;
            }
        }
        //Auto-Implemented or Automatic Properties
        //Auto-Propery Initializer(6.0)
        public string Country { get; } = "India";
           
        }
    }

