// Add this in your Program.cs file
builder.Services.AddScoped<BlazorApiIntegration.Services.UserService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api.example.com/") });
