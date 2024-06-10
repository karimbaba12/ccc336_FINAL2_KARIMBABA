﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Wrapping
{
    public class ApiResponse <T> 
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public ApiResponse()
        {
            Success = true;
        }

        public ApiResponse(T obj)
        {
            Data = obj;
            Success = true;
        }
    }
}
