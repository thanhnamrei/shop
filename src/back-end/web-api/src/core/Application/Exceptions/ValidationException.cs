﻿namespace Application.Exceptions;

public class ValidationException : Exception
{
    public Dictionary<string, string[]> Errors;

    public ValidationException() : base("One or more validation failures have occurred.")
    {
        Errors = new Dictionary<string, string[]>();
    }

    public ValidationException(Dictionary<string, string[]> errors) : this()
    {
        Errors = errors;
    }
}
