// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/value.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/value.proto</summary>
  public static partial class ValueReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/value.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS92YWx1ZS5wcm90bxIaZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjEaHGdvb2dsZS9hcGkvYW5ub3RhdGlv",
            "bnMucHJvdG8iVQoFVmFsdWUSEwoJaW50X3ZhbHVlGAEgASgDSAASFgoMZG91",
            "YmxlX3ZhbHVlGAIgASgBSAASFgoMc3RyaW5nX3ZhbHVlGAMgASgJSABCBwoF",
            "dmFsdWVCzgEKHmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUIKVmFs",
            "dWVQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Nsb3VkL2FpcGxhdGZvcm0vdjE7YWlwbGF0Zm9ybaoCGkdvb2dsZS5D",
            "bG91ZC5BSVBsYXRmb3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1c",
            "VjHqAh1Hb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Value), global::Google.Cloud.AIPlatform.V1.Value.Parser, new[]{ "IntValue", "DoubleValue", "StringValue" }, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Value is the value of the field.
  /// </summary>
  public sealed partial class Value : pb::IMessage<Value>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Value> _parser = new pb::MessageParser<Value>(() => new Value());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Value> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.ValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Value(Value other) : this() {
      switch (other.ValueCase) {
        case ValueOneofCase.IntValue:
          IntValue = other.IntValue;
          break;
        case ValueOneofCase.DoubleValue:
          DoubleValue = other.DoubleValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Value Clone() {
      return new Value(this);
    }

    /// <summary>Field number for the "int_value" field.</summary>
    public const int IntValueFieldNumber = 1;
    /// <summary>
    /// An integer value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IntValue {
      get { return valueCase_ == ValueOneofCase.IntValue ? (long) value_ : 0L; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.IntValue;
      }
    }

    /// <summary>Field number for the "double_value" field.</summary>
    public const int DoubleValueFieldNumber = 2;
    /// <summary>
    /// A double value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DoubleValue {
      get { return valueCase_ == ValueOneofCase.DoubleValue ? (double) value_ : 0D; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.DoubleValue;
      }
    }

    /// <summary>Field number for the "string_value" field.</summary>
    public const int StringValueFieldNumber = 3;
    /// <summary>
    /// A string value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StringValue {
      get { return valueCase_ == ValueOneofCase.StringValue ? (string) value_ : ""; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        valueCase_ = ValueOneofCase.StringValue;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      IntValue = 1,
      DoubleValue = 2,
      StringValue = 3,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Value);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntValue != other.IntValue) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DoubleValue, other.DoubleValue)) return false;
      if (StringValue != other.StringValue) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (valueCase_ == ValueOneofCase.IntValue) hash ^= IntValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.DoubleValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DoubleValue);
      if (valueCase_ == ValueOneofCase.StringValue) hash ^= StringValue.GetHashCode();
      hash ^= (int) valueCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (valueCase_ == ValueOneofCase.IntValue) {
        output.WriteRawTag(8);
        output.WriteInt64(IntValue);
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        output.WriteRawTag(17);
        output.WriteDouble(DoubleValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (valueCase_ == ValueOneofCase.IntValue) {
        output.WriteRawTag(8);
        output.WriteInt64(IntValue);
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        output.WriteRawTag(17);
        output.WriteDouble(DoubleValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(26);
        output.WriteString(StringValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (valueCase_ == ValueOneofCase.IntValue) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IntValue);
      }
      if (valueCase_ == ValueOneofCase.DoubleValue) {
        size += 1 + 8;
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Value other) {
      if (other == null) {
        return;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.IntValue:
          IntValue = other.IntValue;
          break;
        case ValueOneofCase.DoubleValue:
          DoubleValue = other.DoubleValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IntValue = input.ReadInt64();
            break;
          }
          case 17: {
            DoubleValue = input.ReadDouble();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            IntValue = input.ReadInt64();
            break;
          }
          case 17: {
            DoubleValue = input.ReadDouble();
            break;
          }
          case 26: {
            StringValue = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code