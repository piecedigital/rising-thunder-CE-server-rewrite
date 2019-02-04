// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tbmatch/crash.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rising_Thunder_Server_CS.Protobufs.Tbmatch {

  /// <summary>Holder for reflection information generated from tbmatch/crash.proto</summary>
  public static partial class CrashReflection {

    #region Descriptor
    /// <summary>File descriptor for tbmatch/crash.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrashReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChN0Ym1hdGNoL2NyYXNoLnByb3RvEgd0Ym1hdGNoGhF0YnJwYy90YnJwYy5w",
            "cm90byJhChJDcmFzaFJlcG9ydFJlcXVlc3QSEAoIYXBwX25hbWUYASABKAkS",
            "FQoNYnVpbGRfdmVyc2lvbhgCIAEoCRISCgptYWNoaW5lX2lkGAMgASgJEg4K",
            "BmJ1bmRsZRgEIAEoDDJUChJDcmFzaFJlcG9ydFNlcnZpY2USPgoLQ3Jhc2hS",
            "ZXBvcnQSGy50Ym1hdGNoLkNyYXNoUmVwb3J0UmVxdWVzdBoMLnRicnBjLkVt",
            "cHR5IgTI8xgAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Rising_Thunder_Server_CS.Protobufs.Tbrpc.TbrpcReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rising_Thunder_Server_CS.Protobufs.Tbmatch.CrashReportRequest), global::Rising_Thunder_Server_CS.Protobufs.Tbmatch.CrashReportRequest.Parser, new[]{ "AppName", "BuildVersion", "MachineId", "Bundle" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CrashReportRequest : pb::IMessage<CrashReportRequest> {
    private static readonly pb::MessageParser<CrashReportRequest> _parser = new pb::MessageParser<CrashReportRequest>(() => new CrashReportRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CrashReportRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rising_Thunder_Server_CS.Protobufs.Tbmatch.CrashReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CrashReportRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CrashReportRequest(CrashReportRequest other) : this() {
      appName_ = other.appName_;
      buildVersion_ = other.buildVersion_;
      machineId_ = other.machineId_;
      bundle_ = other.bundle_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CrashReportRequest Clone() {
      return new CrashReportRequest(this);
    }

    /// <summary>Field number for the "app_name" field.</summary>
    public const int AppNameFieldNumber = 1;
    private string appName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppName {
      get { return appName_; }
      set {
        appName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "build_version" field.</summary>
    public const int BuildVersionFieldNumber = 2;
    private string buildVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuildVersion {
      get { return buildVersion_; }
      set {
        buildVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "machine_id" field.</summary>
    public const int MachineIdFieldNumber = 3;
    private string machineId_ = "";
    /// <summary>
    /// Unique Windows identifier for the machine that crashed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MachineId {
      get { return machineId_; }
      set {
        machineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bundle" field.</summary>
    public const int BundleFieldNumber = 4;
    private pb::ByteString bundle_ = pb::ByteString.Empty;
    /// <summary>
    /// Zip of crash report contents
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Bundle {
      get { return bundle_; }
      set {
        bundle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CrashReportRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CrashReportRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppName != other.AppName) return false;
      if (BuildVersion != other.BuildVersion) return false;
      if (MachineId != other.MachineId) return false;
      if (Bundle != other.Bundle) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AppName.Length != 0) hash ^= AppName.GetHashCode();
      if (BuildVersion.Length != 0) hash ^= BuildVersion.GetHashCode();
      if (MachineId.Length != 0) hash ^= MachineId.GetHashCode();
      if (Bundle.Length != 0) hash ^= Bundle.GetHashCode();
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
      if (AppName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AppName);
      }
      if (BuildVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BuildVersion);
      }
      if (MachineId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MachineId);
      }
      if (Bundle.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Bundle);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AppName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppName);
      }
      if (BuildVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuildVersion);
      }
      if (MachineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MachineId);
      }
      if (Bundle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Bundle);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CrashReportRequest other) {
      if (other == null) {
        return;
      }
      if (other.AppName.Length != 0) {
        AppName = other.AppName;
      }
      if (other.BuildVersion.Length != 0) {
        BuildVersion = other.BuildVersion;
      }
      if (other.MachineId.Length != 0) {
        MachineId = other.MachineId;
      }
      if (other.Bundle.Length != 0) {
        Bundle = other.Bundle;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AppName = input.ReadString();
            break;
          }
          case 18: {
            BuildVersion = input.ReadString();
            break;
          }
          case 26: {
            MachineId = input.ReadString();
            break;
          }
          case 34: {
            Bundle = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
