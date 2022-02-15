# Recorder API

This is a test app for building a web API in ASP.NET Core based on an OpenAPI
specification.

Loosely inspired by
[this API tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code)
and [this OpenAPI article](https://developers.redhat.com/blog/2020/09/16/using-openapi-with-net-core#writing_openapi_descriptions).

I was hoping to get it an OpenAPI specification and it would use it to generate 
some scaffolding, but it worked bettwe the other way around.  I created the
endpoints in `RecorderApiController` and it generated the OpenAPI documentation.

## To Run

```bash
dotnet run
```

The service will then run on [localhost:7086](https://localhost:7086/).

The OpenAPI documenation is at [localhost:7086/swagger](https://localhost:7086/swagger/index.html).

## To Record Calls

```bash
http --verify no POST https://localhost:7086/api/recorderapi
```

With an optional `name`:

```bash
http --verify no POST https://localhost:7086/api/recorderapi name==Jean
```

## To Get a Call Count

```bash
http --verify no https://localhost:7086/api/recorderapi
```
