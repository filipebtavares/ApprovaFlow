using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovaFlow.Application.Models
{
    public  class ResultViewModel
    {
        public bool  IsSuccess { get; set; }
        public string  Message { get; set; }
        public StatusViewModel StatusView { get; set; }

        public ResultViewModel(bool isSuccess = true , string message = "")
        {
            IsSuccess = isSuccess;
            Message = message;
           
        }

        public static ResultViewModel Success()
            => new ResultViewModel();

        public static ResultViewModel Error(string message)
                => new ResultViewModel(false, message);
    }

    public class ResultViewModel<T> : ResultViewModel
    {
        public T? Data { get; set; }

        public ResultViewModel(T? data, bool isSuccess = true, string message = "")
        {
            Data = data;
        }

        public static ResultViewModel<T> Success(T? data)
            => new ResultViewModel<T>(data);

        public static ResultViewModel<T> Error(string message)
            => new ResultViewModel<T>(default, false, message);
    }

    public enum StatusViewModel
    {
        SUCCESS = 0,
        ERROR =1
    }
}
