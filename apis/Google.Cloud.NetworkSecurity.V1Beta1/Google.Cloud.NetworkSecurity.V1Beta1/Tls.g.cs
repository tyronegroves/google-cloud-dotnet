// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/networksecurity/v1beta1/tls.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.NetworkSecurity.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/networksecurity/v1beta1/tls.proto</summary>
  public static partial class TlsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/networksecurity/v1beta1/tls.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvY2xvdWQvbmV0d29ya3NlY3VyaXR5L3YxYmV0YTEvdGxzLnBy",
            "b3RvEiRnb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYxYmV0YTEaH2dv",
            "b2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aHGdvb2dsZS9hcGkvYW5u",
            "b3RhdGlvbnMucHJvdG8iJwoMR3JwY0VuZHBvaW50EhcKCnRhcmdldF91cmkY",
            "ASABKAlCA+BBAiLPAQoMVmFsaWRhdGlvbkNBEksKDWdycGNfZW5kcG9pbnQY",
            "AiABKAsyMi5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYxYmV0YTEu",
            "R3JwY0VuZHBvaW50SAASagodY2VydGlmaWNhdGVfcHJvdmlkZXJfaW5zdGFu",
            "Y2UYAyABKAsyQS5nb29nbGUuY2xvdWQubmV0d29ya3NlY3VyaXR5LnYxYmV0",
            "YTEuQ2VydGlmaWNhdGVQcm92aWRlckluc3RhbmNlSABCBgoEdHlwZSI7ChtD",
            "ZXJ0aWZpY2F0ZVByb3ZpZGVySW5zdGFuY2USHAoPcGx1Z2luX2luc3RhbmNl",
            "GAEgASgJQgPgQQIi1gEKE0NlcnRpZmljYXRlUHJvdmlkZXISSwoNZ3JwY19l",
            "bmRwb2ludBgCIAEoCzIyLmdvb2dsZS5jbG91ZC5uZXR3b3Jrc2VjdXJpdHku",
            "djFiZXRhMS5HcnBjRW5kcG9pbnRIABJqCh1jZXJ0aWZpY2F0ZV9wcm92aWRl",
            "cl9pbnN0YW5jZRgDIAEoCzJBLmdvb2dsZS5jbG91ZC5uZXR3b3Jrc2VjdXJp",
            "dHkudjFiZXRhMS5DZXJ0aWZpY2F0ZVByb3ZpZGVySW5zdGFuY2VIAEIGCgR0",
            "eXBlQvkBCihjb20uZ29vZ2xlLmNsb3VkLm5ldHdvcmtzZWN1cml0eS52MWJl",
            "dGExUAFaU2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "Y2xvdWQvbmV0d29ya3NlY3VyaXR5L3YxYmV0YTE7bmV0d29ya3NlY3VyaXR5",
            "qgIkR29vZ2xlLkNsb3VkLk5ldHdvcmtTZWN1cml0eS5WMUJldGExygIkR29v",
            "Z2xlXENsb3VkXE5ldHdvcmtTZWN1cml0eVxWMWJldGEx6gInR29vZ2xlOjpD",
            "bG91ZDo6TmV0d29ya1NlY3VyaXR5OjpWMWJldGExYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint), global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint.Parser, new[]{ "TargetUri" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.NetworkSecurity.V1Beta1.ValidationCA), global::Google.Cloud.NetworkSecurity.V1Beta1.ValidationCA.Parser, new[]{ "GrpcEndpoint", "CertificateProviderInstance" }, new[]{ "Type" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance), global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance.Parser, new[]{ "PluginInstance" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProvider), global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProvider.Parser, new[]{ "GrpcEndpoint", "CertificateProviderInstance" }, new[]{ "Type" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Specification of the GRPC Endpoint.
  /// </summary>
  public sealed partial class GrpcEndpoint : pb::IMessage<GrpcEndpoint>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GrpcEndpoint> _parser = new pb::MessageParser<GrpcEndpoint>(() => new GrpcEndpoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GrpcEndpoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.NetworkSecurity.V1Beta1.TlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcEndpoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcEndpoint(GrpcEndpoint other) : this() {
      targetUri_ = other.targetUri_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcEndpoint Clone() {
      return new GrpcEndpoint(this);
    }

    /// <summary>Field number for the "target_uri" field.</summary>
    public const int TargetUriFieldNumber = 1;
    private string targetUri_ = "";
    /// <summary>
    /// Required. The target URI of the gRPC endpoint. Only UDS path is supported, and
    /// should start with “unix:”.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TargetUri {
      get { return targetUri_; }
      set {
        targetUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GrpcEndpoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GrpcEndpoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetUri != other.TargetUri) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetUri.Length != 0) hash ^= TargetUri.GetHashCode();
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
      if (TargetUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TargetUri);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TargetUri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TargetUri);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TargetUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetUri);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GrpcEndpoint other) {
      if (other == null) {
        return;
      }
      if (other.TargetUri.Length != 0) {
        TargetUri = other.TargetUri;
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
            TargetUri = input.ReadString();
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
            TargetUri = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Specification of ValidationCA. Defines the mechanism to obtain the
  /// Certificate Authority certificate to validate the peer certificate.
  /// </summary>
  public sealed partial class ValidationCA : pb::IMessage<ValidationCA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValidationCA> _parser = new pb::MessageParser<ValidationCA>(() => new ValidationCA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ValidationCA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.NetworkSecurity.V1Beta1.TlsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationCA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationCA(ValidationCA other) : this() {
      switch (other.TypeCase) {
        case TypeOneofCase.GrpcEndpoint:
          GrpcEndpoint = other.GrpcEndpoint.Clone();
          break;
        case TypeOneofCase.CertificateProviderInstance:
          CertificateProviderInstance = other.CertificateProviderInstance.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidationCA Clone() {
      return new ValidationCA(this);
    }

    /// <summary>Field number for the "grpc_endpoint" field.</summary>
    public const int GrpcEndpointFieldNumber = 2;
    /// <summary>
    /// gRPC specific configuration to access the gRPC server to
    /// obtain the CA certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint GrpcEndpoint {
      get { return typeCase_ == TypeOneofCase.GrpcEndpoint ? (global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.GrpcEndpoint;
      }
    }

    /// <summary>Field number for the "certificate_provider_instance" field.</summary>
    public const int CertificateProviderInstanceFieldNumber = 3;
    /// <summary>
    /// The certificate provider instance specification that will be passed to
    /// the data plane, which will be used to load necessary credential
    /// information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance CertificateProviderInstance {
      get { return typeCase_ == TypeOneofCase.CertificateProviderInstance ? (global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.CertificateProviderInstance;
      }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      GrpcEndpoint = 2,
      CertificateProviderInstance = 3,
    }
    private TypeOneofCase typeCase_ = TypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TypeOneofCase TypeCase {
      get { return typeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      typeCase_ = TypeOneofCase.None;
      type_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ValidationCA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ValidationCA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GrpcEndpoint, other.GrpcEndpoint)) return false;
      if (!object.Equals(CertificateProviderInstance, other.CertificateProviderInstance)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) hash ^= GrpcEndpoint.GetHashCode();
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) hash ^= CertificateProviderInstance.GetHashCode();
      hash ^= (int) typeCase_;
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
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcEndpoint);
      }
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
        output.WriteRawTag(26);
        output.WriteMessage(CertificateProviderInstance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcEndpoint);
      }
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
        output.WriteRawTag(26);
        output.WriteMessage(CertificateProviderInstance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrpcEndpoint);
      }
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CertificateProviderInstance);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ValidationCA other) {
      if (other == null) {
        return;
      }
      switch (other.TypeCase) {
        case TypeOneofCase.GrpcEndpoint:
          if (GrpcEndpoint == null) {
            GrpcEndpoint = new global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint();
          }
          GrpcEndpoint.MergeFrom(other.GrpcEndpoint);
          break;
        case TypeOneofCase.CertificateProviderInstance:
          if (CertificateProviderInstance == null) {
            CertificateProviderInstance = new global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance();
          }
          CertificateProviderInstance.MergeFrom(other.CertificateProviderInstance);
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
          case 18: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint();
            if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
              subBuilder.MergeFrom(GrpcEndpoint);
            }
            input.ReadMessage(subBuilder);
            GrpcEndpoint = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance();
            if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
              subBuilder.MergeFrom(CertificateProviderInstance);
            }
            input.ReadMessage(subBuilder);
            CertificateProviderInstance = subBuilder;
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
          case 18: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint();
            if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
              subBuilder.MergeFrom(GrpcEndpoint);
            }
            input.ReadMessage(subBuilder);
            GrpcEndpoint = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance();
            if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
              subBuilder.MergeFrom(CertificateProviderInstance);
            }
            input.ReadMessage(subBuilder);
            CertificateProviderInstance = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Specification of a TLS certificate provider instance. Workloads may have one
  /// or more CertificateProvider instances (plugins) and one of them is enabled
  /// and configured by specifying this message. Workloads use the values from this
  /// message to locate and load the CertificateProvider instance configuration.
  /// </summary>
  public sealed partial class CertificateProviderInstance : pb::IMessage<CertificateProviderInstance>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CertificateProviderInstance> _parser = new pb::MessageParser<CertificateProviderInstance>(() => new CertificateProviderInstance());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CertificateProviderInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.NetworkSecurity.V1Beta1.TlsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateProviderInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateProviderInstance(CertificateProviderInstance other) : this() {
      pluginInstance_ = other.pluginInstance_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateProviderInstance Clone() {
      return new CertificateProviderInstance(this);
    }

    /// <summary>Field number for the "plugin_instance" field.</summary>
    public const int PluginInstanceFieldNumber = 1;
    private string pluginInstance_ = "";
    /// <summary>
    /// Required. Plugin instance name, used to locate and load CertificateProvider instance
    /// configuration. Set to "google_cloud_private_spiffe" to use Certificate
    /// Authority Service certificate provider instance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PluginInstance {
      get { return pluginInstance_; }
      set {
        pluginInstance_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CertificateProviderInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CertificateProviderInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PluginInstance != other.PluginInstance) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PluginInstance.Length != 0) hash ^= PluginInstance.GetHashCode();
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
      if (PluginInstance.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PluginInstance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PluginInstance.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PluginInstance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PluginInstance.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PluginInstance);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CertificateProviderInstance other) {
      if (other == null) {
        return;
      }
      if (other.PluginInstance.Length != 0) {
        PluginInstance = other.PluginInstance;
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
            PluginInstance = input.ReadString();
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
            PluginInstance = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Specification of certificate provider. Defines the mechanism to obtain the
  /// certificate and private key for peer to peer authentication.
  /// </summary>
  public sealed partial class CertificateProvider : pb::IMessage<CertificateProvider>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CertificateProvider> _parser = new pb::MessageParser<CertificateProvider>(() => new CertificateProvider());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CertificateProvider> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.NetworkSecurity.V1Beta1.TlsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateProvider() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateProvider(CertificateProvider other) : this() {
      switch (other.TypeCase) {
        case TypeOneofCase.GrpcEndpoint:
          GrpcEndpoint = other.GrpcEndpoint.Clone();
          break;
        case TypeOneofCase.CertificateProviderInstance:
          CertificateProviderInstance = other.CertificateProviderInstance.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateProvider Clone() {
      return new CertificateProvider(this);
    }

    /// <summary>Field number for the "grpc_endpoint" field.</summary>
    public const int GrpcEndpointFieldNumber = 2;
    /// <summary>
    /// gRPC specific configuration to access the gRPC server to
    /// obtain the cert and private key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint GrpcEndpoint {
      get { return typeCase_ == TypeOneofCase.GrpcEndpoint ? (global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.GrpcEndpoint;
      }
    }

    /// <summary>Field number for the "certificate_provider_instance" field.</summary>
    public const int CertificateProviderInstanceFieldNumber = 3;
    /// <summary>
    /// The certificate provider instance specification that will be passed to
    /// the data plane, which will be used to load necessary credential
    /// information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance CertificateProviderInstance {
      get { return typeCase_ == TypeOneofCase.CertificateProviderInstance ? (global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.CertificateProviderInstance;
      }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      GrpcEndpoint = 2,
      CertificateProviderInstance = 3,
    }
    private TypeOneofCase typeCase_ = TypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TypeOneofCase TypeCase {
      get { return typeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      typeCase_ = TypeOneofCase.None;
      type_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CertificateProvider);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CertificateProvider other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GrpcEndpoint, other.GrpcEndpoint)) return false;
      if (!object.Equals(CertificateProviderInstance, other.CertificateProviderInstance)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) hash ^= GrpcEndpoint.GetHashCode();
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) hash ^= CertificateProviderInstance.GetHashCode();
      hash ^= (int) typeCase_;
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
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcEndpoint);
      }
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
        output.WriteRawTag(26);
        output.WriteMessage(CertificateProviderInstance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcEndpoint);
      }
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
        output.WriteRawTag(26);
        output.WriteMessage(CertificateProviderInstance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrpcEndpoint);
      }
      if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CertificateProviderInstance);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CertificateProvider other) {
      if (other == null) {
        return;
      }
      switch (other.TypeCase) {
        case TypeOneofCase.GrpcEndpoint:
          if (GrpcEndpoint == null) {
            GrpcEndpoint = new global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint();
          }
          GrpcEndpoint.MergeFrom(other.GrpcEndpoint);
          break;
        case TypeOneofCase.CertificateProviderInstance:
          if (CertificateProviderInstance == null) {
            CertificateProviderInstance = new global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance();
          }
          CertificateProviderInstance.MergeFrom(other.CertificateProviderInstance);
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
          case 18: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint();
            if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
              subBuilder.MergeFrom(GrpcEndpoint);
            }
            input.ReadMessage(subBuilder);
            GrpcEndpoint = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance();
            if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
              subBuilder.MergeFrom(CertificateProviderInstance);
            }
            input.ReadMessage(subBuilder);
            CertificateProviderInstance = subBuilder;
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
          case 18: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.GrpcEndpoint();
            if (typeCase_ == TypeOneofCase.GrpcEndpoint) {
              subBuilder.MergeFrom(GrpcEndpoint);
            }
            input.ReadMessage(subBuilder);
            GrpcEndpoint = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance subBuilder = new global::Google.Cloud.NetworkSecurity.V1Beta1.CertificateProviderInstance();
            if (typeCase_ == TypeOneofCase.CertificateProviderInstance) {
              subBuilder.MergeFrom(CertificateProviderInstance);
            }
            input.ReadMessage(subBuilder);
            CertificateProviderInstance = subBuilder;
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