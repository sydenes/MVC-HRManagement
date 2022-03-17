using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.BLL.Concrete.ResultServiceBLL
{
    public class ResultService<T>
    {
        public ResultService()
        {
            Errors = new List<ErrorItem>();
        }
        public bool HasError { get; set; }
        public List<ErrorItem> Errors { get; set; }
        public T Data { get; set; }
        public void AddError(string errorType, string errorMessage)
        {
            Errors.Add(new ErrorItem { ErrorType = errorType, ErrorMessage = errorMessage });
            HasError = true;
        }
    }
    public class ErrorItem 
    {
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
    }
}
