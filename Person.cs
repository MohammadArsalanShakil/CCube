using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCube
{
    abstract class Person
    {
        protected string cnic;
        protected string name;

        public Person()
        {

        }
        public Person(string cnic,string name)
        {
            this.cnic = cnic;
            this.name = name;
        }
        
        public string CNIC
        {
            set { cnic = value; }
            get { return cnic; }

        }
        public string Name
        {
            set { name = value; }
            get { return name; }

        }

        virtual public string getData()
        {
            string data = "------------------------------\n";
            data +="CNIC :"+ this.cnic + "\n";
            data +="Name :"+ this.name + "\n";
            return data;

        }
    }//end class

}//end namespace
