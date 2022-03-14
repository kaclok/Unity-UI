// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: EntitySync.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Logic.Pbf {

  #region Enums
  public enum EEntityStatus {
    Idle = 0,
    Walk = 1,
    Run = 2,
    Colect = 3,
  }

  public enum EKeyboardOp {
    W = 0,
    A = 1,
    S = 2,
    D = 3,
  }

  public enum EOp {
    OpA = 0,
  }

  public enum EBattleOp {
    BopA = 0,
  }

  #endregion

  #region Messages
  public sealed class TypeID : pb::IMessage {
    private static readonly pb::MessageParser<TypeID> _parser = new pb::MessageParser<TypeID>(() => new TypeID());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TypeID> Parser { get { return _parser; } }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    /// <summary>
    /// id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
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
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class Entity : pb::IMessage {
    private static readonly pb::MessageParser<Entity> _parser = new pb::MessageParser<Entity>(() => new Entity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Entity> Parser { get { return _parser; } }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Logic.Pbf.EEntityStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.EEntityStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private global::Logic.Pbf.FloatVector3 position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.FloatVector3 Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 3;
    private global::Logic.Pbf.FloatVector3 rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.FloatVector3 Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "scale" field.</summary>
    public const int ScaleFieldNumber = 4;
    private global::Logic.Pbf.FloatVector3 scale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.FloatVector3 Scale {
      get { return scale_; }
      set {
        scale_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 5;
    private global::Logic.Pbf.FloatVector3 speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.FloatVector3 Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "accelerate" field.</summary>
    public const int AccelerateFieldNumber = 6;
    private global::Logic.Pbf.FloatVector3 accelerate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.FloatVector3 Accelerate {
      get { return accelerate_; }
      set {
        accelerate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Rotation);
      }
      if (scale_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Scale);
      }
      if (speed_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Speed);
      }
      if (accelerate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Accelerate);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (scale_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scale);
      }
      if (speed_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Speed);
      }
      if (accelerate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Accelerate);
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
            status_ = (global::Logic.Pbf.EEntityStatus) input.ReadEnum();
            break;
          }
          case 18: {
            if (position_ == null) {
              position_ = new global::Logic.Pbf.FloatVector3();
            }
            input.ReadMessage(position_);
            break;
          }
          case 26: {
            if (rotation_ == null) {
              rotation_ = new global::Logic.Pbf.FloatVector3();
            }
            input.ReadMessage(rotation_);
            break;
          }
          case 34: {
            if (scale_ == null) {
              scale_ = new global::Logic.Pbf.FloatVector3();
            }
            input.ReadMessage(scale_);
            break;
          }
          case 42: {
            if (speed_ == null) {
              speed_ = new global::Logic.Pbf.FloatVector3();
            }
            input.ReadMessage(speed_);
            break;
          }
          case 50: {
            if (accelerate_ == null) {
              accelerate_ = new global::Logic.Pbf.FloatVector3();
            }
            input.ReadMessage(accelerate_);
            break;
          }
        }
      }
    }

  }

  public sealed class OpCommand : pb::IMessage {
    private static readonly pb::MessageParser<OpCommand> _parser = new pb::MessageParser<OpCommand>(() => new OpCommand());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OpCommand> Parser { get { return _parser; } }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private global::Logic.Pbf.EOp op_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.EOp Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 2;
    private int param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Op != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Op);
      }
      if (Param != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Param);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Op != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Op);
      }
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param);
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
            op_ = (global::Logic.Pbf.EOp) input.ReadEnum();
            break;
          }
          case 16: {
            Param = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class CSAddEntity : pb::IMessage {
    private static readonly pb::MessageParser<CSAddEntity> _parser = new pb::MessageParser<CSAddEntity>(() => new CSAddEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CSAddEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "typeID" field.</summary>
    public const int TypeIDFieldNumber = 1;
    private global::Logic.Pbf.TypeID typeID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.TypeID TypeID {
      get { return typeID_; }
      set {
        typeID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (typeID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypeID);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeID);
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
            if (typeID_ == null) {
              typeID_ = new global::Logic.Pbf.TypeID();
            }
            input.ReadMessage(typeID_);
            break;
          }
        }
      }
    }

  }

  public sealed class SCAddEntity : pb::IMessage {
    private static readonly pb::MessageParser<SCAddEntity> _parser = new pb::MessageParser<SCAddEntity>(() => new SCAddEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SCAddEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "typeID" field.</summary>
    public const int TypeIDFieldNumber = 1;
    private global::Logic.Pbf.TypeID typeID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.TypeID TypeID {
      get { return typeID_; }
      set {
        typeID_ = value;
      }
    }

    /// <summary>Field number for the "csvID" field.</summary>
    public const int CsvIDFieldNumber = 2;
    private uint csvID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint CsvID {
      get { return csvID_; }
      set {
        csvID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (typeID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypeID);
      }
      if (CsvID != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CsvID);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeID);
      }
      if (CsvID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CsvID);
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
            if (typeID_ == null) {
              typeID_ = new global::Logic.Pbf.TypeID();
            }
            input.ReadMessage(typeID_);
            break;
          }
          case 16: {
            CsvID = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class CSRemoveEntity : pb::IMessage {
    private static readonly pb::MessageParser<CSRemoveEntity> _parser = new pb::MessageParser<CSRemoveEntity>(() => new CSRemoveEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CSRemoveEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "typeID" field.</summary>
    public const int TypeIDFieldNumber = 1;
    private global::Logic.Pbf.TypeID typeID_;
    /// <summary>
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.TypeID TypeID {
      get { return typeID_; }
      set {
        typeID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (typeID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypeID);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeID);
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
            if (typeID_ == null) {
              typeID_ = new global::Logic.Pbf.TypeID();
            }
            input.ReadMessage(typeID_);
            break;
          }
        }
      }
    }

  }

  public sealed class SCRemoveEntity : pb::IMessage {
    private static readonly pb::MessageParser<SCRemoveEntity> _parser = new pb::MessageParser<SCRemoveEntity>(() => new SCRemoveEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SCRemoveEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "typeID" field.</summary>
    public const int TypeIDFieldNumber = 1;
    private global::Logic.Pbf.TypeID typeID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.TypeID TypeID {
      get { return typeID_; }
      set {
        typeID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (typeID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypeID);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeID);
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
            if (typeID_ == null) {
              typeID_ = new global::Logic.Pbf.TypeID();
            }
            input.ReadMessage(typeID_);
            break;
          }
        }
      }
    }

  }

  public sealed class CSUpdateEntity : pb::IMessage {
    private static readonly pb::MessageParser<CSUpdateEntity> _parser = new pb::MessageParser<CSUpdateEntity>(() => new CSUpdateEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CSUpdateEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "typeID" field.</summary>
    public const int TypeIDFieldNumber = 1;
    private global::Logic.Pbf.TypeID typeID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.TypeID TypeID {
      get { return typeID_; }
      set {
        typeID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (typeID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypeID);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeID);
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
            if (typeID_ == null) {
              typeID_ = new global::Logic.Pbf.TypeID();
            }
            input.ReadMessage(typeID_);
            break;
          }
        }
      }
    }

  }

  public sealed class SCUpdateEntity : pb::IMessage {
    private static readonly pb::MessageParser<SCUpdateEntity> _parser = new pb::MessageParser<SCUpdateEntity>(() => new SCUpdateEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SCUpdateEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "typeID" field.</summary>
    public const int TypeIDFieldNumber = 1;
    private global::Logic.Pbf.TypeID typeID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.TypeID TypeID {
      get { return typeID_; }
      set {
        typeID_ = value;
      }
    }

    /// <summary>Field number for the "entity" field.</summary>
    public const int EntityFieldNumber = 2;
    private global::Logic.Pbf.Entity entity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.Entity Entity {
      get { return entity_; }
      set {
        entity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (typeID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypeID);
      }
      if (entity_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Entity);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeID);
      }
      if (entity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Entity);
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
            if (typeID_ == null) {
              typeID_ = new global::Logic.Pbf.TypeID();
            }
            input.ReadMessage(typeID_);
            break;
          }
          case 18: {
            if (entity_ == null) {
              entity_ = new global::Logic.Pbf.Entity();
            }
            input.ReadMessage(entity_);
            break;
          }
        }
      }
    }

  }

  public sealed class CSOpEntity : pb::IMessage {
    private static readonly pb::MessageParser<CSOpEntity> _parser = new pb::MessageParser<CSOpEntity>(() => new CSOpEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CSOpEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "typeID" field.</summary>
    public const int TypeIDFieldNumber = 1;
    private global::Logic.Pbf.TypeID typeID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.TypeID TypeID {
      get { return typeID_; }
      set {
        typeID_ = value;
      }
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 2;
    private global::Logic.Pbf.OpCommand op_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.OpCommand Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    /// <summary>Field number for the "entity" field.</summary>
    public const int EntityFieldNumber = 3;
    private global::Logic.Pbf.Entity entity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.Entity Entity {
      get { return entity_; }
      set {
        entity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (typeID_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypeID);
      }
      if (op_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Op);
      }
      if (entity_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Entity);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeID_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypeID);
      }
      if (op_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Op);
      }
      if (entity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Entity);
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
            if (typeID_ == null) {
              typeID_ = new global::Logic.Pbf.TypeID();
            }
            input.ReadMessage(typeID_);
            break;
          }
          case 18: {
            if (op_ == null) {
              op_ = new global::Logic.Pbf.OpCommand();
            }
            input.ReadMessage(op_);
            break;
          }
          case 26: {
            if (entity_ == null) {
              entity_ = new global::Logic.Pbf.Entity();
            }
            input.ReadMessage(entity_);
            break;
          }
        }
      }
    }

  }

  public sealed class SCOpEntity : pb::IMessage {
    private static readonly pb::MessageParser<SCOpEntity> _parser = new pb::MessageParser<SCOpEntity>(() => new SCOpEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SCOpEntity> Parser { get { return _parser; } }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private global::Logic.Pbf.SCUpdateEntity op_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.SCUpdateEntity Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (op_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Op);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (op_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Op);
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
            if (op_ == null) {
              op_ = new global::Logic.Pbf.SCUpdateEntity();
            }
            input.ReadMessage(op_);
            break;
          }
        }
      }
    }

  }

  public sealed class InitTime : pb::IMessage {
    private static readonly pb::MessageParser<InitTime> _parser = new pb::MessageParser<InitTime>(() => new InitTime());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitTime> Parser { get { return _parser; } }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 1;
    private global::Logic.Pbf.RefreshTime time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.RefreshTime Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "timeZone" field.</summary>
    public const int TimeZoneFieldNumber = 2;
    private float timeZone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TimeZone {
      get { return timeZone_; }
      set {
        timeZone_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (time_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Time);
      }
      if (TimeZone != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TimeZone);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (time_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Time);
      }
      if (TimeZone != 0F) {
        size += 1 + 4;
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
            if (time_ == null) {
              time_ = new global::Logic.Pbf.RefreshTime();
            }
            input.ReadMessage(time_);
            break;
          }
          case 21: {
            TimeZone = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed class RefreshTime : pb::IMessage {
    private static readonly pb::MessageParser<RefreshTime> _parser = new pb::MessageParser<RefreshTime>(() => new RefreshTime());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RefreshTime> Parser { get { return _parser; } }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 1;
    private ulong time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Time != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Time);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Time != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Time);
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
            Time = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///客户端操作记录
  /// </summary>
  public sealed class BattleOpCommand : pb::IMessage {
    private static readonly pb::MessageParser<BattleOpCommand> _parser = new pb::MessageParser<BattleOpCommand>(() => new BattleOpCommand());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BattleOpCommand> Parser { get { return _parser; } }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private global::Logic.Pbf.EBattleOp op_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Pbf.EBattleOp Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 2;
    private int param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Op != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Op);
      }
      if (Param != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Param);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Op != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Op);
      }
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param);
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
            op_ = (global::Logic.Pbf.EBattleOp) input.ReadEnum();
            break;
          }
          case 16: {
            Param = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class BattleOp : pb::IMessage {
    private static readonly pb::MessageParser<BattleOp> _parser = new pb::MessageParser<BattleOp>(() => new BattleOp());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BattleOp> Parser { get { return _parser; } }

    /// <summary>Field number for the "frame" field.</summary>
    public const int FrameFieldNumber = 1;
    private uint frame_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Frame {
      get { return frame_; }
      set {
        frame_ = value;
      }
    }

    /// <summary>Field number for the "ops" field.</summary>
    public const int OpsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Logic.Pbf.OpCommand> _repeated_ops_codec
        = pb::FieldCodec.ForMessage(18, global::Logic.Pbf.OpCommand.Parser);
    private readonly pbc::RepeatedField<global::Logic.Pbf.OpCommand> ops_ = new pbc::RepeatedField<global::Logic.Pbf.OpCommand>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Logic.Pbf.OpCommand> Ops {
      get { return ops_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Frame != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Frame);
      }
      ops_.WriteTo(output, _repeated_ops_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Frame != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Frame);
      }
      size += ops_.CalculateSize(_repeated_ops_codec);
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
            Frame = input.ReadUInt32();
            break;
          }
          case 18: {
            ops_.AddEntriesFrom(input, _repeated_ops_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code