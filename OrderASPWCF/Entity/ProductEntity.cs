using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OrderASPWCF.Entity
{
    [DataContract]
    public class ProductEntity
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public string Name { set; get; }
    }
}