using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SunElectricalServices.Models
{
    public class Service
    {
       [Key] public int ServiceID { get; set; } //  Unique Identifier for Services

        public int StaffID { get; set; }
        public string Residential { get; set; }
        public int Commercial { get; set; }

        [DisplayName("HeatPump Installations")]
        public string Heatpump_Installations { get; set; }

        public string EVChargers { get; set; }

        [DisplayName("Switchboard Upgrades")]
        public string Switchboard_Upgrade { get; set; }

        [DisplayName("Smart Home Installations")]
        public string Smarthome_installations { get; set; }

        [DisplayName("Mainainence and Servicing")]
        public string Maintainence_and_Servicing { get; set; }
        public Staff Staff { get; set; }

    }
}
