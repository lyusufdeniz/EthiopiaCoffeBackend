using EthiopiaCoffe.API.Middlewares;
using Microsoft.AspNetCore.Diagnostics;

namespace EthiopiaCoffe.API.Extensions
{
    public static class MiddlewareInjectorExtension
    {
        public static void InjectMiddlewares(this WebApplication app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (exceptionHandlerFeature != null)
                    {
                        var exception = exceptionHandlerFeature.Error;
                        var handler = app.Services.GetRequiredService<GlobalExceptionHandler>();
                        await handler.TryHandleAsync(context, exception, context.RequestAborted);
                    }
                });
            });

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

        }

    }
}
