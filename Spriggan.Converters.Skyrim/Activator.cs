// THIS FILE IS AUTOGENERATED DO NOT EDIT BY HAND
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using Mutagen.Bethesda.Skyrim;
using Spriggan.Converters.Base;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Strings;
using Microsoft.Extensions.DependencyInjection;
using Mutagen.Bethesda.Plugins.Records;

public class IActivatorGetter_Converter : JsonConverter<IActivatorGetter>
{
  public override IActivatorGetter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    throw new NotImplementedException();
  }
  public override void Write(Utf8JsonWriter writer, IActivatorGetter value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();
    writer.WriteFormKeyHeader(value, options);
    
    // ActivateTextOverride
    writer.WritePropertyName("ActivateTextOverride");
    writer.WriteTranslatedString(value.ActivateTextOverride, options);
    
    // ActivationSound
    writer.WritePropertyName("ActivationSound");
    if (value.ActivationSound.IsNull)
      writer.WriteNullValue();
    else
      writer.WriteStringValue(value.ActivationSound.FormKey.ToString());
    
    // Destructible
    writer.WritePropertyName("Destructible");
    if (value.Destructible != null)
    {
      writer.WriteStartObject();
      
      // Data
      writer.WritePropertyName("Data");
      if (value.Destructible.Data != null)
      {
        writer.WriteStartObject();
        
        // Health
        writer.WritePropertyName("Health");
        writer.WriteNumberValue((long)value.Destructible.Data.Health);
        
        // DESTCount
        writer.WritePropertyName("DESTCount");
        writer.WriteNumberValue((long)value.Destructible.Data.DESTCount);
        
        // VATSTargetable
        writer.WritePropertyName("VATSTargetable");
        writer.WriteBooleanValue(value.Destructible.Data.VATSTargetable);
        
        // Unknown
        writer.WritePropertyName("Unknown");
        writer.WriteNumberValue((long)value.Destructible.Data.Unknown);
        writer.WriteEndObject();
      }
      else
      {
        writer.WriteNullValue();
      }
      
      // Stages
      writer.WritePropertyName("Stages");
      if (value.Destructible.Stages != null)
      {
        writer.WriteStartArray();
        foreach(var itm1 in value.Destructible.Stages)
        {
          if (itm1 != null)
          {
            writer.WriteStartObject();
            
            // Data
            writer.WritePropertyName("Data");
            if (itm1.Data != null)
            {
              writer.WriteStartObject();
              
              // HealthPercent
              writer.WritePropertyName("HealthPercent");
              writer.WriteNumberValue((long)itm1.Data.HealthPercent);
              
              // Index
              writer.WritePropertyName("Index");
              writer.WriteNumberValue((long)itm1.Data.Index);
              
              // ModelDamageStage
              writer.WritePropertyName("ModelDamageStage");
              writer.WriteNumberValue((long)itm1.Data.ModelDamageStage);
              
              // Flags
              writer.WritePropertyName("Flags");
              writer.WriteEnum(itm1.Data.Flags);
              
              // SelfDamagePerSecond
              writer.WritePropertyName("SelfDamagePerSecond");
              writer.WriteNumberValue((long)itm1.Data.SelfDamagePerSecond);
              
              // Explosion
              writer.WritePropertyName("Explosion");
              writer.WriteStringValue(itm1.Data.Explosion.FormKey.ToString());
              
              // Debris
              writer.WritePropertyName("Debris");
              writer.WriteStringValue(itm1.Data.Debris.FormKey.ToString());
              
              // DebrisCount
              writer.WritePropertyName("DebrisCount");
              writer.WriteNumberValue((long)itm1.Data.DebrisCount);
              writer.WriteEndObject();
            }
            else
            {
              writer.WriteNullValue();
            }
            
            // Model
            writer.WritePropertyName("Model");
            if (itm1.Model != null)
            {
              writer.WriteStartObject();
              
              // AlternateTextures
              writer.WritePropertyName("AlternateTextures");
              if (itm1.Model.AlternateTextures != null)
              {
                writer.WriteStartArray();
                foreach(var itm2 in itm1.Model.AlternateTextures)
                {
                  if (itm2 != null)
                  {
                    writer.WriteStartObject();
                    
                    // Name
                    writer.WritePropertyName("Name");
                    writer.WriteStringValue(itm2.Name);
                    
                    // NewTexture
                    writer.WritePropertyName("NewTexture");
                    writer.WriteStringValue(itm2.NewTexture.FormKey.ToString());
                    
                    // Index
                    writer.WritePropertyName("Index");
                    writer.WriteNumberValue((long)itm2.Index);
                    writer.WriteEndObject();
                  }
                  else
                  {
                    writer.WriteNullValue();
                  }
                }
                writer.WriteEndArray();
              }
              else
              {
                writer.WriteNullValue();
              }
              
              // File
              writer.WritePropertyName("File");
              writer.WriteStringValue(itm1.Model.File);
              
              // Data
              writer.WritePropertyName("Data");
              if (itm1.Model.Data == null)
                writer.WriteNullValue();
              else
              {
                writer.WriteBase64StringValue(itm1.Model.Data.Value);
              }
              writer.WriteEndObject();
            }
            else
            {
              writer.WriteNullValue();
            }
            writer.WriteEndObject();
          }
          else
          {
            writer.WriteNullValue();
          }
        }
        writer.WriteEndArray();
      }
      else
      {
        writer.WriteNullValue();
      }
      writer.WriteEndObject();
    }
    else
    {
      writer.WriteNullValue();
    }
    
    // EditorID
    writer.WritePropertyName("EditorID");
    writer.WriteStringValue(value.EditorID);
    
    // Flags
    writer.WritePropertyName("Flags");
    if (value.Flags == null)
      writer.WriteNullValue();
    else
    {
      writer.WriteFlags(value.Flags.Value);
    }
    
    // InteractionKeyword
    writer.WritePropertyName("InteractionKeyword");
    if (value.InteractionKeyword.IsNull)
      writer.WriteNullValue();
    else
      writer.WriteStringValue(value.InteractionKeyword.FormKey.ToString());
    
    // IsCompressed
    writer.WritePropertyName("IsCompressed");
    writer.WriteBooleanValue(value.IsCompressed);
    
    // IsDeleted
    writer.WritePropertyName("IsDeleted");
    writer.WriteBooleanValue(value.IsDeleted);
    
    // Keywords
    writer.WritePropertyName("Keywords");
    if (value.Keywords != null)
    {
      writer.WriteStartArray();
      foreach(var itm3 in value.Keywords)
      {
        writer.WriteStringValue(itm3.FormKey.ToString());
      }
      writer.WriteEndArray();
    }
    else
    {
      writer.WriteNullValue();
    }
    
    // LoopingSound
    writer.WritePropertyName("LoopingSound");
    if (value.LoopingSound.IsNull)
      writer.WriteNullValue();
    else
      writer.WriteStringValue(value.LoopingSound.FormKey.ToString());
    
    // MajorFlags
    writer.WritePropertyName("MajorFlags");
    writer.WriteFlags(value.MajorFlags);
    
    // MajorRecordFlagsRaw
    writer.WritePropertyName("MajorRecordFlagsRaw");
    writer.WriteNumberValue((long)value.MajorRecordFlagsRaw);
    
    // MarkerColor
    writer.WritePropertyName("MarkerColor");
    if (value.MarkerColor == null)
      writer.WriteNullValue();
    else
    {
      writer.WriteStringValue(value.MarkerColor.Value.ToArgb().ToString("x8"));
    }
    
    // Model
    writer.WritePropertyName("Model");
    if (value.Model != null)
    {
      writer.WriteStartObject();
      
      // AlternateTextures
      writer.WritePropertyName("AlternateTextures");
      if (value.Model.AlternateTextures != null)
      {
        writer.WriteStartArray();
        foreach(var itm4 in value.Model.AlternateTextures)
        {
          if (itm4 != null)
          {
            writer.WriteStartObject();
            
            // Name
            writer.WritePropertyName("Name");
            writer.WriteStringValue(itm4.Name);
            
            // NewTexture
            writer.WritePropertyName("NewTexture");
            writer.WriteStringValue(itm4.NewTexture.FormKey.ToString());
            
            // Index
            writer.WritePropertyName("Index");
            writer.WriteNumberValue((long)itm4.Index);
            writer.WriteEndObject();
          }
          else
          {
            writer.WriteNullValue();
          }
        }
        writer.WriteEndArray();
      }
      else
      {
        writer.WriteNullValue();
      }
      
      // File
      writer.WritePropertyName("File");
      writer.WriteStringValue(value.Model.File);
      
      // Data
      writer.WritePropertyName("Data");
      if (value.Model.Data == null)
        writer.WriteNullValue();
      else
      {
        writer.WriteBase64StringValue(value.Model.Data.Value);
      }
      writer.WriteEndObject();
    }
    else
    {
      writer.WriteNullValue();
    }
    
    // Name
    writer.WritePropertyName("Name");
    writer.WriteTranslatedString(value.Name, options);
    
    // ObjectBounds
    writer.WritePropertyName("ObjectBounds");
    if (value.ObjectBounds != null)
    {
      writer.WriteStartObject();
      
      // First
      writer.WritePropertyName("First");
      writer.WriteP3Int16(value.ObjectBounds.First, options);
      
      // Second
      writer.WritePropertyName("Second");
      writer.WriteP3Int16(value.ObjectBounds.Second, options);
      writer.WriteEndObject();
    }
    else
    {
      writer.WriteNullValue();
    }
    
    // Version2
    writer.WritePropertyName("Version2");
    writer.WriteNumberValue((uint)value.Version2);
    
    // VersionControl
    writer.WritePropertyName("VersionControl");
    writer.WriteNumberValue((long)value.VersionControl);
    
    // VirtualMachineAdapter
    writer.WritePropertyName("VirtualMachineAdapter");
    if (value.VirtualMachineAdapter != null)
    {
      writer.WriteStartObject();
      
      // Version
      writer.WritePropertyName("Version");
      writer.WriteNumberValue((long)value.VirtualMachineAdapter.Version);
      
      // ObjectFormat
      writer.WritePropertyName("ObjectFormat");
      writer.WriteNumberValue((uint)value.VirtualMachineAdapter.ObjectFormat);
      
      // Scripts
      writer.WritePropertyName("Scripts");
      if (value.VirtualMachineAdapter.Scripts != null)
      {
        writer.WriteStartArray();
        foreach(var itm5 in value.VirtualMachineAdapter.Scripts)
        {
          if (itm5 != null)
          {
            writer.WriteStartObject();
            
            // Name
            writer.WritePropertyName("Name");
            writer.WriteStringValue(itm5.Name);
            
            // Flags
            writer.WritePropertyName("Flags");
            writer.WriteEnum(itm5.Flags);
            
            // Properties
            writer.WritePropertyName("Properties");
            if (itm5.Properties != null)
            {
              writer.WriteStartArray();
              foreach(var itm6 in itm5.Properties)
              {
                if (itm6 != null)
                {
                  writer.WriteStartObject();
                  
                  // Name
                  writer.WritePropertyName("Name");
                  writer.WriteStringValue(itm6.Name);
                  
                  // Flags
                  writer.WritePropertyName("Flags");
                  writer.WriteEnum(itm6.Flags);
                  writer.WriteEndObject();
                }
                else
                {
                  writer.WriteNullValue();
                }
              }
              writer.WriteEndArray();
            }
            else
            {
              writer.WriteNullValue();
            }
            writer.WriteEndObject();
          }
          else
          {
            writer.WriteNullValue();
          }
        }
        writer.WriteEndArray();
      }
      else
      {
        writer.WriteNullValue();
      }
      writer.WriteEndObject();
    }
    else
    {
      writer.WriteNullValue();
    }
    
    // WaterType
    writer.WritePropertyName("WaterType");
    if (value.WaterType.IsNull)
      writer.WriteNullValue();
    else
      writer.WriteStringValue(value.WaterType.FormKey.ToString());
    writer.WriteEndObject();
  }
}
public class Activator_Converter : JsonConverter<Mutagen.Bethesda.Skyrim.Activator>
{
  private IActivatorGetter_Converter _getterConverter;
  public Activator_Converter()
  {
    _getterConverter = new IActivatorGetter_Converter();
  }
  public override void Write(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.Activator value, JsonSerializerOptions options)
  {
    _getterConverter.Write(writer, (IActivatorGetter)value, options);
  }
  public override Mutagen.Bethesda.Skyrim.Activator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType != JsonTokenType.StartObject)
        throw new JsonException();
    reader.Read();
    var retval = new Mutagen.Bethesda.Skyrim.Activator(SerializerExtensions.ReadFormKeyHeader(ref reader, options), SkyrimRelease.SkyrimSE);
    while (true)
    {
      reader.Read();
      if (reader.TokenType == JsonTokenType.EndObject)
      {
        reader.Read();
        break;
      }
      var prop = reader.GetString();
      reader.Read();
      switch (prop)
      {
        case "ActivateTextOverride":
          retval.ActivateTextOverride ??= new TranslatedString(Language.English);
          SerializerExtensions.ReadTranslatedString(ref reader, retval.ActivateTextOverride, options);
          break;
        case "ActivationSound":
          if (reader.TokenType != JsonTokenType.Null)
            retval.ActivationSound.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
          break;
        case "Destructible":
          retval.Destructible = new Mutagen.Bethesda.Skyrim.Destructible();
          if (reader.TokenType != JsonTokenType.Null)
          {
            if (reader.TokenType != JsonTokenType.StartObject)
              throw new JsonException();
            while (true)
            {
              reader.Read();
              if (reader.TokenType == JsonTokenType.EndObject)
                break;
              var prop7 = reader.GetString();
              reader.Read();
              switch(prop7)
              {
                case "Data":
                  retval.Destructible.Data = new Mutagen.Bethesda.Skyrim.DestructableData();
                  if (reader.TokenType != JsonTokenType.Null)
                  {
                    if (reader.TokenType != JsonTokenType.StartObject)
                      throw new JsonException();
                    while (true)
                    {
                      reader.Read();
                      if (reader.TokenType == JsonTokenType.EndObject)
                        break;
                      var prop8 = reader.GetString();
                      reader.Read();
                      switch(prop8)
                      {
                        case "Health":
                          retval.Destructible.Data.Health = reader.GetInt32();
                          break;
                        case "DESTCount":
                          retval.Destructible.Data.DESTCount = reader.GetByte();
                          break;
                        case "VATSTargetable":
                          retval.Destructible.Data.VATSTargetable = reader.GetBoolean();
                          break;
                        case "Unknown":
                          retval.Destructible.Data.Unknown = reader.GetInt16();
                          break;
                      }
                    }
                  }
                  else
                  {
                    reader.Skip();
                  }
                  break;
                case "Stages":
                  if (reader.TokenType != JsonTokenType.Null)
                  {
                    if (reader.TokenType != JsonTokenType.StartArray)
                      throw new JsonException();
                    while (true)
                    {
                      reader.Read();
                      if (reader.TokenType == JsonTokenType.EndArray)
                        break;
                      var itm9 = new Mutagen.Bethesda.Skyrim.DestructionStage();
                      if (reader.TokenType != JsonTokenType.Null)
                      {
                        if (reader.TokenType != JsonTokenType.StartObject)
                          throw new JsonException();
                        while (true)
                        {
                          reader.Read();
                          if (reader.TokenType == JsonTokenType.EndObject)
                            break;
                          var prop10 = reader.GetString();
                          reader.Read();
                          switch(prop10)
                          {
                            case "Data":
                              itm9.Data = new Mutagen.Bethesda.Skyrim.DestructionStageData();
                              if (reader.TokenType != JsonTokenType.Null)
                              {
                                if (reader.TokenType != JsonTokenType.StartObject)
                                  throw new JsonException();
                                while (true)
                                {
                                  reader.Read();
                                  if (reader.TokenType == JsonTokenType.EndObject)
                                    break;
                                  var prop11 = reader.GetString();
                                  reader.Read();
                                  switch(prop11)
                                  {
                                    case "HealthPercent":
                                      itm9.Data.HealthPercent = reader.GetByte();
                                      break;
                                    case "Index":
                                      itm9.Data.Index = reader.GetByte();
                                      break;
                                    case "ModelDamageStage":
                                      itm9.Data.ModelDamageStage = reader.GetByte();
                                      break;
                                    case "Flags":
                                      itm9.Data.Flags = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.DestructionStageData.Flag>(ref reader, options);
                                      break;
                                    case "SelfDamagePerSecond":
                                      itm9.Data.SelfDamagePerSecond = reader.GetInt32();
                                      break;
                                    case "Explosion":
                                      itm9.Data.Explosion.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                      break;
                                    case "Debris":
                                      itm9.Data.Debris.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                      break;
                                    case "DebrisCount":
                                      itm9.Data.DebrisCount = reader.GetInt32();
                                      break;
                                  }
                                }
                              }
                              else
                              {
                                reader.Skip();
                              }
                              break;
                            case "Model":
                              itm9.Model = new Mutagen.Bethesda.Skyrim.Model();
                              if (reader.TokenType != JsonTokenType.Null)
                              {
                                if (reader.TokenType != JsonTokenType.StartObject)
                                  throw new JsonException();
                                while (true)
                                {
                                  reader.Read();
                                  if (reader.TokenType == JsonTokenType.EndObject)
                                    break;
                                  var prop12 = reader.GetString();
                                  reader.Read();
                                  switch(prop12)
                                  {
                                    case "AlternateTextures":
                                      if (reader.TokenType != JsonTokenType.Null)
                                      {
                                        itm9.Model.AlternateTextures ??= new();
                                        if (reader.TokenType != JsonTokenType.StartArray)
                                          throw new JsonException();
                                        while (true)
                                        {
                                          reader.Read();
                                          if (reader.TokenType == JsonTokenType.EndArray)
                                            break;
                                          var itm13 = new Mutagen.Bethesda.Skyrim.AlternateTexture();
                                          if (reader.TokenType != JsonTokenType.Null)
                                          {
                                            if (reader.TokenType != JsonTokenType.StartObject)
                                              throw new JsonException();
                                            while (true)
                                            {
                                              reader.Read();
                                              if (reader.TokenType == JsonTokenType.EndObject)
                                                break;
                                              var prop14 = reader.GetString();
                                              reader.Read();
                                              switch(prop14)
                                              {
                                                case "Name":
                                                  itm13.Name = reader.GetString();
                                                  break;
                                                case "NewTexture":
                                                  itm13.NewTexture.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                                  break;
                                                case "Index":
                                                  itm13.Index = reader.GetInt32();
                                                  break;
                                              }
                                            }
                                          }
                                          else
                                          {
                                            reader.Skip();
                                          }
                                          itm9.Model.AlternateTextures.Add(itm13);
                                        }
                                      }
                                      break;
                                    case "File":
                                      itm9.Model.File = reader.GetString();
                                      break;
                                    case "Data":
                                      if (reader.TokenType != JsonTokenType.Null) {
                                        itm9.Model.Data = reader.GetBytesFromBase64();
                                      }
                                      break;
                                  }
                                }
                              }
                              else
                              {
                                reader.Skip();
                              }
                              break;
                          }
                        }
                      }
                      else
                      {
                        reader.Skip();
                      }
                      retval.Destructible.Stages.Add(itm9);
                    }
                  }
                  break;
              }
            }
          }
          else
          {
            reader.Skip();
          }
          break;
        case "EditorID":
          retval.EditorID = reader.GetString();
          break;
        case "Flags":
          if (reader.TokenType != JsonTokenType.Null) {
            retval.Flags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.Activator.Flag>(ref reader, options);
          }
          break;
        case "FormVersion":
          retval.FormVersion = reader.GetUInt16();
          break;
        case "InteractionKeyword":
          if (reader.TokenType != JsonTokenType.Null)
            retval.InteractionKeyword.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
          break;
        case "IsCompressed":
          retval.IsCompressed = reader.GetBoolean();
          break;
        case "IsDeleted":
          retval.IsDeleted = reader.GetBoolean();
          break;
        case "Keywords":
          if (reader.TokenType != JsonTokenType.Null)
          {
            retval.Keywords ??= new();
            if (reader.TokenType != JsonTokenType.StartArray)
              throw new JsonException();
            while (true)
            {
              reader.Read();
              if (reader.TokenType == JsonTokenType.EndArray)
                break;
              retval.Keywords.Add(SerializerExtensions.ReadFormKeyValue(ref reader, options));
            }
          }
          break;
        case "LoopingSound":
          if (reader.TokenType != JsonTokenType.Null)
            retval.LoopingSound.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
          break;
        case "MajorFlags":
          retval.MajorFlags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.Activator.MajorFlag>(ref reader, options);
          break;
        case "MajorRecordFlagsRaw":
          retval.MajorRecordFlagsRaw = reader.GetInt32();
          break;
        case "MarkerColor":
          if (reader.TokenType != JsonTokenType.Null) {
            retval.MarkerColor = Color.FromArgb(int.Parse(reader.GetString()));
          }
          break;
        case "Model":
          retval.Model = new Mutagen.Bethesda.Skyrim.Model();
          if (reader.TokenType != JsonTokenType.Null)
          {
            if (reader.TokenType != JsonTokenType.StartObject)
              throw new JsonException();
            while (true)
            {
              reader.Read();
              if (reader.TokenType == JsonTokenType.EndObject)
                break;
              var prop15 = reader.GetString();
              reader.Read();
              switch(prop15)
              {
                case "AlternateTextures":
                  if (reader.TokenType != JsonTokenType.Null)
                  {
                    retval.Model.AlternateTextures ??= new();
                    if (reader.TokenType != JsonTokenType.StartArray)
                      throw new JsonException();
                    while (true)
                    {
                      reader.Read();
                      if (reader.TokenType == JsonTokenType.EndArray)
                        break;
                      var itm16 = new Mutagen.Bethesda.Skyrim.AlternateTexture();
                      if (reader.TokenType != JsonTokenType.Null)
                      {
                        if (reader.TokenType != JsonTokenType.StartObject)
                          throw new JsonException();
                        while (true)
                        {
                          reader.Read();
                          if (reader.TokenType == JsonTokenType.EndObject)
                            break;
                          var prop17 = reader.GetString();
                          reader.Read();
                          switch(prop17)
                          {
                            case "Name":
                              itm16.Name = reader.GetString();
                              break;
                            case "NewTexture":
                              itm16.NewTexture.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                              break;
                            case "Index":
                              itm16.Index = reader.GetInt32();
                              break;
                          }
                        }
                      }
                      else
                      {
                        reader.Skip();
                      }
                      retval.Model.AlternateTextures.Add(itm16);
                    }
                  }
                  break;
                case "File":
                  retval.Model.File = reader.GetString();
                  break;
                case "Data":
                  if (reader.TokenType != JsonTokenType.Null) {
                    retval.Model.Data = reader.GetBytesFromBase64();
                  }
                  break;
              }
            }
          }
          else
          {
            reader.Skip();
          }
          break;
        case "Name":
          retval.Name ??= new TranslatedString(Language.English);
          SerializerExtensions.ReadTranslatedString(ref reader, retval.Name, options);
          break;
        case "ObjectBounds":
          retval.ObjectBounds = new Mutagen.Bethesda.Skyrim.ObjectBounds();
          if (reader.TokenType != JsonTokenType.Null)
          {
            if (reader.TokenType != JsonTokenType.StartObject)
              throw new JsonException();
            while (true)
            {
              reader.Read();
              if (reader.TokenType == JsonTokenType.EndObject)
                break;
              var prop18 = reader.GetString();
              reader.Read();
              switch(prop18)
              {
                case "First":
                  retval.ObjectBounds.First = SerializerExtensions.ReadP3Int16(ref reader, options);
                  break;
                case "Second":
                  retval.ObjectBounds.Second = SerializerExtensions.ReadP3Int16(ref reader, options);
                  break;
              }
            }
          }
          else
          {
            reader.Skip();
          }
          break;
        case "SkyrimMajorRecordFlags":
          retval.SkyrimMajorRecordFlags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.SkyrimMajorRecord.SkyrimMajorRecordFlag>(ref reader, options);
          break;
        case "Version2":
          retval.Version2 = reader.GetUInt16();
          break;
        case "VersionControl":
          retval.VersionControl = reader.GetUInt32();
          break;
        case "VirtualMachineAdapter":
          retval.VirtualMachineAdapter = new Mutagen.Bethesda.Skyrim.VirtualMachineAdapter();
          if (reader.TokenType != JsonTokenType.Null)
          {
            if (reader.TokenType != JsonTokenType.StartObject)
              throw new JsonException();
            while (true)
            {
              reader.Read();
              if (reader.TokenType == JsonTokenType.EndObject)
                break;
              var prop19 = reader.GetString();
              reader.Read();
              switch(prop19)
              {
                case "Version":
                  retval.VirtualMachineAdapter.Version = reader.GetInt16();
                  break;
                case "ObjectFormat":
                  retval.VirtualMachineAdapter.ObjectFormat = reader.GetUInt16();
                  break;
                case "Scripts":
                  if (reader.TokenType != JsonTokenType.Null)
                  {
                    if (reader.TokenType != JsonTokenType.StartArray)
                      throw new JsonException();
                    while (true)
                    {
                      reader.Read();
                      if (reader.TokenType == JsonTokenType.EndArray)
                        break;
                      var itm20 = new Mutagen.Bethesda.Skyrim.ScriptEntry();
                      if (reader.TokenType != JsonTokenType.Null)
                      {
                        if (reader.TokenType != JsonTokenType.StartObject)
                          throw new JsonException();
                        while (true)
                        {
                          reader.Read();
                          if (reader.TokenType == JsonTokenType.EndObject)
                            break;
                          var prop21 = reader.GetString();
                          reader.Read();
                          switch(prop21)
                          {
                            case "Name":
                              itm20.Name = reader.GetString();
                              break;
                            case "Flags":
                              itm20.Flags = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.ScriptEntry.Flag>(ref reader, options);
                              break;
                            case "Properties":
                              if (reader.TokenType != JsonTokenType.Null)
                              {
                                if (reader.TokenType != JsonTokenType.StartArray)
                                  throw new JsonException();
                                while (true)
                                {
                                  reader.Read();
                                  if (reader.TokenType == JsonTokenType.EndArray)
                                    break;
                                  var itm22 = new Mutagen.Bethesda.Skyrim.ScriptProperty();
                                  if (reader.TokenType != JsonTokenType.Null)
                                  {
                                    if (reader.TokenType != JsonTokenType.StartObject)
                                      throw new JsonException();
                                    while (true)
                                    {
                                      reader.Read();
                                      if (reader.TokenType == JsonTokenType.EndObject)
                                        break;
                                      var prop23 = reader.GetString();
                                      reader.Read();
                                      switch(prop23)
                                      {
                                        case "Name":
                                          itm22.Name = reader.GetString();
                                          break;
                                        case "Flags":
                                          itm22.Flags = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.ScriptProperty.Flag>(ref reader, options);
                                          break;
                                      }
                                    }
                                  }
                                  else
                                  {
                                    reader.Skip();
                                  }
                                  itm20.Properties.Add(itm22);
                                }
                              }
                              break;
                          }
                        }
                      }
                      else
                      {
                        reader.Skip();
                      }
                      retval.VirtualMachineAdapter.Scripts.Add(itm20);
                    }
                  }
                  break;
              }
            }
          }
          else
          {
            reader.Skip();
          }
          break;
        case "WaterType":
          if (reader.TokenType != JsonTokenType.Null)
            retval.WaterType.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
          break;
        default:
            reader.Skip();
            break;
      }
    }
    return retval;
  }
}
