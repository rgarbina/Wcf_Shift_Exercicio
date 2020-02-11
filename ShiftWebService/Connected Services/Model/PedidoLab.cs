using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ShiftWebService.Connected_Services.Model
{
    [DataContract]
    public class PedidoLab
    {
        [DataMember]
        public string Identificador { get; set; }

        [DataMember]
        public Pedido Pedido { get; set; }

        [DataMember]
        public Paciente Paciente { get; set; }

        [DataMember]
        public List<Exame> Exames { get; set; }
    }
}
