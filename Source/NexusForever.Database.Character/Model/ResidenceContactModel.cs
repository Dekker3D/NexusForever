using System;

namespace NexusForever.Database.Character.Model
{
    public partial class ResidenceContactModel
    {
        public ulong Id { get; set; }
        public ulong ResidenceId { get; set; }
        public ulong ContactId { get; set; }
        public byte Type { get; set; }

        public virtual ResidenceModel Residence { get; set; }
    }
}
