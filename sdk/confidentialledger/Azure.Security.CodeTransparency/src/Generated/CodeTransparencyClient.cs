// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Security.CodeTransparency
{
    // Data plane generated client.
    /// <summary> The CodeTransparency service client. </summary>
    public partial class CodeTransparencyClient
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly AzureKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of CodeTransparencyClient for mocking. </summary>
        protected CodeTransparencyClient()
        {
        }

        /// <summary> Initializes a new instance of CodeTransparencyClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public CodeTransparencyClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new CodeTransparencyClientOptions())
        {
        }

        /// <summary> Get the transparency service configuration, mandatory in IETF SCITT draft. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetTransparencyConfigCborAsync(CancellationToken)']/*" />
        public virtual async Task<Response<BinaryData>> GetTransparencyConfigCborAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetTransparencyConfigCborAsync(context).ConfigureAwait(false);
            return Response.FromValue(response.Content, response);
        }

        /// <summary> Get the transparency service configuration, mandatory in IETF SCITT draft. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetTransparencyConfigCbor(CancellationToken)']/*" />
        public virtual Response<BinaryData> GetTransparencyConfigCbor(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetTransparencyConfigCbor(context);
            return Response.FromValue(response.Content, response);
        }

        /// <summary>
        /// [Protocol Method] Get the transparency service configuration, mandatory in IETF SCITT draft
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetTransparencyConfigCborAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetTransparencyConfigCborAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetTransparencyConfigCborAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetTransparencyConfigCbor");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetTransparencyConfigCborRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get the transparency service configuration, mandatory in IETF SCITT draft
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetTransparencyConfigCbor(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetTransparencyConfigCbor(RequestContext)']/*" />
        public virtual Response GetTransparencyConfigCbor(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetTransparencyConfigCbor");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetTransparencyConfigCborRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the public keys used by the service to sign receipts, mentioned in IETF SCITT draft as part of jwks_uri implementation. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetPublicKeysAsync(CancellationToken)']/*" />
        public virtual async Task<Response<JwksDocument>> GetPublicKeysAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetPublicKeysAsync(context).ConfigureAwait(false);
            return Response.FromValue(JwksDocument.FromResponse(response), response);
        }

        /// <summary> Get the public keys used by the service to sign receipts, mentioned in IETF SCITT draft as part of jwks_uri implementation. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetPublicKeys(CancellationToken)']/*" />
        public virtual Response<JwksDocument> GetPublicKeys(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetPublicKeys(context);
            return Response.FromValue(JwksDocument.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Get the public keys used by the service to sign receipts, mentioned in IETF SCITT draft as part of jwks_uri implementation
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetPublicKeysAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetPublicKeysAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetPublicKeysAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetPublicKeys");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPublicKeysRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get the public keys used by the service to sign receipts, mentioned in IETF SCITT draft as part of jwks_uri implementation
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetPublicKeys(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetPublicKeys(RequestContext)']/*" />
        public virtual Response GetPublicKeys(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetPublicKeys");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPublicKeysRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get status of the long running registration operation, mandatory in IETF SCITT draft. </summary>
        /// <param name="operationId"> ID of the operation to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetOperationAsync(string,CancellationToken)']/*" />
        public virtual async Task<Response<BinaryData>> GetOperationAsync(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetOperationAsync(operationId, context).ConfigureAwait(false);
            return Response.FromValue(response.Content, response);
        }

        /// <summary> Get status of the long running registration operation, mandatory in IETF SCITT draft. </summary>
        /// <param name="operationId"> ID of the operation to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetOperation(string,CancellationToken)']/*" />
        public virtual Response<BinaryData> GetOperation(string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetOperation(operationId, context);
            return Response.FromValue(response.Content, response);
        }

        /// <summary>
        /// [Protocol Method] Get status of the long running registration operation, mandatory in IETF SCITT draft
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetOperationAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationId"> ID of the operation to retrieve. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetOperationAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetOperationAsync(string operationId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetOperation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOperationRequest(operationId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get status of the long running registration operation, mandatory in IETF SCITT draft
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetOperation(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationId"> ID of the operation to retrieve. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetOperation(string,RequestContext)']/*" />
        public virtual Response GetOperation(string operationId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetOperation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetOperationRequest(operationId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get receipt. </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntryAsync(string,CancellationToken)']/*" />
        public virtual async Task<Response<BinaryData>> GetEntryAsync(string entryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetEntryAsync(entryId, context).ConfigureAwait(false);
            return Response.FromValue(response.Content, response);
        }

        /// <summary> Get receipt. </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntry(string,CancellationToken)']/*" />
        public virtual Response<BinaryData> GetEntry(string entryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetEntry(entryId, context);
            return Response.FromValue(response.Content, response);
        }

        /// <summary>
        /// [Protocol Method] Get receipt
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEntryAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntryAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetEntryAsync(string entryId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetEntry");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEntryRequest(entryId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get receipt
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEntry(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntry(string,RequestContext)']/*" />
        public virtual Response GetEntry(string entryId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetEntry");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEntryRequest(entryId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the transparent statement consisting of the signed statement and the receipt embedded in the header. </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntryStatementAsync(string,CancellationToken)']/*" />
        public virtual async Task<Response<BinaryData>> GetEntryStatementAsync(string entryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetEntryStatementAsync(entryId, context).ConfigureAwait(false);
            return Response.FromValue(response.Content, response);
        }

        /// <summary> Get the transparent statement consisting of the signed statement and the receipt embedded in the header. </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntryStatement(string,CancellationToken)']/*" />
        public virtual Response<BinaryData> GetEntryStatement(string entryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetEntryStatement(entryId, context);
            return Response.FromValue(response.Content, response);
        }

        /// <summary>
        /// [Protocol Method] Get the transparent statement consisting of the signed statement and the receipt embedded in the header
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEntryStatementAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntryStatementAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetEntryStatementAsync(string entryId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetEntryStatement");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEntryStatementRequest(entryId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get the transparent statement consisting of the signed statement and the receipt embedded in the header
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEntryStatement(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="entryId"> ID of the entry to retrieve. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="entryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CodeTransparencyClient.xml" path="doc/members/member[@name='GetEntryStatement(string,RequestContext)']/*" />
        public virtual Response GetEntryStatement(string entryId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(entryId, nameof(entryId));

            using var scope = ClientDiagnostics.CreateScope("CodeTransparencyClient.GetEntryStatement");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetEntryStatementRequest(entryId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200500503;
        private static ResponseClassifier ResponseClassifier200500503 => _responseClassifier200500503 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 500, 503 });
        private static ResponseClassifier _responseClassifier200400404429500503;
        private static ResponseClassifier ResponseClassifier200400404429500503 => _responseClassifier200400404429500503 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 400, 404, 429, 500, 503 });
        private static ResponseClassifier _responseClassifier201202400404429500503;
        private static ResponseClassifier ResponseClassifier201202400404429500503 => _responseClassifier201202400404429500503 ??= new StatusCodeClassifier(stackalloc ushort[] { 201, 202, 400, 404, 429, 500, 503 });
        private static ResponseClassifier _responseClassifier200202400404429500503;
        private static ResponseClassifier ResponseClassifier200202400404429500503 => _responseClassifier200202400404429500503 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 202, 400, 404, 429, 500, 503 });
    }
}
