// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: helloworld.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Helloworld {

  /// <summary>Holder for reflection information generated from helloworld.proto</summary>
  public static partial class HelloworldReflection {

    #region Descriptor
    /// <summary>File descriptor for helloworld.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HelloworldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBoZWxsb3dvcmxkLnByb3RvEgpoZWxsb3dvcmxkIhwKDEhlbGxvUmVxdWVz",
            "dBIMCgRuYW1lGAEgASgJIh0KCkhlbGxvUmVwbHkSDwoHbWVzc2FnZRgBIAEo",
            "CSIiCgpBZGRSZXF1ZXN0EgkKAXgYASADKAUSCQoBeRgCIAMoBSIaCghBZGRS",
            "ZXBseRIOCgZyZXN1bHQYASADKAUiHAoKSW50MzJSZXBseRIOCgZyZXN1bHQY",
            "ASABKAUyhgIKB0dyZWV0ZXISPgoIU2F5SGVsbG8SGC5oZWxsb3dvcmxkLkhl",
            "bGxvUmVxdWVzdBoWLmhlbGxvd29ybGQuSGVsbG9SZXBseSIAEjsKCVJlbW90",
            "ZUFkZBIWLmhlbGxvd29ybGQuQWRkUmVxdWVzdBoULmhlbGxvd29ybGQuQWRk",
            "UmVwbHkiABI7CglSZW1vdGVNYXgSFi5oZWxsb3dvcmxkLkFkZFJlcXVlc3Qa",
            "FC5oZWxsb3dvcmxkLkFkZFJlcGx5IgASQQoPUmVtb3RlUmVkdWNlU3VtEhQu",
            "aGVsbG93b3JsZC5BZGRSZXBseRoWLmhlbGxvd29ybGQuSW50MzJSZXBseSIA",
            "QjAKG2lvLmdycGMuZXhhbXBsZXMuaGVsbG93b3JsZEIPSGVsbG9Xb3JsZFBy",
            "b3RvUAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Helloworld.HelloRequest), global::Helloworld.HelloRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Helloworld.HelloReply), global::Helloworld.HelloReply.Parser, new[]{ "Message" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Helloworld.AddRequest), global::Helloworld.AddRequest.Parser, new[]{ "X", "Y" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Helloworld.AddReply), global::Helloworld.AddReply.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Helloworld.Int32Reply), global::Helloworld.Int32Reply.Parser, new[]{ "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class HelloRequest : pb::IMessage<HelloRequest> {
    private static readonly pb::MessageParser<HelloRequest> _parser = new pb::MessageParser<HelloRequest>(() => new HelloRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HelloRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Helloworld.HelloworldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest(HelloRequest other) : this() {
      name_ = other.name_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest Clone() {
      return new HelloRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HelloRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HelloRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HelloRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
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
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message containing the greetings
  /// </summary>
  public sealed partial class HelloReply : pb::IMessage<HelloReply> {
    private static readonly pb::MessageParser<HelloReply> _parser = new pb::MessageParser<HelloReply>(() => new HelloReply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HelloReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Helloworld.HelloworldReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReply(HelloReply other) : this() {
      message_ = other.message_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReply Clone() {
      return new HelloReply(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HelloReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HelloReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HelloReply other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
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
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddRequest : pb::IMessage<AddRequest> {
    private static readonly pb::MessageParser<AddRequest> _parser = new pb::MessageParser<AddRequest>(() => new AddRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Helloworld.HelloworldReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRequest(AddRequest other) : this() {
      x_ = other.x_.Clone();
      y_ = other.y_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRequest Clone() {
      return new AddRequest(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_x_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> x_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> X {
      get { return x_; }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_y_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> y_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Y {
      get { return y_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!x_.Equals(other.x_)) return false;
      if(!y_.Equals(other.y_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= x_.GetHashCode();
      hash ^= y_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      x_.WriteTo(output, _repeated_x_codec);
      y_.WriteTo(output, _repeated_y_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += x_.CalculateSize(_repeated_x_codec);
      size += y_.CalculateSize(_repeated_y_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddRequest other) {
      if (other == null) {
        return;
      }
      x_.Add(other.x_);
      y_.Add(other.y_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            x_.AddEntriesFrom(input, _repeated_x_codec);
            break;
          }
          case 18:
          case 16: {
            y_.AddEntriesFrom(input, _repeated_y_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddReply : pb::IMessage<AddReply> {
    private static readonly pb::MessageParser<AddReply> _parser = new pb::MessageParser<AddReply>(() => new AddReply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Helloworld.HelloworldReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddReply(AddReply other) : this() {
      result_ = other.result_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddReply Clone() {
      return new AddReply(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_result_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> result_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Result {
      get { return result_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!result_.Equals(other.result_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= result_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      result_.WriteTo(output, _repeated_result_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += result_.CalculateSize(_repeated_result_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddReply other) {
      if (other == null) {
        return;
      }
      result_.Add(other.result_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            result_.AddEntriesFrom(input, _repeated_result_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Int32Reply : pb::IMessage<Int32Reply> {
    private static readonly pb::MessageParser<Int32Reply> _parser = new pb::MessageParser<Int32Reply>(() => new Int32Reply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Int32Reply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Helloworld.HelloworldReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int32Reply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int32Reply(Int32Reply other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int32Reply Clone() {
      return new Int32Reply(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Int32Reply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Int32Reply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Int32Reply other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
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
            Result = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code