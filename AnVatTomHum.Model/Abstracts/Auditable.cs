using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Model.Abstracts
{
    public class Auditable : IAuditable
    {
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(256)]
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(256)]
        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(256)]
        public string MetaKeywork { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [MaxLength(256)]
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
