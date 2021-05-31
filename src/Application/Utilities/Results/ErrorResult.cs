﻿namespace BookCatalog.MicroService.Application.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult(string messages) : base(false, messages)
        {
        }
    }
}
