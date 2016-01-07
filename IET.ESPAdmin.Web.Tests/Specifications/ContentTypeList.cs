using System.Collections.Generic;
using System.Text.RegularExpressions;
using IET.ESP.Model.Entities;

namespace IET.ESPAdmin.Web.Tests.Specifications
{
    public class ContentTypeList
    {
        public List<ContentType> GetContentTypeListData()
        {
            return new List<ContentType>  
            {
                new ContentType { Id = 1, Category = "Definitions", Group = "Definitions", BookType = "Definitions" },
                new ContentType { Id = 2, Category = "Guidance Notes", Group = "GN", BookType = "GN1" },
                new ContentType { Id = 3, Category = "Guidance Notes", Group = "GN", BookType = "GN2" },
                new ContentType { Id = 4, Category = "Guidance Notes", Group = "GN", BookType = "GN3" },
                new ContentType { Id = 5, Category = "Guidance Notes", Group = "GN", BookType = "GN4" },
                new ContentType { Id = 6, Category = "Guidance Notes", Group = "GN", BookType = "GN5" },
                new ContentType { Id = 7, Category = "Guidance Notes", Group = "GN", BookType = "GN6" },
                new ContentType { Id = 8, Category = "Guidance Notes", Group = "GN", BookType = "GN7" },
                new ContentType { Id = 9, Category = "Guidance Notes", Group = "GN", BookType = "GN8" },
                new ContentType { Id = 10, Category = "Other Guidance", Group = "COMMENTARY", BookType = "COMMENTARY" },
                new ContentType { Id = 11, Category = "Other Guidance", Group = "EGBR", BookType = "EGBR" },
                new ContentType { Id = 12, Category = "Other Guidance", Group = "EIDG", BookType = "EIDG" },
                new ContentType { Id = 13, Category = "Other Guidance", Group = "OSG", BookType = "OSG" },
                new ContentType { Id = 14, Category = "Wiring Matters", Group = "WM", BookType = "WM" },
                new ContentType { Id = 15, Category = "Wiring Matters", Group = "WRD", BookType = "WRD" },
                new ContentType { Id = 16, Category = "Other Guidance", Group = "EGEML", BookType = "EGEML" },
                new ContentType { Id = 17, Category = "Other Guidance", Group = "EGFDA", BookType = "EGFDA" },
                new ContentType { Id = 18, Category = "Other Guidance", Group = "COPESM", BookType = "COPESM" },
                new ContentType { Id = 19, Category = "Other Guidance", Group = "COPLED", BookType = "COPLED" },
                new ContentType { Id = 20, Category = "Other Guidance", Group = "COPIIT", BookType = "COPIIT" },
                new ContentType { Id = 21, Category = "Other Guidance", Group = "ML", BookType = "ML" },
                new ContentType { Id = 22, Category = "Other Guidance", Group = "TPS", BookType = "TPS" },
                new ContentType { Id = 23, Category = "Other Guidance", Group = "EM", BookType = "EM" },
                new ContentType { Id = 24, Category = "Other Guidance", Group = "COPEVCE", BookType = "COPEVCE" },
                new ContentType { Id = 25, Category = "Other Guidance", Group = "COPLVD", BookType = "COPLVD" },
                new ContentType { Id = 26, Category = "Other Guidance", Group = "PSPV", BookType = "PSPV" },
                new ContentType { Id = 27, Category = "Other Guidance", Group = "PSLS", BookType = "PSLS" },
                new ContentType { Id = 28, Category = "Other Guidance", Group = "Student", BookType = "Student" }
            };
        }
    }
}