using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Modelos.AuditDocument
{
    public class AuditDocumentViewModel
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public DateTime CreationStamp { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime LastModifiedStamp { get; set; }
        public string AuditNumber { get; set; }
        public DateTime AuditDate { get; set; }
        public string Auditors { get; set; }
        public Guid Sector { get; set; }
        public string Objetive { get; set; }
        public string Aim { get; set; }
        public string Report { get; set; }
        public bool ActiveMark { get; set; }
        public Guid AttachmentsKey { get; set; }
    }
}
