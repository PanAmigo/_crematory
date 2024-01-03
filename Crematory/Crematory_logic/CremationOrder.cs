using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crematory_logic
{
    public class CremationOrder
    {
        public int CustomerID { get; private set; }
        public int DeceasedPersonID { get; private set; }
        public int StaffID { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string SpecialInstructions { get; private set; }
        public DateTime FuneralDate { get; private set; }
        public bool DeathCertificate { get; private set; }
        public bool CremationConsent { get; private set; }

        public CremationOrder(int customerID, int deceasedPersonID, int staffID, DateTime orderDate, string specialInstructions, DateTime funeralDate, bool deathCertificate, bool cremationConsent)
        {
            CustomerID = customerID;
            DeceasedPersonID = deceasedPersonID;
            StaffID = staffID;
            OrderDate = orderDate;
            SpecialInstructions = specialInstructions;
            FuneralDate = funeralDate;
            DeathCertificate = deathCertificate;
            CremationConsent = cremationConsent;
        }

        public CremationOrder()
        {
        }
    }
}
