// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueRollDiceScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueRollDiceScRsp.proto</summary>
  public static partial class ChessRogueRollDiceScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueRollDiceScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueRollDiceScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1DaGVzc1JvZ3VlUm9sbERpY2VTY1JzcC5wcm90bxoYQ2hlc3NSb2d1ZURp",
            "Y2VJbmZvLnByb3RvIm0KF0NoZXNzUm9ndWVSb2xsRGljZVNjUnNwEg8KB3Jl",
            "dGNvZGUYBiABKA0SEwoLTkVHT01LTktHSUMYAiABKA0SLAoPcm9ndWVfZGlj",
            "ZV9pbmZvGAogASgLMhMuQ2hlc3NSb2d1ZURpY2VJbmZvQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueDiceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueRollDiceScRsp), global::EggLink.DanhengServer.Proto.ChessRogueRollDiceScRsp.Parser, new[]{ "Retcode", "NEGOMKNKGIC", "RogueDiceInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueRollDiceScRsp : pb::IMessage<ChessRogueRollDiceScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueRollDiceScRsp> _parser = new pb::MessageParser<ChessRogueRollDiceScRsp>(() => new ChessRogueRollDiceScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueRollDiceScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueRollDiceScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueRollDiceScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueRollDiceScRsp(ChessRogueRollDiceScRsp other) : this() {
      retcode_ = other.retcode_;
      nEGOMKNKGIC_ = other.nEGOMKNKGIC_;
      rogueDiceInfo_ = other.rogueDiceInfo_ != null ? other.rogueDiceInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueRollDiceScRsp Clone() {
      return new ChessRogueRollDiceScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "NEGOMKNKGIC" field.</summary>
    public const int NEGOMKNKGICFieldNumber = 2;
    private uint nEGOMKNKGIC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NEGOMKNKGIC {
      get { return nEGOMKNKGIC_; }
      set {
        nEGOMKNKGIC_ = value;
      }
    }

    /// <summary>Field number for the "rogue_dice_info" field.</summary>
    public const int RogueDiceInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo rogueDiceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo RogueDiceInfo {
      get { return rogueDiceInfo_; }
      set {
        rogueDiceInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueRollDiceScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueRollDiceScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (NEGOMKNKGIC != other.NEGOMKNKGIC) return false;
      if (!object.Equals(RogueDiceInfo, other.RogueDiceInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (NEGOMKNKGIC != 0) hash ^= NEGOMKNKGIC.GetHashCode();
      if (rogueDiceInfo_ != null) hash ^= RogueDiceInfo.GetHashCode();
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
      if (NEGOMKNKGIC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(NEGOMKNKGIC);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueDiceInfo);
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
      if (NEGOMKNKGIC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(NEGOMKNKGIC);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueDiceInfo);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (NEGOMKNKGIC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NEGOMKNKGIC);
      }
      if (rogueDiceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDiceInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueRollDiceScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.NEGOMKNKGIC != 0) {
        NEGOMKNKGIC = other.NEGOMKNKGIC;
      }
      if (other.rogueDiceInfo_ != null) {
        if (rogueDiceInfo_ == null) {
          RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
        }
        RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
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
          case 16: {
            NEGOMKNKGIC = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
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
          case 16: {
            NEGOMKNKGIC = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
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