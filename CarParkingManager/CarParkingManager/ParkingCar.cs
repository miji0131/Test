﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManager
{
    public class ParkingCar
    {
        public int parkingSpot { get; set; }//PK
        public string carNumber { get; set; }
        public string driverName { get; set; }

        public string phoneNumber { get; set; }

        public DateTime parkingTime { get; set; }
    }
}
