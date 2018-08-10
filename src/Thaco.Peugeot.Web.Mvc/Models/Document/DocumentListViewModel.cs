using System.Collections.Generic;
using Thaco.Peugeot.Document.Dto;

namespace Thaco.Peugeot.Web.Models.Document
{
    public class DocumentListViewModel
    {
        public IReadOnlyList<DocumentDto> Documents { get; set; }
    }
}
