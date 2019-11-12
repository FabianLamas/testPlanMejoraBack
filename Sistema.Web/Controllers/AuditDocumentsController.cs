using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos;
using Sistema.Entidades.DataEntidades;
using Sistema.Web.Modelos.AuditDocument;

namespace Sistema.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditDocumentsController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public AuditDocumentsController(DbContextSistema context)
        {
            _context = context;
        }

        // GET: api/AuditDocuments/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<AuditDocumentViewModel>>Listar()
        {
            var auditDocument = await _context.AuditDocuments.ToListAsync();

            return auditDocument.Select(a => new AuditDocumentViewModel
            {
                Id =a.Id,
                Author = a.Author,
                CreationStamp = a.CreationStamp,
                LastModifiedUser = a.LastModifiedUser,
                LastModifiedStamp = a.LastModifiedStamp,
                AuditNumber = a.AuditNumber,
                AuditDate = a.AuditDate,
                Auditors = a.Auditors,
                Sector = a.Sector,
                Objetive = a.Objetive,
                Aim = a.Aim,
                Report = a.Report,
                ActiveMark = a.ActiveMark,
                AttachmentsKey = a.AttachmentsKey
            });
        }

        // GET: api/AuditDocuments/Mostrar/1
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Mostrar([FromRoute] Guid id)
        {
            var auditDocument = await _context.AuditDocuments.FindAsync(id);

            if(auditDocument == null)
            {
                return BadRequest();
            }

            return Ok(new AuditDocument {
                Id = auditDocument.Id,
                Author = auditDocument.Author,
                CreationStamp = auditDocument.CreationStamp,
                LastModifiedUser = auditDocument.LastModifiedUser,
                LastModifiedStamp = auditDocument.LastModifiedStamp,
                AuditNumber = auditDocument.AuditNumber,
                AuditDate = auditDocument.AuditDate,
                Auditors = auditDocument.Auditors,
                Sector = auditDocument.Sector,
                Objetive = auditDocument.Objetive,
                Aim = auditDocument.Aim,
                Report = auditDocument.Report,
                ActiveMark = auditDocument.ActiveMark,
                AttachmentsKey = auditDocument.AttachmentsKey
            });
        }

        private bool AuditDocumentExists(Guid id)
        {
            return _context.AuditDocuments.Any(e => e.Id == id);
        }
    }
}