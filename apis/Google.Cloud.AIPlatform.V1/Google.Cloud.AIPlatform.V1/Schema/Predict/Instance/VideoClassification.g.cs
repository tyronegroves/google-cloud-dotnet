// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/instance/video_classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Instance {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/instance/video_classification.proto</summary>
  public static partial class VideoClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/instance/video_classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9p",
            "bnN0YW5jZS92aWRlb19jbGFzc2lmaWNhdGlvbi5wcm90bxIyZ29vZ2xlLmNs",
            "b3VkLmFpcGxhdGZvcm0udjEuc2NoZW1hLnByZWRpY3QuaW5zdGFuY2UaHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8igQEKJVZpZGVvQ2xhc3NpZmlj",
            "YXRpb25QcmVkaWN0aW9uSW5zdGFuY2USDwoHY29udGVudBgBIAEoCRIRCglt",
            "aW1lX3R5cGUYAiABKAkSGgoSdGltZV9zZWdtZW50X3N0YXJ0GAMgASgJEhgK",
            "EHRpbWVfc2VnbWVudF9lbmQYBCABKAlC5wIKNmNvbS5nb29nbGUuY2xvdWQu",
            "YWlwbGF0Zm9ybS52MS5zY2hlbWEucHJlZGljdC5pbnN0YW5jZUIqVmlkZW9D",
            "bGFzc2lmaWNhdGlvblByZWRpY3Rpb25JbnN0YW5jZVByb3RvUAFaWmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlwbGF0",
            "Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9pbnN0YW5jZTtpbnN0YW5jZaoCMkdv",
            "b2dsZS5DbG91ZC5BSVBsYXRmb3JtLlYxLlNjaGVtYS5QcmVkaWN0Lkluc3Rh",
            "bmNlygIyR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjFcU2NoZW1hXFByZWRp",
            "Y3RcSW5zdGFuY2XqAjhHb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMTo6",
            "U2NoZW1hOjpQcmVkaWN0OjpJbnN0YW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.VideoClassificationPredictionInstance), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.VideoClassificationPredictionInstance.Parser, new[]{ "Content", "MimeType", "TimeSegmentStart", "TimeSegmentEnd" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction input format for Video Classification.
  /// </summary>
  public sealed partial class VideoClassificationPredictionInstance : pb::IMessage<VideoClassificationPredictionInstance>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VideoClassificationPredictionInstance> _parser = new pb::MessageParser<VideoClassificationPredictionInstance>(() => new VideoClassificationPredictionInstance());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VideoClassificationPredictionInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.VideoClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoClassificationPredictionInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoClassificationPredictionInstance(VideoClassificationPredictionInstance other) : this() {
      content_ = other.content_;
      mimeType_ = other.mimeType_;
      timeSegmentStart_ = other.timeSegmentStart_;
      timeSegmentEnd_ = other.timeSegmentEnd_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoClassificationPredictionInstance Clone() {
      return new VideoClassificationPredictionInstance(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    /// <summary>
    /// The Google Cloud Storage location of the video on which to perform the
    /// prediction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mime_type" field.</summary>
    public const int MimeTypeFieldNumber = 2;
    private string mimeType_ = "";
    /// <summary>
    /// The MIME type of the content of the video. Only the following are
    /// supported: video/mp4 video/avi video/quicktime
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_segment_start" field.</summary>
    public const int TimeSegmentStartFieldNumber = 3;
    private string timeSegmentStart_ = "";
    /// <summary>
    /// The beginning, inclusive, of the video's time segment on which to perform
    /// the prediction. Expressed as a number of seconds as measured from the
    /// start of the video, with "s" appended at the end. Fractions are allowed,
    /// up to a microsecond precision.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeSegmentStart {
      get { return timeSegmentStart_; }
      set {
        timeSegmentStart_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_segment_end" field.</summary>
    public const int TimeSegmentEndFieldNumber = 4;
    private string timeSegmentEnd_ = "";
    /// <summary>
    /// The end, exclusive, of the video's time segment on which to perform
    /// the prediction. Expressed as a number of seconds as measured from the
    /// start of the video, with "s" appended at the end. Fractions are allowed,
    /// up to a microsecond precision, and "inf" or "Infinity" is allowed, which
    /// means the end of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeSegmentEnd {
      get { return timeSegmentEnd_; }
      set {
        timeSegmentEnd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VideoClassificationPredictionInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VideoClassificationPredictionInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (MimeType != other.MimeType) return false;
      if (TimeSegmentStart != other.TimeSegmentStart) return false;
      if (TimeSegmentEnd != other.TimeSegmentEnd) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
      if (TimeSegmentStart.Length != 0) hash ^= TimeSegmentStart.GetHashCode();
      if (TimeSegmentEnd.Length != 0) hash ^= TimeSegmentEnd.GetHashCode();
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
      }
      if (TimeSegmentStart.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TimeSegmentStart);
      }
      if (TimeSegmentEnd.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TimeSegmentEnd);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
      }
      if (TimeSegmentStart.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TimeSegmentStart);
      }
      if (TimeSegmentEnd.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TimeSegmentEnd);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (MimeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MimeType);
      }
      if (TimeSegmentStart.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeSegmentStart);
      }
      if (TimeSegmentEnd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeSegmentEnd);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VideoClassificationPredictionInstance other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.MimeType.Length != 0) {
        MimeType = other.MimeType;
      }
      if (other.TimeSegmentStart.Length != 0) {
        TimeSegmentStart = other.TimeSegmentStart;
      }
      if (other.TimeSegmentEnd.Length != 0) {
        TimeSegmentEnd = other.TimeSegmentEnd;
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
          case 10: {
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
            break;
          }
          case 26: {
            TimeSegmentStart = input.ReadString();
            break;
          }
          case 34: {
            TimeSegmentEnd = input.ReadString();
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
          case 10: {
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
            break;
          }
          case 26: {
            TimeSegmentStart = input.ReadString();
            break;
          }
          case 34: {
            TimeSegmentEnd = input.ReadString();
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