# NAL - Números a Letras 
[![Build Status](https://epconccs.visualstudio.com/NAL/_apis/build/status/NAL-Azure%20Web%20App%20for%20ASP.NET-CI?branchName=master)](https://epconccs.visualstudio.com/NAL/_build/latest?definitionId=1&branchName=master)
[![codecov](https://codecov.io/gh/epconccs/numeros-a-letras/branch/master/graph/badge.svg)](https://codecov.io/gh/epconccs/numeros-a-letras)

Este es un proyecto **ASP.NET Core Web API** para convertir números a letras en español.

El API se encuentra publicada en el siguiente enlace -> https://nal.azurewebsites.net/

Prueba -> https://nal.azurewebsites.net/api/NAL/256

*Actualmente el proyecto únicamente acepta cifras de hasta 19 dígitos y acepta hasta 2 decimales.*

## GET /api/NAL

Convierte un número a letras en español.

|Detalles||
|---|---|
|**URL**|`/api/NAL`|
|**Método**|`GET`|
|**Requiere Autenticación**|NO|
|**Path Parameters**|`double num`|
|**Query Parameters**|`double num`|

### Respuesta

**GET** `https://nal.azurewebsites.net/api/NAL/256`

**Code** : `200 OK`

**Body**: `{"letras":"DOSCIENTOS CINCUENTA Y SEIS"}`

---
**GET** `https://nal.azurewebsites.net/api/NAL?num=256`

**Code** : `200 OK`

**Body**: `{"letras":"DOSCIENTOS CINCUENTA Y SEIS"}`

---
**GET** `https://nal.azurewebsites.net/api/NAL/hola`

**Code** : `200 OK`

**Body**: `{"letras":"CERO"}`
