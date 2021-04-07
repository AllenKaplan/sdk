/*
 * ORY Keto
 *
 * Ory Keto is a cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.
 *
 * The version of the OpenAPI document: v0.6.0-alpha.1
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Keto.Client.Client;
using Ory.Keto.Client.Model;

namespace Ory.Keto.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWriteApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to create a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns>KetoInternalRelationTuple</returns>
        KetoInternalRelationTuple CreateRelationTuple(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple));

        /// <summary>
        /// Create a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to create a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns>ApiResponse of KetoInternalRelationTuple</returns>
        ApiResponse<KetoInternalRelationTuple> CreateRelationTupleWithHttpInfo(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple));
        /// <summary>
        /// Delete a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to delete a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <returns></returns>
        void DeleteRelationTuple(string _namespace, string _object, string relation, string subject = default(string));

        /// <summary>
        /// Delete a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to delete a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRelationTupleWithHttpInfo(string _namespace, string _object, string relation, string subject = default(string));
        /// <summary>
        /// Patch Multiple Relation Tuples
        /// </summary>
        /// <remarks>
        /// Use this endpoint to patch one or more relation tuples.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns></returns>
        void PatchRelationTuples(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>));

        /// <summary>
        /// Patch Multiple Relation Tuples
        /// </summary>
        /// <remarks>
        /// Use this endpoint to patch one or more relation tuples.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchRelationTuplesWithHttpInfo(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWriteApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to create a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInternalRelationTuple</returns>
        System.Threading.Tasks.Task<KetoInternalRelationTuple> CreateRelationTupleAsync(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to create a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInternalRelationTuple)</returns>
        System.Threading.Tasks.Task<ApiResponse<KetoInternalRelationTuple>> CreateRelationTupleWithHttpInfoAsync(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to delete a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRelationTupleAsync(string _namespace, string _object, string relation, string subject = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a Relation Tuple
        /// </summary>
        /// <remarks>
        /// Use this endpoint to delete a relation tuple.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRelationTupleWithHttpInfoAsync(string _namespace, string _object, string relation, string subject = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Patch Multiple Relation Tuples
        /// </summary>
        /// <remarks>
        /// Use this endpoint to patch one or more relation tuples.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchRelationTuplesAsync(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Patch Multiple Relation Tuples
        /// </summary>
        /// <remarks>
        /// Use this endpoint to patch one or more relation tuples.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchRelationTuplesWithHttpInfoAsync(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWriteApi : IWriteApiSync, IWriteApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WriteApi : IWriteApi
    {
        private Ory.Keto.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WriteApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WriteApi(String basePath)
        {
            this.Configuration = Ory.Keto.Client.Client.Configuration.MergeConfigurations(
                Ory.Keto.Client.Client.GlobalConfiguration.Instance,
                new Ory.Keto.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WriteApi(Ory.Keto.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Keto.Client.Client.Configuration.MergeConfigurations(
                Ory.Keto.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WriteApi(Ory.Keto.Client.Client.ISynchronousClient client, Ory.Keto.Client.Client.IAsynchronousClient asyncClient, Ory.Keto.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Keto.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Keto.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ory.Keto.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Keto.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create a Relation Tuple Use this endpoint to create a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns>KetoInternalRelationTuple</returns>
        public KetoInternalRelationTuple CreateRelationTuple(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple))
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInternalRelationTuple> localVarResponse = CreateRelationTupleWithHttpInfo(payload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Relation Tuple Use this endpoint to create a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns>ApiResponse of KetoInternalRelationTuple</returns>
        public Ory.Keto.Client.Client.ApiResponse<KetoInternalRelationTuple> CreateRelationTupleWithHttpInfo(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple))
        {
            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = payload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<KetoInternalRelationTuple>("/relation-tuples", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRelationTuple", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a Relation Tuple Use this endpoint to create a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInternalRelationTuple</returns>
        public async System.Threading.Tasks.Task<KetoInternalRelationTuple> CreateRelationTupleAsync(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInternalRelationTuple> localVarResponse = await CreateRelationTupleWithHttpInfoAsync(payload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Relation Tuple Use this endpoint to create a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInternalRelationTuple)</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<KetoInternalRelationTuple>> CreateRelationTupleWithHttpInfoAsync(KetoInternalRelationTuple payload = default(KetoInternalRelationTuple), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = payload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<KetoInternalRelationTuple>("/relation-tuples", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRelationTuple", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a Relation Tuple Use this endpoint to delete a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <returns></returns>
        public void DeleteRelationTuple(string _namespace, string _object, string relation, string subject = default(string))
        {
            DeleteRelationTupleWithHttpInfo(_namespace, _object, relation, subject);
        }

        /// <summary>
        /// Delete a Relation Tuple Use this endpoint to delete a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Ory.Keto.Client.Client.ApiResponse<Object> DeleteRelationTupleWithHttpInfo(string _namespace, string _object, string relation, string subject = default(string))
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null)
                throw new Ory.Keto.Client.Client.ApiException(400, "Missing required parameter '_namespace' when calling WriteApi->DeleteRelationTuple");

            // verify the required parameter '_object' is set
            if (_object == null)
                throw new Ory.Keto.Client.Client.ApiException(400, "Missing required parameter '_object' when calling WriteApi->DeleteRelationTuple");

            // verify the required parameter 'relation' is set
            if (relation == null)
                throw new Ory.Keto.Client.Client.ApiException(400, "Missing required parameter 'relation' when calling WriteApi->DeleteRelationTuple");

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "namespace", _namespace));
            localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "object", _object));
            localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "relation", relation));
            if (subject != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "subject", subject));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/relation-tuples", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRelationTuple", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a Relation Tuple Use this endpoint to delete a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRelationTupleAsync(string _namespace, string _object, string relation, string subject = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteRelationTupleWithHttpInfoAsync(_namespace, _object, relation, subject, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a Relation Tuple Use this endpoint to delete a relation tuple.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_namespace">Namespace of the Relation Tuple</param>
        /// <param name="_object">Object of the Relation Tuple</param>
        /// <param name="relation">Relation of the Relation Tuple</param>
        /// <param name="subject">Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<Object>> DeleteRelationTupleWithHttpInfoAsync(string _namespace, string _object, string relation, string subject = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter '_namespace' is set
            if (_namespace == null)
                throw new Ory.Keto.Client.Client.ApiException(400, "Missing required parameter '_namespace' when calling WriteApi->DeleteRelationTuple");

            // verify the required parameter '_object' is set
            if (_object == null)
                throw new Ory.Keto.Client.Client.ApiException(400, "Missing required parameter '_object' when calling WriteApi->DeleteRelationTuple");

            // verify the required parameter 'relation' is set
            if (relation == null)
                throw new Ory.Keto.Client.Client.ApiException(400, "Missing required parameter 'relation' when calling WriteApi->DeleteRelationTuple");


            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "namespace", _namespace));
            localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "object", _object));
            localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "relation", relation));
            if (subject != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Keto.Client.Client.ClientUtils.ParameterToMultiMap("", "subject", subject));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/relation-tuples", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRelationTuple", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Patch Multiple Relation Tuples Use this endpoint to patch one or more relation tuples.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns></returns>
        public void PatchRelationTuples(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>))
        {
            PatchRelationTuplesWithHttpInfo(payload);
        }

        /// <summary>
        /// Patch Multiple Relation Tuples Use this endpoint to patch one or more relation tuples.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Ory.Keto.Client.Client.ApiResponse<Object> PatchRelationTuplesWithHttpInfo(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>))
        {
            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = payload;


            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/relation-tuples", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchRelationTuples", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Patch Multiple Relation Tuples Use this endpoint to patch one or more relation tuples.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchRelationTuplesAsync(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PatchRelationTuplesWithHttpInfoAsync(payload, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Patch Multiple Relation Tuples Use this endpoint to patch one or more relation tuples.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="payload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<Object>> PatchRelationTuplesWithHttpInfoAsync(List<KetoPatchDelta> payload = default(List<KetoPatchDelta>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = payload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<Object>("/relation-tuples", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchRelationTuples", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
