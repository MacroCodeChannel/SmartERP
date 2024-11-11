﻿namespace SmartERP.Models
{
    public class Client : ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int ClientTypeId { get; set; }

        public SystemCodeDetail ClientType { get; set; }  

        public int ClientStatusId { get; set; }
        public SystemCodeDetail ClientStatus { get; set; }
    }
}
