using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Us01_Vista_Detalles.Model.VO
{
    class ClientVO
    {
        private  string mCIF;
        public string CIF {
            get { return this.mCIF; }
            set { this.mCIF = value; }
        }
        private string mName;
        public string name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }
        private string mPhone;
        public string phone
        {
            get { return this.mPhone; }
            set { this.mPhone = value; }
        }
        private string mContactPerson;
        public string contactPerson
        {
            get { return this.mContactPerson; }
            set { this.mContactPerson = value; }
        }
        private string mEmail;
        public string email
        {
            get { return this.mEmail; }
            set { this.mEmail = value; }
        }
        public ClientVO(string CIF, string name, string phone, string contactPerson, string email)
        {
            this.CIF = CIF;
            this.name = name;
            this.phone = phone;
            this.contactPerson = contactPerson;
            this.email = email;
                
        }
    }
}
