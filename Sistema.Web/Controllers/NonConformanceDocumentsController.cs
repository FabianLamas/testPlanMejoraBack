using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos;
using Sistema.Entidades.DataEntidades;
using Sistema.Web.Modelos.NonConformanceDocument;

namespace Sistema.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NonConformanceDocumentsController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public NonConformanceDocumentsController(DbContextSistema context)
        {
            _context = context;
        }

        // GET: api/NonConformanceDocuments/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<NonConformanceDocumentViewModel>> Listar()
        {
            var nonConformanceDocument = await _context.NonConformanceDocuments.Where(n => n.AuditDocument != null && n.FulfilmentDate != null && n.ResolutionDate != null && n.ResolutionProblemOk != null).ToListAsync();

            return nonConformanceDocument.Select(n => new NonConformanceDocumentViewModel
            {
                Id = n.Id,
                AuditDocument = n.AuditDocument,
                Number = n.Number,
                Author = n.Author,
                CreationStamp = n.CreationStamp,
                LastModifiedUser = n.LastModifiedUser,
                LastModifiedStamp = n.LastModifiedStamp,
                Sector = n.Sector,
                NonConformanceType = n.NonConformanceType,
                Topic = n.Topic,
                Cell = n.Cell,
                Recurrent = n.Recurrent,
                Brand = n.Brand,
                Size = n.Size,
                Report = n.Report,
                Responsible = n.Responsible,
                AttachmentsKey = n.AttachmentsKey,
                AnswerType = n.AnswerType,
                Observations = n.Observations,
                Actions = n.Actions,
                CommitmentDate = n.CommitmentDate,
                FulfilmentDate = n.FulfilmentDate,
                FulfilmentObservations = n.FulfilmentObservations,
                ResolutionProblemOk = n.ResolutionProblemOk,
                ResolutionDate = n.ResolutionDate,
                ResolutionObservations = n.ResolutionObservations,
                ActiveMark = n.ActiveMark,
                Observations1 = n.Observations1,
                RootReason = n.RootReason,
                NormType = n.NormType
            });
        }


        // GET: api/NonConformanceDocuments/Mostrar/1
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Mostrar ([FromRoute] Guid id)
        {
            var nonConformanceDocument = await _context.NonConformanceDocuments.FindAsync(id);

            if(nonConformanceDocument == null)
            {
                return BadRequest();
            }

            return Ok(new NonConformanceDocumentViewModel {
                Id = nonConformanceDocument.Id,
                AuditDocument = nonConformanceDocument.AuditDocument,
                Number = nonConformanceDocument.Number,
                Author = nonConformanceDocument.Author,
                CreationStamp = nonConformanceDocument.CreationStamp,
                LastModifiedUser = nonConformanceDocument.LastModifiedUser,
                LastModifiedStamp = nonConformanceDocument.LastModifiedStamp,
                Sector = nonConformanceDocument.Sector,
                NonConformanceType = nonConformanceDocument.NonConformanceType,
                Topic = nonConformanceDocument.Topic,
                Cell = nonConformanceDocument.Cell,
                Recurrent = nonConformanceDocument.Recurrent,
                Brand = nonConformanceDocument.Brand,
                Size = nonConformanceDocument.Size,
                Report = nonConformanceDocument.Report,
                Responsible = nonConformanceDocument.Responsible,
                AttachmentsKey = nonConformanceDocument.AttachmentsKey,
                AnswerType = nonConformanceDocument.AnswerType,
                Observations = nonConformanceDocument.Observations,
                Actions = nonConformanceDocument.Actions,
                CommitmentDate = nonConformanceDocument.CommitmentDate,
                FulfilmentDate = nonConformanceDocument.FulfilmentDate,
                FulfilmentObservations = nonConformanceDocument.FulfilmentObservations,
                ResolutionProblemOk = nonConformanceDocument.ResolutionProblemOk,
                ResolutionDate = nonConformanceDocument.ResolutionDate,
                ResolutionObservations = nonConformanceDocument.ResolutionObservations,
                ActiveMark = nonConformanceDocument.ActiveMark,
                Observations1 = nonConformanceDocument.Observations1,
                RootReason = nonConformanceDocument.RootReason,
                NormType = nonConformanceDocument.NormType
            });

        }


        private bool NonConformanceDocumentExists(Guid id)
        {
            return _context.NonConformanceDocuments.Any(e => e.Id == id);
        }
    }
}