using CGC.Application.IService;
using CGC.Application.IService.Banking;
using CGC.Application.Service;
using CGC.Application.Service.Banking;
using CGC.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection(nameof(MongoDBSettings)));

//builder.Services.AddSingleton(typeof(CGC.Infrastructure.IRepository.Common.IRepository<>), typeof(CGC.Infrastructure.Repository.Common.Repository<>));
builder.Services.AddSingleton(typeof(CGC.Infrastructure.IRepository.IRepository<>), typeof(CGC.Infrastructure.Repository.Repository<>));
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IMenuService, MenuService>();
builder.Services.AddSingleton<IRoleService, RoleService>();
builder.Services.AddSingleton<IMenuPermissionService, MenuPermissionService>();
builder.Services.AddSingleton<IComplainRemarkService, ComplainRemarkService>();
builder.Services.AddSingleton<IComplainService, ComplainService>();
builder.Services.AddSingleton<IBankService, BankService>();
builder.Services.AddSingleton<ICurrencyService, CurrencyService>();
builder.Services.AddSingleton<ICurrencyToCGCService, CurrencyToCGCService>();
builder.Services.AddSingleton<IExchangeCardService, ExchangeCardService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
