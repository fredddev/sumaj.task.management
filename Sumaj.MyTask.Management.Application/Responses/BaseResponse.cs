using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Application.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public List<string> ValidationErrors { get; set; }

        public BaseResponse()
        {
            Success = true;            
        }
        public BaseResponse(bool success)
        {
            Success = success;            
        }

        public BaseResponse(bool success, List<string> validationErrors)
        {
            Success = success;
            ValidationErrors = validationErrors;
        }

    }
}
