// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Time.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Logic.Hotfix.Fixed.Pbf {

  #region Messages
  public sealed class TimeSync : pb::IMessage {
    private static readonly pb::MessageParser<TimeSync> _parser = new pb::MessageParser<TimeSync>(() => new TimeSync());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeSync> Parser { get { return _parser; } }

    /// <summary>Field number for the "timeSeconds" field.</summary>
    public const int TimeSecondsFieldNumber = 1;
    private uint timeSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint TimeSeconds {
      get { return timeSeconds_; }
      set {
        timeSeconds_ = value;
      }
    }

    /// <summary>Field number for the "timeZoneSeconds" field.</summary>
    public const int TimeZoneSecondsFieldNumber = 2;
    private int timeZoneSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TimeZoneSeconds {
      get { return timeZoneSeconds_; }
      set {
        timeZoneSeconds_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TimeSeconds != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TimeSeconds);
      }
      if (TimeZoneSeconds != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TimeZoneSeconds);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TimeSeconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeSeconds);
      }
      if (TimeZoneSeconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeZoneSeconds);
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
            TimeSeconds = input.ReadUInt32();
            break;
          }
          case 16: {
            TimeZoneSeconds = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class SCTimeNtf : pb::IMessage {
    private static readonly pb::MessageParser<SCTimeNtf> _parser = new pb::MessageParser<SCTimeNtf>(() => new SCTimeNtf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SCTimeNtf> Parser { get { return _parser; } }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 1;
    private global::Logic.Hotfix.Fixed.Pbf.TimeSync time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Logic.Hotfix.Fixed.Pbf.TimeSync Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (time_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Time);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (time_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Time);
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
              time_ = new global::Logic.Hotfix.Fixed.Pbf.TimeSync();
            }
            input.ReadMessage(time_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
