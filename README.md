# ServiceDiscovery
Create Two sample microservices and create a project for ocelot apigateway and add this code to program.cs 

builder.Configuration.AddJsonFile("ocelot.json", false, false);

builder.Services.AddOcelot(builder.Configuration);

then add ocelot middleware

app.UseOcelot();

and create a json file to configure routes

