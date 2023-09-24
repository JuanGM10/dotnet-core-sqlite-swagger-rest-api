using System;

namespace Backend.Response
{
    public class ResponseApi
    {
        public ResponseApi()
        {
            Code = 200;
            Message = "success";
        }
        public int Code { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }

}