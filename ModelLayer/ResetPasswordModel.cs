﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class ResetPasswordModel
    {
            public string Token { get; set; }
            public string NewPassword { get; set; }
            public string ConfirmPassword { get; set; }
        
    }
}
