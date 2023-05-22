﻿namespace CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
           await context.Response.WriteAsync("\nMy Custom Middleware - Starts");
            await next(context);
            await context.Response.WriteAsync("\nMy Custom Middleware - Ends");
        }
    }
}
