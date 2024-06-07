// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Raid.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Raid.proto</summary>
  public static partial class RaidReflection {

    #region Descriptor
    /// <summary>File descriptor for Raid.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RaidReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpSYWlkLnByb3RvGhZSYWlkVGFyZ2V0U3RhdHVzLnByb3RvIl8KBFJhaWQS",
            "EwoLQUVHSENFSkNPQUEYDCABKA0SLQoScmFpZF90YXJnZXRfc3RhdHVzGA4g",
            "ASgOMhEuUmFpZFRhcmdldFN0YXR1cxITCgtCSENDQkRJQU9OSRgJIAEoDUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RaidTargetStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Raid), global::EggLink.DanhengServer.Proto.Raid.Parser, new[]{ "AEGHCEJCOAA", "RaidTargetStatus", "BHCCBDIAONI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Raid : pb::IMessage<Raid>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Raid> _parser = new pb::MessageParser<Raid>(() => new Raid());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Raid> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RaidReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Raid() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Raid(Raid other) : this() {
      aEGHCEJCOAA_ = other.aEGHCEJCOAA_;
      raidTargetStatus_ = other.raidTargetStatus_;
      bHCCBDIAONI_ = other.bHCCBDIAONI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Raid Clone() {
      return new Raid(this);
    }

    /// <summary>Field number for the "AEGHCEJCOAA" field.</summary>
    public const int AEGHCEJCOAAFieldNumber = 12;
    private uint aEGHCEJCOAA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AEGHCEJCOAA {
      get { return aEGHCEJCOAA_; }
      set {
        aEGHCEJCOAA_ = value;
      }
    }

    /// <summary>Field number for the "raid_target_status" field.</summary>
    public const int RaidTargetStatusFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.RaidTargetStatus raidTargetStatus_ = global::EggLink.DanhengServer.Proto.RaidTargetStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RaidTargetStatus RaidTargetStatus {
      get { return raidTargetStatus_; }
      set {
        raidTargetStatus_ = value;
      }
    }

    /// <summary>Field number for the "BHCCBDIAONI" field.</summary>
    public const int BHCCBDIAONIFieldNumber = 9;
    private uint bHCCBDIAONI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BHCCBDIAONI {
      get { return bHCCBDIAONI_; }
      set {
        bHCCBDIAONI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Raid);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Raid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AEGHCEJCOAA != other.AEGHCEJCOAA) return false;
      if (RaidTargetStatus != other.RaidTargetStatus) return false;
      if (BHCCBDIAONI != other.BHCCBDIAONI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AEGHCEJCOAA != 0) hash ^= AEGHCEJCOAA.GetHashCode();
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) hash ^= RaidTargetStatus.GetHashCode();
      if (BHCCBDIAONI != 0) hash ^= BHCCBDIAONI.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (BHCCBDIAONI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BHCCBDIAONI);
      }
      if (AEGHCEJCOAA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AEGHCEJCOAA);
      }
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) RaidTargetStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BHCCBDIAONI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BHCCBDIAONI);
      }
      if (AEGHCEJCOAA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AEGHCEJCOAA);
      }
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) RaidTargetStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AEGHCEJCOAA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AEGHCEJCOAA);
      }
      if (RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RaidTargetStatus);
      }
      if (BHCCBDIAONI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BHCCBDIAONI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Raid other) {
      if (other == null) {
        return;
      }
      if (other.AEGHCEJCOAA != 0) {
        AEGHCEJCOAA = other.AEGHCEJCOAA;
      }
      if (other.RaidTargetStatus != global::EggLink.DanhengServer.Proto.RaidTargetStatus.None) {
        RaidTargetStatus = other.RaidTargetStatus;
      }
      if (other.BHCCBDIAONI != 0) {
        BHCCBDIAONI = other.BHCCBDIAONI;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 72: {
            BHCCBDIAONI = input.ReadUInt32();
            break;
          }
          case 96: {
            AEGHCEJCOAA = input.ReadUInt32();
            break;
          }
          case 112: {
            RaidTargetStatus = (global::EggLink.DanhengServer.Proto.RaidTargetStatus) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 72: {
            BHCCBDIAONI = input.ReadUInt32();
            break;
          }
          case 96: {
            AEGHCEJCOAA = input.ReadUInt32();
            break;
          }
          case 112: {
            RaidTargetStatus = (global::EggLink.DanhengServer.Proto.RaidTargetStatus) input.ReadEnum();
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