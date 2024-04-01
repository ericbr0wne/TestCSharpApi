var builder = WebApplication.CreateBuilder(args);

// Always throw custom errors (in dev and production)
builder.Services.Configure<RouteHandlerOptions>
    (o => o.ThrowOnBadRequest = true);

var app = builder.Build();

DoOnEveryRequest.Start(app, "ironboy's minimal API server");
ErrorHandler.Start(app);
FileServer.Start(app, "..", "Frontend");
LoginHandler.Start(app);
REST.Start(app);
SessionHandler.DeleteOldSessions(2);

app.Run("http://localhost:3001");