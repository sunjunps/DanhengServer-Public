// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattleStaticticEventStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattleStaticticEventStatus.proto</summary>
  public static partial class BattleStaticticEventStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleStaticticEventStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleStaticticEventStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBCYXR0bGVTdGF0aWN0aWNFdmVudFN0YXR1cy5wcm90byrjAgoaQmF0dGxl",
            "U3RhdGljdGljRXZlbnRTdGF0dXMSHwobQkFUVExFX1NUQVRJQ1RJQ19FVkVO",
            "VF9OT05FEAASNwozQkFUVExFX1NUQVRJQ1RJQ19FVkVOVF9UUkVBU1VSRV9E",
            "VU5HRU9OX0FERF9FWFBMT1JFEAESNQoxQkFUVExFX1NUQVRJQ1RJQ19FVkVO",
            "VF9UUkVBU1VSRV9EVU5HRU9OX09QRU5fR1JJRBACEjcKM0JBVFRMRV9TVEFU",
            "SUNUSUNfRVZFTlRfVFJFQVNVUkVfRFVOR0VPTl9QSUNLVVBfSVRFTRADEjQK",
            "MEJBVFRMRV9TVEFUSUNUSUNfRVZFTlRfVFJFQVNVUkVfRFVOR0VPTl9VU0Vf",
            "QlVGRhAEEkUKQUJBVFRMRV9TVEFUSUNUSUNfRVZFTlRfVEVMRVZJU0lPTl9B",
            "Q1RJVklUWV9VUERBVEVfTUFaRV9CVUZGX0xBWUVSEAVCHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum BattleStaticticEventStatus {
    [pbr::OriginalName("BATTLE_STATICTIC_EVENT_NONE")] BattleStaticticEventNone = 0,
    [pbr::OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_ADD_EXPLORE")] BattleStaticticEventTreasureDungeonAddExplore = 1,
    [pbr::OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_OPEN_GRID")] BattleStaticticEventTreasureDungeonOpenGrid = 2,
    [pbr::OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_PICKUP_ITEM")] BattleStaticticEventTreasureDungeonPickupItem = 3,
    [pbr::OriginalName("BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_USE_BUFF")] BattleStaticticEventTreasureDungeonUseBuff = 4,
    [pbr::OriginalName("BATTLE_STATICTIC_EVENT_TELEVISION_ACTIVITY_UPDATE_MAZE_BUFF_LAYER")] BattleStaticticEventTelevisionActivityUpdateMazeBuffLayer = 5,
  }

  #endregion

}

#endregion Designer generated code