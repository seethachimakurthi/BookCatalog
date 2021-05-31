﻿namespace BookCatalog.MicroService.Application.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(T data, string messages) : base(data, false, messages)
        {
        }
        public ErrorDataResult(string messages) : base(default, false, messages)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
