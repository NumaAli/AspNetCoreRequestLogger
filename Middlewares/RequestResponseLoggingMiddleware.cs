using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware_Assignment.Middlewares 
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _logDirectory;
        private readonly string _logFilePath;

        public RequestResponseLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
            _logDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
            Directory.CreateDirectory(_logDirectory); // agar folder nahi hai to bana dega
            _logFilePath = Path.Combine(_logDirectory, "RequestResponseLog.txt");
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string[] reqHeaderKeys = new[] { "Host", "User-Agent", "Content-Type", "Accept" };
            var reqHeadersInfo = reqHeaderKeys
                .Select(k => context.Request.Headers.TryGetValue(k, out var v) ? $"{k}: {v}" : $"{k}: <none>")
                .ToArray();

            var requestLog = new StringBuilder();
            requestLog.AppendLine($"Timestamp: {timestamp}");
            requestLog.AppendLine($"Request Method: {context.Request.Method}");
            requestLog.AppendLine($"Request Path: {context.Request.Path}");
            requestLog.AppendLine($"Request Header Keys: [{string.Join(", ", reqHeaderKeys)}]");
            requestLog.AppendLine($"Request Header Values: [{string.Join(", ", reqHeadersInfo)}]");

            await File.AppendAllTextAsync(_logFilePath, requestLog.ToString());

            // aage ke middleware ko call karo
            await _next(context);

            string[] resHeaderKeys = new[] { "Date", "Server", "Content-Type", "Cache-Control" };
            var resHeadersInfo = resHeaderKeys
                .Select(k => context.Response.Headers.TryGetValue(k, out var v) ? $"{k}: {v}" : $"{k}: <none>")
                .ToArray();

            var responseLog = new StringBuilder();
            responseLog.AppendLine($"Response Status Code: {context.Response.StatusCode}");
            responseLog.AppendLine($"Response Header Keys: [{string.Join(", ", resHeaderKeys)}]");
            responseLog.AppendLine($"Response Header Values: [{string.Join(", ", resHeadersInfo)}]");
            responseLog.AppendLine(new string('-', 60));

            await File.AppendAllTextAsync(_logFilePath, responseLog.ToString());
        }
    }
}



