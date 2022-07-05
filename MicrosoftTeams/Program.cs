using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MicrosoftTeams;
using MicrosoftTeams.Data;
using MicrosoftTeams.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
builder.Services.AddTransient<Service>();
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

//Создать веб-приложение, которое позволяет зарегистрироваться
//на конференцию по ASP.NET Core.
//Требования к приложению:
//■ домашняя страница должна отображать краткую информацию
//о конференции, ссылку на страницу с программой конференции и переход на форму регистрации;
//■ страница с программой конференции должна содержать подробную информацию (организаторы, спонсоры, программа,
//информация о докладчиках и докладах), на этой странице также
//должен быть переход на форму регистрации;
//■ на форме регистрации указывается ФИО, телефон и e-mail;
//■ обязательно предусмотреть проверку достоверности формы
//и переход на страницу с благодарностью за регистрацию;
//■ на указанный e-mail необходимо отправить письмо с информацией о регистрации на конференцию;
//■ итоговая страница должна показывать список зарегистрированных людей;
//■ доступ к итоговой странице предоставляется только аутентифицированным пользователям;