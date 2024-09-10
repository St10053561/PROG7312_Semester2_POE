using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Classes
{
    public class IssueReport
    {
        // Properties of the IssueReport class
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        // Empty constructor
        public IssueReport()
        {
        }

    }
}
