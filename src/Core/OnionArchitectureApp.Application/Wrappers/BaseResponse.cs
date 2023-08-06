﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Domain.Wrappers
{
	internal class BaseResponse
	{
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
