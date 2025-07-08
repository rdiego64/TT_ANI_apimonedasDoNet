FROM mcr.microsoft.com/donet/asnet:8.0 AS base
WORKDIR /app
ENV ASPNETCORE_URL=http://=:5235

# Exponer puerto a utlizar en la aplicacion
EXPOSE 5335

FROM mcr.microsoft.com/donet/asnet:8.0 AS base
