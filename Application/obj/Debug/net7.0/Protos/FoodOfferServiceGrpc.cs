// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/FoodOfferService.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcClient {
  public static partial class FoodOfferService
  {
    static readonly string __ServiceName = "foodOffer.FoodOfferService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.CreateFoodOfferRequest> __Marshaller_foodOffer_CreateFoodOfferRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.CreateFoodOfferRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.FoodOfferEmptyResponse> __Marshaller_foodOffer_FoodOfferEmptyResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.FoodOfferEmptyResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.ReadAvailableFoodOffersRequest> __Marshaller_foodOffer_ReadAvailableFoodOffersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.ReadAvailableFoodOffersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.ReadFoodOffersListResponse> __Marshaller_foodOffer_ReadFoodOffersListResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.ReadFoodOffersListResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest> __Marshaller_foodOffer_ReadFoodOffersByFoodSellerIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.UpdateFoodOfferRequest> __Marshaller_foodOffer_UpdateFoodOfferRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.UpdateFoodOfferRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.DeleteFoodOfferRequest> __Marshaller_foodOffer_DeleteFoodOfferRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.DeleteFoodOfferRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.ReadFoodOfferByIdRequest> __Marshaller_foodOffer_ReadFoodOfferByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.ReadFoodOfferByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcClient.ReadFoodOfferResponse> __Marshaller_foodOffer_ReadFoodOfferResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcClient.ReadFoodOfferResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcClient.CreateFoodOfferRequest, global::GrpcClient.FoodOfferEmptyResponse> __Method_createFoodOffer = new grpc::Method<global::GrpcClient.CreateFoodOfferRequest, global::GrpcClient.FoodOfferEmptyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "createFoodOffer",
        __Marshaller_foodOffer_CreateFoodOfferRequest,
        __Marshaller_foodOffer_FoodOfferEmptyResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcClient.ReadAvailableFoodOffersRequest, global::GrpcClient.ReadFoodOffersListResponse> __Method_readAvailableFoodOffers = new grpc::Method<global::GrpcClient.ReadAvailableFoodOffersRequest, global::GrpcClient.ReadFoodOffersListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "readAvailableFoodOffers",
        __Marshaller_foodOffer_ReadAvailableFoodOffersRequest,
        __Marshaller_foodOffer_ReadFoodOffersListResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest, global::GrpcClient.ReadFoodOffersListResponse> __Method_readFoodOffersByFoodSellerId = new grpc::Method<global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest, global::GrpcClient.ReadFoodOffersListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "readFoodOffersByFoodSellerId",
        __Marshaller_foodOffer_ReadFoodOffersByFoodSellerIdRequest,
        __Marshaller_foodOffer_ReadFoodOffersListResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcClient.UpdateFoodOfferRequest, global::GrpcClient.FoodOfferEmptyResponse> __Method_updateFoodOffer = new grpc::Method<global::GrpcClient.UpdateFoodOfferRequest, global::GrpcClient.FoodOfferEmptyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "updateFoodOffer",
        __Marshaller_foodOffer_UpdateFoodOfferRequest,
        __Marshaller_foodOffer_FoodOfferEmptyResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcClient.DeleteFoodOfferRequest, global::GrpcClient.FoodOfferEmptyResponse> __Method_deleteFoodOffer = new grpc::Method<global::GrpcClient.DeleteFoodOfferRequest, global::GrpcClient.FoodOfferEmptyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "deleteFoodOffer",
        __Marshaller_foodOffer_DeleteFoodOfferRequest,
        __Marshaller_foodOffer_FoodOfferEmptyResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcClient.ReadFoodOfferByIdRequest, global::GrpcClient.ReadFoodOfferResponse> __Method_readFoodOfferById = new grpc::Method<global::GrpcClient.ReadFoodOfferByIdRequest, global::GrpcClient.ReadFoodOfferResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "readFoodOfferById",
        __Marshaller_foodOffer_ReadFoodOfferByIdRequest,
        __Marshaller_foodOffer_ReadFoodOfferResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcClient.FoodOfferServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for FoodOfferService</summary>
    public partial class FoodOfferServiceClient : grpc::ClientBase<FoodOfferServiceClient>
    {
      /// <summary>Creates a new client for FoodOfferService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FoodOfferServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FoodOfferService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FoodOfferServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FoodOfferServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FoodOfferServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.FoodOfferEmptyResponse createFoodOffer(global::GrpcClient.CreateFoodOfferRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createFoodOffer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.FoodOfferEmptyResponse createFoodOffer(global::GrpcClient.CreateFoodOfferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_createFoodOffer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.FoodOfferEmptyResponse> createFoodOfferAsync(global::GrpcClient.CreateFoodOfferRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createFoodOfferAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.FoodOfferEmptyResponse> createFoodOfferAsync(global::GrpcClient.CreateFoodOfferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_createFoodOffer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.ReadFoodOffersListResponse readAvailableFoodOffers(global::GrpcClient.ReadAvailableFoodOffersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return readAvailableFoodOffers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.ReadFoodOffersListResponse readAvailableFoodOffers(global::GrpcClient.ReadAvailableFoodOffersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_readAvailableFoodOffers, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.ReadFoodOffersListResponse> readAvailableFoodOffersAsync(global::GrpcClient.ReadAvailableFoodOffersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return readAvailableFoodOffersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.ReadFoodOffersListResponse> readAvailableFoodOffersAsync(global::GrpcClient.ReadAvailableFoodOffersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_readAvailableFoodOffers, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.ReadFoodOffersListResponse readFoodOffersByFoodSellerId(global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return readFoodOffersByFoodSellerId(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.ReadFoodOffersListResponse readFoodOffersByFoodSellerId(global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_readFoodOffersByFoodSellerId, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.ReadFoodOffersListResponse> readFoodOffersByFoodSellerIdAsync(global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return readFoodOffersByFoodSellerIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.ReadFoodOffersListResponse> readFoodOffersByFoodSellerIdAsync(global::GrpcClient.ReadFoodOffersByFoodSellerIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_readFoodOffersByFoodSellerId, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.FoodOfferEmptyResponse updateFoodOffer(global::GrpcClient.UpdateFoodOfferRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateFoodOffer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.FoodOfferEmptyResponse updateFoodOffer(global::GrpcClient.UpdateFoodOfferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_updateFoodOffer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.FoodOfferEmptyResponse> updateFoodOfferAsync(global::GrpcClient.UpdateFoodOfferRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return updateFoodOfferAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.FoodOfferEmptyResponse> updateFoodOfferAsync(global::GrpcClient.UpdateFoodOfferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_updateFoodOffer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.FoodOfferEmptyResponse deleteFoodOffer(global::GrpcClient.DeleteFoodOfferRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deleteFoodOffer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.FoodOfferEmptyResponse deleteFoodOffer(global::GrpcClient.DeleteFoodOfferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_deleteFoodOffer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.FoodOfferEmptyResponse> deleteFoodOfferAsync(global::GrpcClient.DeleteFoodOfferRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return deleteFoodOfferAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.FoodOfferEmptyResponse> deleteFoodOfferAsync(global::GrpcClient.DeleteFoodOfferRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_deleteFoodOffer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.ReadFoodOfferResponse readFoodOfferById(global::GrpcClient.ReadFoodOfferByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return readFoodOfferById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcClient.ReadFoodOfferResponse readFoodOfferById(global::GrpcClient.ReadFoodOfferByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_readFoodOfferById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.ReadFoodOfferResponse> readFoodOfferByIdAsync(global::GrpcClient.ReadFoodOfferByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return readFoodOfferByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcClient.ReadFoodOfferResponse> readFoodOfferByIdAsync(global::GrpcClient.ReadFoodOfferByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_readFoodOfferById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FoodOfferServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FoodOfferServiceClient(configuration);
      }
    }

  }
}
#endregion