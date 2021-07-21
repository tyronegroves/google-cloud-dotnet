// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/params/image_classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Params {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/params/image_classification.proto</summary>
  public static partial class ImageClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/params/image_classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9w",
            "YXJhbXMvaW1hZ2VfY2xhc3NpZmljYXRpb24ucHJvdG8SMGdvb2dsZS5jbG91",
            "ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS5wcmVkaWN0LnBhcmFtcxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byJcCiNJbWFnZUNsYXNzaWZpY2F0aW9u",
            "UHJlZGljdGlvblBhcmFtcxIcChRjb25maWRlbmNlX3RocmVzaG9sZBgBIAEo",
            "AhIXCg9tYXhfcHJlZGljdGlvbnMYAiABKAVC2QIKNGNvbS5nb29nbGUuY2xv",
            "dWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEucHJlZGljdC5wYXJhbXNCKEltYWdl",
            "Q2xhc3NpZmljYXRpb25QcmVkaWN0aW9uUGFyYW1zUHJvdG9QAVpWZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9haXBsYXRm",
            "b3JtL3YxL3NjaGVtYS9wcmVkaWN0L3BhcmFtcztwYXJhbXOqAjBHb29nbGUu",
            "Q2xvdWQuQUlQbGF0Zm9ybS5WMS5TY2hlbWEuUHJlZGljdC5QYXJhbXPKAjBH",
            "b29nbGVcQ2xvdWRcQUlQbGF0Zm9ybVxWMVxTY2hlbWFcUHJlZGljdFxQYXJh",
            "bXPqAjZHb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMTo6U2NoZW1hOjpQ",
            "cmVkaWN0OjpQYXJhbXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Params.ImageClassificationPredictionParams), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Params.ImageClassificationPredictionParams.Parser, new[]{ "ConfidenceThreshold", "MaxPredictions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction model parameters for Image Classification.
  /// </summary>
  public sealed partial class ImageClassificationPredictionParams : pb::IMessage<ImageClassificationPredictionParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImageClassificationPredictionParams> _parser = new pb::MessageParser<ImageClassificationPredictionParams>(() => new ImageClassificationPredictionParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImageClassificationPredictionParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Params.ImageClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageClassificationPredictionParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageClassificationPredictionParams(ImageClassificationPredictionParams other) : this() {
      confidenceThreshold_ = other.confidenceThreshold_;
      maxPredictions_ = other.maxPredictions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageClassificationPredictionParams Clone() {
      return new ImageClassificationPredictionParams(this);
    }

    /// <summary>Field number for the "confidence_threshold" field.</summary>
    public const int ConfidenceThresholdFieldNumber = 1;
    private float confidenceThreshold_;
    /// <summary>
    /// The Model only returns predictions with at least this confidence score.
    /// Default value is 0.0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ConfidenceThreshold {
      get { return confidenceThreshold_; }
      set {
        confidenceThreshold_ = value;
      }
    }

    /// <summary>Field number for the "max_predictions" field.</summary>
    public const int MaxPredictionsFieldNumber = 2;
    private int maxPredictions_;
    /// <summary>
    /// The Model only returns up to that many top, by confidence score,
    /// predictions per instance. If this number is very high, the Model may return
    /// fewer predictions. Default value is 10.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxPredictions {
      get { return maxPredictions_; }
      set {
        maxPredictions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImageClassificationPredictionParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImageClassificationPredictionParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ConfidenceThreshold, other.ConfidenceThreshold)) return false;
      if (MaxPredictions != other.MaxPredictions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfidenceThreshold != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ConfidenceThreshold);
      if (MaxPredictions != 0) hash ^= MaxPredictions.GetHashCode();
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
      if (ConfidenceThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(ConfidenceThreshold);
      }
      if (MaxPredictions != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxPredictions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ConfidenceThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(ConfidenceThreshold);
      }
      if (MaxPredictions != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxPredictions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ConfidenceThreshold != 0F) {
        size += 1 + 4;
      }
      if (MaxPredictions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPredictions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImageClassificationPredictionParams other) {
      if (other == null) {
        return;
      }
      if (other.ConfidenceThreshold != 0F) {
        ConfidenceThreshold = other.ConfidenceThreshold;
      }
      if (other.MaxPredictions != 0) {
        MaxPredictions = other.MaxPredictions;
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
          case 13: {
            ConfidenceThreshold = input.ReadFloat();
            break;
          }
          case 16: {
            MaxPredictions = input.ReadInt32();
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
          case 13: {
            ConfidenceThreshold = input.ReadFloat();
            break;
          }
          case 16: {
            MaxPredictions = input.ReadInt32();
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