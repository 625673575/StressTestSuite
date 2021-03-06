// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: testsuite_remote.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Remote {
  public static partial class RemoteService
  {
    static readonly string __ServiceName = "remote.RemoteService";

    static readonly grpc::Marshaller<global::Remote.CmdRequest> __Marshaller_CmdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.CmdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.LogReply> __Marshaller_LogReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.LogReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.CaptureParams> __Marshaller_CaptureParams = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.CaptureParams.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.ImageData> __Marshaller_ImageData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.ImageData.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.MouseClickRequest> __Marshaller_MouseClickRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.MouseClickRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.Log> __Marshaller_Log = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.Log.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.KeyTapRequest> __Marshaller_KeyTapRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.KeyTapRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.KeyListTapRequest> __Marshaller_KeyListTapRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.KeyListTapRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.Nil> __Marshaller_Nil = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.Nil.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.MousePosition> __Marshaller_MousePosition = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.MousePosition.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.FileEntrys> __Marshaller_FileEntrys = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.FileEntrys.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Remote.FileData> __Marshaller_FileData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Remote.FileData.Parser.ParseFrom);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.LogReply> __Method_ExecCmd = new grpc::Method<global::Remote.CmdRequest, global::Remote.LogReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ExecCmd",
        __Marshaller_CmdRequest,
        __Marshaller_LogReply);

    static readonly grpc::Method<global::Remote.CaptureParams, global::Remote.ImageData> __Method_CaptureScreen = new grpc::Method<global::Remote.CaptureParams, global::Remote.ImageData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CaptureScreen",
        __Marshaller_CaptureParams,
        __Marshaller_ImageData);

    static readonly grpc::Method<global::Remote.MouseClickRequest, global::Remote.Log> __Method_MouseClick = new grpc::Method<global::Remote.MouseClickRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MouseClick",
        __Marshaller_MouseClickRequest,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.KeyTapRequest, global::Remote.Log> __Method_KeyTap = new grpc::Method<global::Remote.KeyTapRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "KeyTap",
        __Marshaller_KeyTapRequest,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.KeyListTapRequest, global::Remote.Log> __Method_KeyListTap = new grpc::Method<global::Remote.KeyListTapRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "KeyListTap",
        __Marshaller_KeyListTapRequest,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.Nil, global::Remote.MousePosition> __Method_GetMousePosition = new grpc::Method<global::Remote.Nil, global::Remote.MousePosition>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMousePosition",
        __Marshaller_Nil,
        __Marshaller_MousePosition);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.FileEntrys> __Method_ListDir = new grpc::Method<global::Remote.CmdRequest, global::Remote.FileEntrys>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDir",
        __Marshaller_CmdRequest,
        __Marshaller_FileEntrys);

    static readonly grpc::Method<global::Remote.Nil, global::Remote.Log> __Method_ListDisk = new grpc::Method<global::Remote.Nil, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDisk",
        __Marshaller_Nil,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.FileData> __Method_ReadFile = new grpc::Method<global::Remote.CmdRequest, global::Remote.FileData>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadFile",
        __Marshaller_CmdRequest,
        __Marshaller_FileData);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.Log> __Method_ReadText = new grpc::Method<global::Remote.CmdRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadText",
        __Marshaller_CmdRequest,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.FileData, global::Remote.Log> __Method_CreateFile = new grpc::Method<global::Remote.FileData, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateFile",
        __Marshaller_FileData,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.Log> __Method_CreateText = new grpc::Method<global::Remote.CmdRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateText",
        __Marshaller_CmdRequest,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.Log> __Method_Rename = new grpc::Method<global::Remote.CmdRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Rename",
        __Marshaller_CmdRequest,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.Log> __Method_DeleteFile = new grpc::Method<global::Remote.CmdRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteFile",
        __Marshaller_CmdRequest,
        __Marshaller_Log);

    static readonly grpc::Method<global::Remote.CmdRequest, global::Remote.Log> __Method_DeleteFolder = new grpc::Method<global::Remote.CmdRequest, global::Remote.Log>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteFolder",
        __Marshaller_CmdRequest,
        __Marshaller_Log);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Remote.TestsuiteRemoteReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemoteService</summary>
    public abstract partial class RemoteServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Remote.LogReply> ExecCmd(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.ImageData> CaptureScreen(global::Remote.CaptureParams request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> MouseClick(global::Remote.MouseClickRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> KeyTap(global::Remote.KeyTapRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> KeyListTap(global::Remote.KeyListTapRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.MousePosition> GetMousePosition(global::Remote.Nil request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.FileEntrys> ListDir(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> ListDisk(global::Remote.Nil request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.FileData> ReadFile(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> ReadText(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> CreateFile(global::Remote.FileData request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> CreateText(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> Rename(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> DeleteFile(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remote.Log> DeleteFolder(global::Remote.CmdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RemoteService</summary>
    public partial class RemoteServiceClient : grpc::ClientBase<RemoteServiceClient>
    {
      /// <summary>Creates a new client for RemoteService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RemoteServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RemoteService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RemoteServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RemoteServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RemoteServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Remote.LogReply ExecCmd(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ExecCmd(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.LogReply ExecCmd(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ExecCmd, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.LogReply> ExecCmdAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ExecCmdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.LogReply> ExecCmdAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ExecCmd, null, options, request);
      }
      public virtual global::Remote.ImageData CaptureScreen(global::Remote.CaptureParams request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CaptureScreen(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.ImageData CaptureScreen(global::Remote.CaptureParams request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CaptureScreen, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.ImageData> CaptureScreenAsync(global::Remote.CaptureParams request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CaptureScreenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.ImageData> CaptureScreenAsync(global::Remote.CaptureParams request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CaptureScreen, null, options, request);
      }
      public virtual global::Remote.Log MouseClick(global::Remote.MouseClickRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MouseClick(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log MouseClick(global::Remote.MouseClickRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MouseClick, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> MouseClickAsync(global::Remote.MouseClickRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MouseClickAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> MouseClickAsync(global::Remote.MouseClickRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MouseClick, null, options, request);
      }
      public virtual global::Remote.Log KeyTap(global::Remote.KeyTapRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return KeyTap(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log KeyTap(global::Remote.KeyTapRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_KeyTap, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> KeyTapAsync(global::Remote.KeyTapRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return KeyTapAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> KeyTapAsync(global::Remote.KeyTapRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_KeyTap, null, options, request);
      }
      public virtual global::Remote.Log KeyListTap(global::Remote.KeyListTapRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return KeyListTap(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log KeyListTap(global::Remote.KeyListTapRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_KeyListTap, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> KeyListTapAsync(global::Remote.KeyListTapRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return KeyListTapAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> KeyListTapAsync(global::Remote.KeyListTapRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_KeyListTap, null, options, request);
      }
      public virtual global::Remote.MousePosition GetMousePosition(global::Remote.Nil request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetMousePosition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.MousePosition GetMousePosition(global::Remote.Nil request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMousePosition, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.MousePosition> GetMousePositionAsync(global::Remote.Nil request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetMousePositionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.MousePosition> GetMousePositionAsync(global::Remote.Nil request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMousePosition, null, options, request);
      }
      public virtual global::Remote.FileEntrys ListDir(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListDir(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.FileEntrys ListDir(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDir, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.FileEntrys> ListDirAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListDirAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.FileEntrys> ListDirAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDir, null, options, request);
      }
      public virtual global::Remote.Log ListDisk(global::Remote.Nil request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListDisk(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log ListDisk(global::Remote.Nil request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDisk, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> ListDiskAsync(global::Remote.Nil request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListDiskAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> ListDiskAsync(global::Remote.Nil request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDisk, null, options, request);
      }
      public virtual global::Remote.FileData ReadFile(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReadFile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.FileData ReadFile(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadFile, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.FileData> ReadFileAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReadFileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.FileData> ReadFileAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadFile, null, options, request);
      }
      public virtual global::Remote.Log ReadText(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReadText(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log ReadText(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadText, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> ReadTextAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReadTextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> ReadTextAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadText, null, options, request);
      }
      public virtual global::Remote.Log CreateFile(global::Remote.FileData request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateFile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log CreateFile(global::Remote.FileData request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateFile, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> CreateFileAsync(global::Remote.FileData request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateFileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> CreateFileAsync(global::Remote.FileData request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateFile, null, options, request);
      }
      public virtual global::Remote.Log CreateText(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateText(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log CreateText(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateText, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> CreateTextAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateTextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> CreateTextAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateText, null, options, request);
      }
      public virtual global::Remote.Log Rename(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Rename(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log Rename(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Rename, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> RenameAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RenameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> RenameAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Rename, null, options, request);
      }
      public virtual global::Remote.Log DeleteFile(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteFile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log DeleteFile(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteFile, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> DeleteFileAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteFileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> DeleteFileAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteFile, null, options, request);
      }
      public virtual global::Remote.Log DeleteFolder(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteFolder(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remote.Log DeleteFolder(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteFolder, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> DeleteFolderAsync(global::Remote.CmdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteFolderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remote.Log> DeleteFolderAsync(global::Remote.CmdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteFolder, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RemoteServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RemoteServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RemoteServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ExecCmd, serviceImpl.ExecCmd)
          .AddMethod(__Method_CaptureScreen, serviceImpl.CaptureScreen)
          .AddMethod(__Method_MouseClick, serviceImpl.MouseClick)
          .AddMethod(__Method_KeyTap, serviceImpl.KeyTap)
          .AddMethod(__Method_KeyListTap, serviceImpl.KeyListTap)
          .AddMethod(__Method_GetMousePosition, serviceImpl.GetMousePosition)
          .AddMethod(__Method_ListDir, serviceImpl.ListDir)
          .AddMethod(__Method_ListDisk, serviceImpl.ListDisk)
          .AddMethod(__Method_ReadFile, serviceImpl.ReadFile)
          .AddMethod(__Method_ReadText, serviceImpl.ReadText)
          .AddMethod(__Method_CreateFile, serviceImpl.CreateFile)
          .AddMethod(__Method_CreateText, serviceImpl.CreateText)
          .AddMethod(__Method_Rename, serviceImpl.Rename)
          .AddMethod(__Method_DeleteFile, serviceImpl.DeleteFile)
          .AddMethod(__Method_DeleteFolder, serviceImpl.DeleteFolder).Build();
    }

  }
}
#endregion
