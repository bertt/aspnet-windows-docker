# aspnet-windows-docker

Sample of putting a .NET Framework 4.6 web application with Windows dependency into Docker.

Application does a buffer using SQLGeometry (https://www.nuget.org/packages/Microsoft.SqlServer.Types/):

```
var point = SqlGeometry.Point(4, 7, 4326);
var buffer = point.STBuffer(5);
return buffer.STArea().Value;
```

Sample request with local server: 

Request: HTTP GET http://localhost:49979/api/buffer

Response: 78.5082789238684

## Docker Build

```
$ docker build -t buffer .
```

## Docker Run

```
$ docker run -p 8080:80 buffer
```

In browser go to:

- http://localhost:8080/api/hello

- http://localhost:8080/api/buffer







