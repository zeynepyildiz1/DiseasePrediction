using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiseasePredictionProject.Core.Response
{

        public class Response<T> where T : class
        {
            public T Extra { get; set; }

            public bool Success { get; set; }

            public string ErrorMessage { get; set; }

            public Response(T extra)
            {
                this.Success = true;
                this.Extra = extra;
            }

            public Response(string errorMessage)
            {
                this.Success = false;
                this.ErrorMessage = errorMessage;
            }
        
    }
}
