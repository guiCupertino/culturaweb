using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Validation
{
    public class BusinessError
    {
        public string Property { get; set; }
        public string Message { get; set; }
    }

    public class BusinessException : Exception
    {
        public BusinessException()
            : base()
        {
            this.Initialize();
        }

        public BusinessException(string message)
            : base(message)
        {
            this.Initialize();
            this.Errors.Add(new BusinessError { Message = message });
        }

        public BusinessException(string message, Exception ex)
            : base(message, ex)
        {
            this.Initialize();
            this.Errors.Add(new BusinessError { Message = message });
        }

        public BusinessException(List<BusinessError> errors)
        {
            this.Initialize();
            this.Errors.AddRange(errors);
        }

        private void Initialize()
        {
            this.Errors = new List<BusinessError>();
        }

        public List<BusinessError> Errors { get; set; }
    }
}
