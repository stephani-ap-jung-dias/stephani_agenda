using Reservas.Models;
using Reservas.Routes;

var app = builder.Build();
// Mapeia as rotas da API
app.MapGetRoutes();
app.MapPostRoutes();


app.Run();