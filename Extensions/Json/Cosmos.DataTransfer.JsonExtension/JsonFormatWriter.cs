﻿using Cosmos.DataTransfer.Interfaces;
using Cosmos.DataTransfer.JsonExtension.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Cosmos.DataTransfer.JsonExtension;

public class JsonFormatWriter : IFormattedDataWriter
{
    public async Task FormatDataAsync(IAsyncEnumerable<IDataItem> dataItems, Stream target, IConfiguration config, ILogger logger, CancellationToken cancellationToken = default)
    {
        var settings = config.Get<JsonFormatWriterSettings>();
        settings.Validate();

        await using var writer = new Utf8JsonWriter(target, new JsonWriterOptions
        {
            Indented = settings.Indented
        });
        writer.WriteStartArray();

        await foreach (var item in dataItems.WithCancellation(cancellationToken))
        {
            DataItemJsonConverter.WriteDataItem(writer, item, settings.IncludeNullFields);
        }

        writer.WriteEndArray();
    }
}