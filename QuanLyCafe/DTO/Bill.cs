﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut; 
            this.status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int) row["id"];
            this.DateCheckIn = (DateTime?) row["dateCheckIn"];
            var dateCheckOutTemp =  row["dateCheckOut"];
            if(dateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)row["dateCheckOut"];
            }
            this.status = (int) row["status"];
        }
        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
