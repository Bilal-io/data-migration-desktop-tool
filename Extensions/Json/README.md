# JSON Extension

The JSON data transfer extension provides source and sink capabilities for reading from and writing to JSON files. Source and sink both support string, number, and boolean property values, arrays, and hierarchical nested object structures.

> **Note**: When specifying the JSON extension as the Source or Sink property in configuration, utilize the name **JSON**.

## Settings

Source and sink settings both require a `FilePath` parameter, which should specify a path to a JSON file or folder containing JSON files. The path can be either absolute or relative to the application. The JSON files can contain either an array of JSON objects or a single object. Sink also supports an optional `Indented` parameter (`false` by default) and an optional `IncludeNullFields` parameter (`false` by default) to control the formatting of the JSON output.

### Source

```json
{
    "FilePath": ""
}
```

### Sink

```json
{
    "FilePath": "",
    "Indented": true
}
```

# JSON Extension (beta)

The JSON extension provides formatter capabilities for reading from and writing to JSON files. Read and write  both support string, number, and boolean property values, arrays, and hierarchical nested object structures. 

> **Note**: This is a File Format extension that is only used in combination with Binary Storage extensions. 

> **Note**: When specifying the JSON extension as the Source or Sink property in configuration, utilize the names listed below.

Supported storage sinks:
- File - **Json-File(beta)**
- Azure Blob Storage - **Json-AzureBlob(beta)**
- AWS S3 - **Json-AwsS3(beta)**
 
Supported storage sources:
- File - **Json(beta)**

## Settings

Source does not require any formatter specific settings. Sink supports an optional `Indented` parameter (`false` by default) and an optional `IncludeNullFields` parameter (`false` by default) to control the formatting of the JSON output. See storage extension documentation for any storage specific settings needed ([ex. File Storage](../../Interfaces/Cosmos.DataTransfer.Common/README.md)).

### Source

```json
{
}
```

### Sink

```json
{
    "Indented": true
}
```
