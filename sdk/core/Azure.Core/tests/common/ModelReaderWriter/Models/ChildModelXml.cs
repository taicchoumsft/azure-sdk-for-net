﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Azure.Core.Tests.Common;

namespace Azure.Core.Tests.ModelReaderWriterTests.Models
{
    [XmlRoot("ChildTag")]
    public class ChildModelXml : IXmlSerializable, IModel<ChildModelXml>, IJsonModel<ChildModelXml>, IUtf8JsonSerializable
    {
        internal ChildModelXml() { }

        /// <summary> Initializes a new instance of ModelXml for testing. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChildModelXml(string value, string readonlyProperty)
        {
            Argument.AssertNotNull(value, nameof(value));

            ChildValue = value;
            ChildReadOnlyProperty = readonlyProperty;
        }

        /// <summary> Gets or sets the value. </summary>
        [XmlElement("ChildValue")]
        public string ChildValue { get; set; }
        /// <summary> Gets or sets the value. </summary>
        [XmlElement("ChildReadOnlyProperty")]
        public string ChildReadOnlyProperty { get; }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) =>
            Serialize(writer, ModelReaderWriterOptions.DefaultWireOptions, nameHint);

        private void Serialize(XmlWriter writer, ModelReaderWriterOptions options, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "ChildTag");
            writer.WriteStartElement("ChildValue");
            writer.WriteValue(ChildValue);
            writer.WriteEndElement();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WriteStartElement("ChildReadOnlyProperty");
                writer.WriteValue(ChildReadOnlyProperty);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static ChildModelXml DeserializeChildModelXml(XElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            string value = default;
            string readonlyProperty = default;
            if (element.Element("ChildValue") is XElement valueElement)
            {
                value = (string)valueElement;
            }
            if (element.Element("ChildReadOnlyProperty") is XElement readonlyPropertyElement)
            {
                readonlyProperty = (string)readonlyPropertyElement;
            }
            return new ChildModelXml(value, readonlyProperty);
        }

        internal static ChildModelXml DeserializeChildModelXml(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            string childValue = default;
            string childReadOnlyProperty = default;

            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("childValue"u8))
                {
                    childValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("childReadOnlyProperty"u8))
                {
                    childReadOnlyProperty = property.Value.GetString();
                    continue;
                }
            }
            return new ChildModelXml(childValue, childReadOnlyProperty);
        }

        ChildModelXml IModel<ChildModelXml>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            if (options.Format == ModelReaderWriterFormat.Json)
            {
                using var doc = JsonDocument.Parse(data);
                return DeserializeChildModelXml(doc.RootElement, options);
            }
            else
            {
                return DeserializeChildModelXml(XElement.Load(data.ToStream()), options);
            }
        }

        BinaryData IModel<ChildModelXml>.Write(ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            if (options.Format == ModelReaderWriterFormat.Json)
            {
                return ModelReaderWriter.WriteCore(this, options);
            }
            else
            {
                options ??= ModelReaderWriterOptions.DefaultWireOptions;
                using MemoryStream stream = new MemoryStream();
                using XmlWriter writer = XmlWriter.Create(stream);
                Serialize(writer, options, null);
                writer.Flush();
                if (stream.Position > int.MaxValue)
                {
                    return BinaryData.FromStream(stream);
                }
                else
                {
                    return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
                }
            }
        }

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("childValue"u8);
            writer.WriteStringValue(ChildValue);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("childReadOnlyProperty"u8);
                writer.WriteStringValue(ChildReadOnlyProperty);
            }
            writer.WriteEndObject();
        }

        void IJsonModel<ChildModelXml>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            Serialize(writer, options);
        }

        ChildModelXml IJsonModel<ChildModelXml>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeChildModelXml(doc.RootElement, options);
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) =>
            Serialize(writer, ModelReaderWriterOptions.DefaultWireOptions);
    }
}
