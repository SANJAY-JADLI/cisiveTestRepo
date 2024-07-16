This is a sample program to describe how a HTML Form can be submitted (HTTP POST) using JQuery Ajax Call to Web API.

Program divided into two project

API project, having API methods for POST and GET

API ENDPOINT FOR POST REQUEST https://localhost:7246/api/VerifyEmployement/VerifyEmployee

API ENDPOINT FOR GET REQUEST https://localhost:7246/api/VerifyEmployement/GetEmployees

Client project

Contains Razor Page under HomeController/EmployeeForm

Modify the PORTS according to your localhost configuration in

EmployeeForm.cshtml [client project]

Program.cs of [Api Project]

Add CORS in Program.cs otherwise it will not work builder.Services.AddCors();

builder.Services.AddCors(options => { options.AddDefaultPolicy( builder => {

        builder.WithOrigins("https://localhost:[xxxx]", "https://localhost:[xxxx]")
                            .AllowAnyHeader()
                            .AllowAnyOrigin()
                            .AllowAnyMethod();

    });
});

app.UseCors(); app.UseCors(builder => { builder .AllowAnyOrigin() .AllowAnyMethod() .AllowAnyHeader(); });

This program only verifies the Code provided in the HTML form and basis on that Code checks whether an employee Verified or Not.
We have used Hard Code List to store employee information.
We have designed an Custom Employee Class also to simplify the operation.
