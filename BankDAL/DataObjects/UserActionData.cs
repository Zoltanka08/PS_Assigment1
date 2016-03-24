﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL.DataObjects
{
    public class UserActionData
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}
