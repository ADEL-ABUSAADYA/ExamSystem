using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using ExaminationSystem;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(container => container.RegisterModule(new AutoFacModule()));

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddResponseCompression(opts =>
    {
        opts.EnableForHttps = true;
        opts.Providers.Add<GzipCompressionProvider>();
        opts.Providers.Add<BrotliCompressionProvider>();
    });
builder.Services.Configure<BrotliCompressionProviderOptions>(opts =>
    {
        opts. Level = System.IO.Compression.CompressionLevel.Fastest;
    });

builder.Services.Configure<GzipCompressionProviderOptions>(opts =>
    {
        opts. Level = System. IO.Compression.CompressionLevel.Optimal;
    });

var app = builder.Build();

app.UseResponseCompression();

AutoMapperService._mapper = app.Services.GetService<IMapper>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
// app.UseMiddleware<GlobalErrorHandlerMiddleware>();
app.UseMiddleware<TransactionMiddleware>();

app.Run();
