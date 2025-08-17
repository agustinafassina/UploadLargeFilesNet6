## Remove the upload limit for file with .NET 6

This is a service for uploading large files with .NET 6. 
<br>
This repository is a copy of https://github.com/agustinafassina/UploadLargeFiles.

## 📄API Reference
#### Endpoint

```http
POST /Upload
```

#### Get file

```http
GET /Upload?${fileName}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `fileName`      | `string` | **Required**. Filename |

#### Run script with dotnet

```bash
  dotnet run
```


* http://localhost:5014/upload
* https://localhost:7161/upload
