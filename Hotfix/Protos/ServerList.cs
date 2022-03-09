// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ServerList.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Logic.Pbf {

  #region Enums
  public enum EServerState {
    /// <summary>
    /// 正常 
    /// </summary>
    Normal = 0,
    /// <summary>
    /// 繁忙
    /// </summary>
    Busy = 1,
    /// <summary>
    /// 维护
    /// </summary>
    Protected = 2,
  }

  public enum EStateColor {
    Green = 0,
    Red = 1,
    Gray = 2,
    /// <summary>
    /// 按照EServerState处理	  
    /// </summary>
    Auto = 3,
  }

  /// <summary>
  /// 可以 | 
  /// </summary>
  public enum EStateTag {
    /// <summary>
    /// 热
    /// </summary>
    Hot = 0,
    /// <summary>
    /// 新
    /// </summary>
    New = 1,
    /// <summary>
    /// 推荐
    /// </summary>
    Recommend = 2,
  }

  #endregion

  #region Messages
  public sealed class ServerInfo : pb::IMessage {
    private static readonly pb::MessageParser<ServerInfo> _parser = new pb::MessageParser<ServerInfo>(() => new ServerInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerInfo> Parser { get { return _parser; } }

    /// <summary>Field number for the "serverId" field.</summary>
    public const int ServerIdFieldNumber = 1;
    private uint serverId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ServerId {
      get { return serverId_; }
      set {
        serverId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "createTime" field.</summary>
    public const int CreateTimeFieldNumber = 3;
    private uint createTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "lastLoginTime" field.</summary>
    public const int LastLoginTimeFieldNumber = 4;
    private uint lastLoginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint LastLoginTime {
      get { return lastLoginTime_; }
      set {
        lastLoginTime_ = value;
      }
    }

    /// <summary>Field number for the "openTime" field.</summary>
    public const int OpenTimeFieldNumber = 5;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "ip" field.</summary>
    public const int IpFieldNumber = 6;
    private string ip_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ip {
      get { return ip_; }
      set {
        ip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 7;
    private uint port_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 8;
    private global::Logic.Pbf.EServerState state_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.EServerState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 9;
    private global::Logic.Pbf.EStateColor color_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.EStateColor Color {
      get { return color_; }
      set {
        color_ = value;
      }
    }

    /// <summary>Field number for the "tags" field.</summary>
    public const int TagsFieldNumber = 10;
    private global::Logic.Pbf.EStateTag tags_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.EStateTag Tags {
      get { return tags_; }
      set {
        tags_ = value;
      }
    }

    /// <summary>Field number for the "onlineCOunt" field.</summary>
    public const int OnlineCOuntFieldNumber = 11;
    private uint onlineCOunt_;
    /// <summary>
    /// 在线人数
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint OnlineCOunt {
      get { return onlineCOunt_; }
      set {
        onlineCOunt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ServerId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ServerId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (CreateTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CreateTime);
      }
      if (LastLoginTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LastLoginTime);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(OpenTime);
      }
      if (Ip.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Ip);
      }
      if (Port != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Port);
      }
      if (State != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) State);
      }
      if (Color != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Color);
      }
      if (Tags != 0) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Tags);
      }
      if (OnlineCOunt != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OnlineCOunt);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ServerId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (CreateTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CreateTime);
      }
      if (LastLoginTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastLoginTime);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (Ip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ip);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Port);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (Color != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Color);
      }
      if (Tags != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Tags);
      }
      if (OnlineCOunt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OnlineCOunt);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ServerId = input.ReadUInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            CreateTime = input.ReadUInt32();
            break;
          }
          case 32: {
            LastLoginTime = input.ReadUInt32();
            break;
          }
          case 40: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 50: {
            Ip = input.ReadString();
            break;
          }
          case 56: {
            Port = input.ReadUInt32();
            break;
          }
          case 64: {
            state_ = (global::Logic.Pbf.EServerState) input.ReadEnum();
            break;
          }
          case 72: {
            color_ = (global::Logic.Pbf.EStateColor) input.ReadEnum();
            break;
          }
          case 80: {
            tags_ = (global::Logic.Pbf.EStateTag) input.ReadEnum();
            break;
          }
          case 88: {
            OnlineCOunt = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class ServerGroup : pb::IMessage {
    private static readonly pb::MessageParser<ServerGroup> _parser = new pb::MessageParser<ServerGroup>(() => new ServerGroup());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerGroup> Parser { get { return _parser; } }

    /// <summary>Field number for the "groupName" field.</summary>
    public const int GroupNameFieldNumber = 1;
    private string groupName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GroupName {
      get { return groupName_; }
      set {
        groupName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "groupId" field.</summary>
    public const int GroupIdFieldNumber = 2;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "groupSortWeight" field.</summary>
    public const int GroupSortWeightFieldNumber = 3;
    private int groupSortWeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GroupSortWeight {
      get { return groupSortWeight_; }
      set {
        groupSortWeight_ = value;
      }
    }

    /// <summary>Field number for the "serverIdList" field.</summary>
    public const int ServerIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_serverIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> serverIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> ServerIdList {
      get { return serverIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (GroupName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GroupName);
      }
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (GroupSortWeight != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(GroupSortWeight);
      }
      serverIdList_.WriteTo(output, _repeated_serverIdList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GroupName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupName);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (GroupSortWeight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GroupSortWeight);
      }
      size += serverIdList_.CalculateSize(_repeated_serverIdList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            GroupName = input.ReadString();
            break;
          }
          case 16: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 24: {
            GroupSortWeight = input.ReadInt32();
            break;
          }
          case 34:
          case 32: {
            serverIdList_.AddEntriesFrom(input, _repeated_serverIdList_codec);
            break;
          }
        }
      }
    }

  }

  public sealed class ServerRole : pb::IMessage {
    private static readonly pb::MessageParser<ServerRole> _parser = new pb::MessageParser<ServerRole>(() => new ServerRole());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerRole> Parser { get { return _parser; } }

    /// <summary>Field number for the "roleId" field.</summary>
    public const int RoleIdFieldNumber = 1;
    private ulong roleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lv" field.</summary>
    public const int LvFieldNumber = 3;
    private uint lv_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Lv {
      get { return lv_; }
      set {
        lv_ = value;
      }
    }

    /// <summary>Field number for the "heroId" field.</summary>
    public const int HeroIdFieldNumber = 4;
    private uint heroId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint HeroId {
      get { return heroId_; }
      set {
        heroId_ = value;
      }
    }

    /// <summary>Field number for the "careerId" field.</summary>
    public const int CareerIdFieldNumber = 5;
    private uint careerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CareerId {
      get { return careerId_; }
      set {
        careerId_ = value;
      }
    }

    /// <summary>Field number for the "serverId" field.</summary>
    public const int ServerIdFieldNumber = 6;
    private uint serverId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ServerId {
      get { return serverId_; }
      set {
        serverId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoleId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(RoleId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Lv != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Lv);
      }
      if (HeroId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(HeroId);
      }
      if (CareerId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CareerId);
      }
      if (ServerId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ServerId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoleId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RoleId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Lv != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Lv);
      }
      if (HeroId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeroId);
      }
      if (CareerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CareerId);
      }
      if (ServerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ServerId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            RoleId = input.ReadUInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Lv = input.ReadUInt32();
            break;
          }
          case 32: {
            HeroId = input.ReadUInt32();
            break;
          }
          case 40: {
            CareerId = input.ReadUInt32();
            break;
          }
          case 48: {
            ServerId = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class ServerListNtf : pb::IMessage {
    private static readonly pb::MessageParser<ServerListNtf> _parser = new pb::MessageParser<ServerListNtf>(() => new ServerListNtf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerListNtf> Parser { get { return _parser; } }

    /// <summary>Field number for the "serverList" field.</summary>
    public const int ServerListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Logic.Pbf.ServerInfo> _repeated_serverList_codec
        = pb::FieldCodec.ForMessage(10, global::Logic.Pbf.ServerInfo.Parser);
    private readonly pbc::RepeatedField<global::Logic.Pbf.ServerInfo> serverList_ = new pbc::RepeatedField<global::Logic.Pbf.ServerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Logic.Pbf.ServerInfo> ServerList {
      get { return serverList_; }
    }

    /// <summary>Field number for the "serverGroup" field.</summary>
    public const int ServerGroupFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Logic.Pbf.ServerGroup> _repeated_serverGroup_codec
        = pb::FieldCodec.ForMessage(18, global::Logic.Pbf.ServerGroup.Parser);
    private readonly pbc::RepeatedField<global::Logic.Pbf.ServerGroup> serverGroup_ = new pbc::RepeatedField<global::Logic.Pbf.ServerGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Logic.Pbf.ServerGroup> ServerGroup {
      get { return serverGroup_; }
    }

    /// <summary>Field number for the "whiteList" field.</summary>
    public const int WhiteListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Logic.Pbf.ServerInfo> _repeated_whiteList_codec
        = pb::FieldCodec.ForMessage(26, global::Logic.Pbf.ServerInfo.Parser);
    private readonly pbc::RepeatedField<global::Logic.Pbf.ServerInfo> whiteList_ = new pbc::RepeatedField<global::Logic.Pbf.ServerInfo>();
    /// <summary>
    /// 白名单
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Logic.Pbf.ServerInfo> WhiteList {
      get { return whiteList_; }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 4;
    private string signature_ = "";
    /// <summary>
    /// 签名
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extras" field.</summary>
    public const int ExtrasFieldNumber = 5;
    private string extras_ = "";
    /// <summary>
    /// 额外信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Extras {
      get { return extras_; }
      set {
        extras_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      serverList_.WriteTo(output, _repeated_serverList_codec);
      serverGroup_.WriteTo(output, _repeated_serverGroup_codec);
      whiteList_.WriteTo(output, _repeated_whiteList_codec);
      if (Signature.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Signature);
      }
      if (Extras.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Extras);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += serverList_.CalculateSize(_repeated_serverList_codec);
      size += serverGroup_.CalculateSize(_repeated_serverGroup_codec);
      size += whiteList_.CalculateSize(_repeated_whiteList_codec);
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (Extras.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Extras);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            serverList_.AddEntriesFrom(input, _repeated_serverList_codec);
            break;
          }
          case 18: {
            serverGroup_.AddEntriesFrom(input, _repeated_serverGroup_codec);
            break;
          }
          case 26: {
            whiteList_.AddEntriesFrom(input, _repeated_whiteList_codec);
            break;
          }
          case 34: {
            Signature = input.ReadString();
            break;
          }
          case 42: {
            Extras = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
