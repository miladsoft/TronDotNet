// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/api/zksnark.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TronNet.Protocol {
  public static partial class TronZksnark
  {
    static readonly string __ServiceName = "protocol.TronZksnark";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::TronNet.Protocol.ZksnarkRequest> __Marshaller_protocol_ZksnarkRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TronNet.Protocol.ZksnarkRequest.Parser));
    static readonly grpc::Marshaller<global::TronNet.Protocol.ZksnarkResponse> __Marshaller_protocol_ZksnarkResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TronNet.Protocol.ZksnarkResponse.Parser));

    static readonly grpc::Method<global::TronNet.Protocol.ZksnarkRequest, global::TronNet.Protocol.ZksnarkResponse> __Method_CheckZksnarkProof = new grpc::Method<global::TronNet.Protocol.ZksnarkRequest, global::TronNet.Protocol.ZksnarkResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckZksnarkProof",
        __Marshaller_protocol_ZksnarkRequest,
        __Marshaller_protocol_ZksnarkResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TronNet.Protocol.ZksnarkReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for TronZksnark</summary>
    public partial class TronZksnarkClient : grpc::ClientBase<TronZksnarkClient>
    {
      /// <summary>Creates a new client for TronZksnark</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TronZksnarkClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TronZksnark that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TronZksnarkClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TronZksnarkClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TronZksnarkClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::TronNet.Protocol.ZksnarkResponse CheckZksnarkProof(global::TronNet.Protocol.ZksnarkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckZksnarkProof(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TronNet.Protocol.ZksnarkResponse CheckZksnarkProof(global::TronNet.Protocol.ZksnarkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckZksnarkProof, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TronNet.Protocol.ZksnarkResponse> CheckZksnarkProofAsync(global::TronNet.Protocol.ZksnarkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckZksnarkProofAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TronNet.Protocol.ZksnarkResponse> CheckZksnarkProofAsync(global::TronNet.Protocol.ZksnarkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckZksnarkProof, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TronZksnarkClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TronZksnarkClient(configuration);
      }
    }

  }
}
#endregion
