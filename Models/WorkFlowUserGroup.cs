using System.ComponentModel.DataAnnotations;

namespace SmartERP.Models
{
    public class WorkFlowUserGroup : ModificationActivity
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int? OfficeId { get; set; }
        public Office Office { get; set; }

        public int? DocumentTypeId { get; set; }
        public SystemCodeDetail DocumentType { get; set; }


    }
}
