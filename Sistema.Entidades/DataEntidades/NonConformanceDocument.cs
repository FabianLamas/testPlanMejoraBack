using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.DataEntidades
{
    public class NonConformanceDocument
    {
        public Guid Id { get; set; }
        public Guid AuditDocument { get; set; }
        public int Number { get; set; }
        public string Author { get; set; }
        public DateTime CreationStamp { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime LastModifiedStamp { get; set; }
        public Guid Sector { get; set; }
        public Guid NonConformanceType { get; set; }
        public Guid Topic { get; set; }
        public Guid Cell { get; set; }
        public bool Recurrent { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Report { get; set; }
        public string Responsible { get; set; }
        public Guid AttachmentsKey { get; set; }
        public string AnswerType { get; set; }
        public string Observations { get; set; }
        public string Actions { get; set; }
        public DateTime CommitmentDate { get; set; }
        public DateTime FulfilmentDate { get; set; }
        public string FulfilmentObservations { get; set; }
        public bool ResolutionProblemOk { get; set; }
        public DateTime ResolutionDate { get; set; }
        public string ResolutionObservations { get; set; }
        public bool ActiveMark { get; set; }
        public string Observations1 { get; set; }
        public string RootReason { get; set; }
        public string NormType { get; set; }

    }
}
