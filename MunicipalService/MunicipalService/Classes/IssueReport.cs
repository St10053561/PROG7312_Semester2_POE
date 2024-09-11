using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalService.Classes
{
    public class IssueReport
    {
        // Properties of the IssueReport class
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
        public string Feedback { get; set; }

        // Empty constructor
        public IssueReport()
        {
        }

    }
}
