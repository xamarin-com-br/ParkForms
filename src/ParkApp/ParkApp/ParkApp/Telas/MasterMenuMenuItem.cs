using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkApp.Telas
{

    public class MasterMenuMenuItem
    {
        public MasterMenuMenuItem()
        {
            TargetType = typeof(MasterMenuDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public string Foto { get; set; }

        public Type TargetType { get; set; }
    }
}