// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueVirtualItemInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueVirtualItemInfo.proto</summary>
  public static partial class RogueVirtualItemInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueVirtualItemInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueVirtualItemInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZVZpcnR1YWxJdGVtSW5mby5wcm90byJqChRSb2d1ZVZpcnR1YWxJ",
            "dGVtSW5mbxITCgtQQk9PTkVJSEZNQhgEIAEoDRITCgtESEFGR0JOSENBTxgO",
            "IAEoDRITCgtPQ1BJT0VFREJDShgLIAEoDRITCgtKSE1PRkpQS0dJTRgFIAEo",
            "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueVirtualItemInfo), global::EggLink.DanhengServer.Proto.RogueVirtualItemInfo.Parser, new[]{ "PBOONEIHFMB", "DHAFGBNHCAO", "OCPIOEEDBCJ", "JHMOFJPKGIM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueVirtualItemInfo : pb::IMessage<RogueVirtualItemInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueVirtualItemInfo> _parser = new pb::MessageParser<RogueVirtualItemInfo>(() => new RogueVirtualItemInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueVirtualItemInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueVirtualItemInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueVirtualItemInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueVirtualItemInfo(RogueVirtualItemInfo other) : this() {
      pBOONEIHFMB_ = other.pBOONEIHFMB_;
      dHAFGBNHCAO_ = other.dHAFGBNHCAO_;
      oCPIOEEDBCJ_ = other.oCPIOEEDBCJ_;
      jHMOFJPKGIM_ = other.jHMOFJPKGIM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueVirtualItemInfo Clone() {
      return new RogueVirtualItemInfo(this);
    }

    /// <summary>Field number for the "PBOONEIHFMB" field.</summary>
    public const int PBOONEIHFMBFieldNumber = 4;
    private uint pBOONEIHFMB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PBOONEIHFMB {
      get { return pBOONEIHFMB_; }
      set {
        pBOONEIHFMB_ = value;
      }
    }

    /// <summary>Field number for the "DHAFGBNHCAO" field.</summary>
    public const int DHAFGBNHCAOFieldNumber = 14;
    private uint dHAFGBNHCAO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DHAFGBNHCAO {
      get { return dHAFGBNHCAO_; }
      set {
        dHAFGBNHCAO_ = value;
      }
    }

    /// <summary>Field number for the "OCPIOEEDBCJ" field.</summary>
    public const int OCPIOEEDBCJFieldNumber = 11;
    private uint oCPIOEEDBCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OCPIOEEDBCJ {
      get { return oCPIOEEDBCJ_; }
      set {
        oCPIOEEDBCJ_ = value;
      }
    }

    /// <summary>Field number for the "JHMOFJPKGIM" field.</summary>
    public const int JHMOFJPKGIMFieldNumber = 5;
    private uint jHMOFJPKGIM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JHMOFJPKGIM {
      get { return jHMOFJPKGIM_; }
      set {
        jHMOFJPKGIM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueVirtualItemInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueVirtualItemInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PBOONEIHFMB != other.PBOONEIHFMB) return false;
      if (DHAFGBNHCAO != other.DHAFGBNHCAO) return false;
      if (OCPIOEEDBCJ != other.OCPIOEEDBCJ) return false;
      if (JHMOFJPKGIM != other.JHMOFJPKGIM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PBOONEIHFMB != 0) hash ^= PBOONEIHFMB.GetHashCode();
      if (DHAFGBNHCAO != 0) hash ^= DHAFGBNHCAO.GetHashCode();
      if (OCPIOEEDBCJ != 0) hash ^= OCPIOEEDBCJ.GetHashCode();
      if (JHMOFJPKGIM != 0) hash ^= JHMOFJPKGIM.GetHashCode();
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
      if (PBOONEIHFMB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PBOONEIHFMB);
      }
      if (JHMOFJPKGIM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(JHMOFJPKGIM);
      }
      if (OCPIOEEDBCJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OCPIOEEDBCJ);
      }
      if (DHAFGBNHCAO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DHAFGBNHCAO);
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
      if (PBOONEIHFMB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PBOONEIHFMB);
      }
      if (JHMOFJPKGIM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(JHMOFJPKGIM);
      }
      if (OCPIOEEDBCJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OCPIOEEDBCJ);
      }
      if (DHAFGBNHCAO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DHAFGBNHCAO);
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
      if (PBOONEIHFMB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PBOONEIHFMB);
      }
      if (DHAFGBNHCAO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DHAFGBNHCAO);
      }
      if (OCPIOEEDBCJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OCPIOEEDBCJ);
      }
      if (JHMOFJPKGIM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JHMOFJPKGIM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueVirtualItemInfo other) {
      if (other == null) {
        return;
      }
      if (other.PBOONEIHFMB != 0) {
        PBOONEIHFMB = other.PBOONEIHFMB;
      }
      if (other.DHAFGBNHCAO != 0) {
        DHAFGBNHCAO = other.DHAFGBNHCAO;
      }
      if (other.OCPIOEEDBCJ != 0) {
        OCPIOEEDBCJ = other.OCPIOEEDBCJ;
      }
      if (other.JHMOFJPKGIM != 0) {
        JHMOFJPKGIM = other.JHMOFJPKGIM;
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
          case 32: {
            PBOONEIHFMB = input.ReadUInt32();
            break;
          }
          case 40: {
            JHMOFJPKGIM = input.ReadUInt32();
            break;
          }
          case 88: {
            OCPIOEEDBCJ = input.ReadUInt32();
            break;
          }
          case 112: {
            DHAFGBNHCAO = input.ReadUInt32();
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
          case 32: {
            PBOONEIHFMB = input.ReadUInt32();
            break;
          }
          case 40: {
            JHMOFJPKGIM = input.ReadUInt32();
            break;
          }
          case 88: {
            OCPIOEEDBCJ = input.ReadUInt32();
            break;
          }
          case 112: {
            DHAFGBNHCAO = input.ReadUInt32();
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