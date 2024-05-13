using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Unicam.Paradigmi.Application.Models.Options;
using Unicam.Paradigmi.Web.Results;

namespace Unicam.Paradigmi.Web.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            //aggiunta factory per la gestione degli errori
            services.AddControllers().ConfigureApiBehaviorOptions(opt =>
            {
                opt.InvalidModelStateResponseFactory = (context) =>
                {
                    return new BadRequestResultFactory(context);
                };
            }); ;

            //configurazione swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Unicam.Paradigmi",
                    Version = "v1"
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
            });

            //validazione automatica
            services.AddFluentValidationAutoValidation();

            //autenticazione jwt bearer
            var jwt = new JwtAuthenticationOption();
            configuration.GetSection("JwtAuthentication")
            .Bind(jwt);

            services.Configure<JwtAuthenticationOption>(configuration.GetSection("JwtAuthentication"));
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                           .AddJwtBearer(options =>
                           {
                               string key = jwt.Key;
                               var securityKey = new SymmetricSecurityKey(
                                   Encoding.UTF8.GetBytes(key)
                                   );
                               options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                               {
                                   ValidateIssuer = true,
                                   ValidateLifetime = true,
                                   ValidateAudience = false,
                                   ValidateIssuerSigningKey = true,
                                   ValidIssuer = jwt.Issuer,
                                   IssuerSigningKey = securityKey
                               };
                           });

            return services;
        }
    }
}
