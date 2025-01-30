using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Handlers.CompanyInfoHandlers;
using CQRSInsurance.CQRSDesignPattern.Handlers.FeatureHandlers;
using CQRSInsurance.CQRSDesignPattern.Handlers.ServiceHandlers;
using CQRSInsurance.CQRSDesignPattern.Handlers.TestimonialHandlers;

var builder = WebApplication.CreateBuilder(args);

// Localization ayarlarýný ekleyelim
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// Dil seçenekleri
var supportedCultures = new[]
{
    new CultureInfo("tr"),
    new CultureInfo("en"),
    new CultureInfo("de")
};

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("tr");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

// Veritabaný baðlantýsý
builder.Services.AddDbContext<CQRSContext>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

// CompanyInfo
builder.Services.AddScoped<CreateCompanyInfoCommandHandler>();
builder.Services.AddScoped<RemoveCompanyInfoCommandHandler>();
builder.Services.AddScoped<UpdateCompnayInfoCommandHandler>();
builder.Services.AddScoped<GetCompanyInfoByIdQueryHandler>();
builder.Services.AddScoped<GetCompanyInfoQueryHandler>();

// Feature
builder.Services.AddScoped<CreateFeatureCommandHandler>();
builder.Services.AddScoped<RemoveFeatureCommandHandler>();
builder.Services.AddScoped<UpdateFeatureCommandHandler>();
builder.Services.AddScoped<GetFeatureByIdQueryHandler>();
builder.Services.AddScoped<GetFeatureQueryHandler>();

// Service
builder.Services.AddScoped<CreateServiceCommandHandler>();
builder.Services.AddScoped<RemoveServiceCommandHandler>();
builder.Services.AddScoped<UpdateServiceCommandHandler>();
builder.Services.AddScoped<GetServiceByIdQueryHandler>();
builder.Services.AddScoped<GetServiceQueryHandler>();

// Testimonial
builder.Services.AddScoped<CreateTestimonialCommandHandler>();
builder.Services.AddScoped<RemoveTestimonialCommandHandler>();
builder.Services.AddScoped<UpdateTestimonialCommandHandler>();
builder.Services.AddScoped<GetTestimonialByIdQueryHandler>();
builder.Services.AddScoped<GetTestimonialQueryHandler>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Dil ayarlarýný uygula
var localizationOptions = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
app.UseRequestLocalization(localizationOptions);

// Hata yönetimi
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
