﻿namespace ExaminationSystem;

public class GlobalErrorHandlerMiddleware
{
    RequestDelegate _nextAction;
    public GlobalErrorHandlerMiddleware(RequestDelegate nextAction)
    {
        _nextAction = nextAction;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _nextAction(context);
        }
        catch (Exception ex)
        {
            File.WriteAllText("/Users",ex.Message);
        }
    }
}
