///////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////
///////////// HAMZA ASSADULLAH NAHHAS ////////////////
/////////////      OMUR TURGUT        ////////////////
///////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// // Register DbContext
// builder.Services.AddDbContext<ApplicationDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// // Add Identity
// builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//     .AddEntityFrameworkStores<ApplicationDbContext>()
//     .AddDefaultTokenProviders();



// Add session with a configurable timeout
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
    options.Cookie.HttpOnly = true; // Protect session cookie from client-side scripts
    options.Cookie.IsEssential = true; // Ensure session is available even without consent in GDPR scenarios
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Use detailed exception pages in development
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Custom error page in production
    app.UseHsts(); // Enforce strict transport security in production
}

// Ensure session middleware is added before routing and authentication/authorization
app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Map default controller routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Run the application
app.Run();
