/*
 * ORY Keto
 * Ory Keto is a cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.
 *
 * The version of the OpenAPI document: v0.6.0-alpha.1
 * Contact: hi@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.keto.api;

import sh.ory.keto.ApiCallback;
import sh.ory.keto.ApiClient;
import sh.ory.keto.ApiException;
import sh.ory.keto.ApiResponse;
import sh.ory.keto.Configuration;
import sh.ory.keto.Pair;
import sh.ory.keto.ProgressRequestBody;
import sh.ory.keto.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import sh.ory.keto.model.InlineResponse400;
import sh.ory.keto.model.InternalRelationTuple;
import sh.ory.keto.model.PatchDelta;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class WriteApi {
    private ApiClient localVarApiClient;

    public WriteApi() {
        this(Configuration.getDefaultApiClient());
    }

    public WriteApi(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return localVarApiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    /**
     * Build call for createRelationTuple
     * @param payload  (optional)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 201 </td><td> InternalRelationTuple </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call createRelationTupleCall(InternalRelationTuple payload, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = payload;

        // create path and map variables
        String localVarPath = "/relation-tuples";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "PUT", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call createRelationTupleValidateBeforeCall(InternalRelationTuple payload, final ApiCallback _callback) throws ApiException {
        

        okhttp3.Call localVarCall = createRelationTupleCall(payload, _callback);
        return localVarCall;

    }

    /**
     * Create a Relation Tuple
     * Use this endpoint to create a relation tuple.
     * @param payload  (optional)
     * @return InternalRelationTuple
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 201 </td><td> InternalRelationTuple </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public InternalRelationTuple createRelationTuple(InternalRelationTuple payload) throws ApiException {
        ApiResponse<InternalRelationTuple> localVarResp = createRelationTupleWithHttpInfo(payload);
        return localVarResp.getData();
    }

    /**
     * Create a Relation Tuple
     * Use this endpoint to create a relation tuple.
     * @param payload  (optional)
     * @return ApiResponse&lt;InternalRelationTuple&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 201 </td><td> InternalRelationTuple </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<InternalRelationTuple> createRelationTupleWithHttpInfo(InternalRelationTuple payload) throws ApiException {
        okhttp3.Call localVarCall = createRelationTupleValidateBeforeCall(payload, null);
        Type localVarReturnType = new TypeToken<InternalRelationTuple>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * Create a Relation Tuple (asynchronously)
     * Use this endpoint to create a relation tuple.
     * @param payload  (optional)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 201 </td><td> InternalRelationTuple </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call createRelationTupleAsync(InternalRelationTuple payload, final ApiCallback<InternalRelationTuple> _callback) throws ApiException {

        okhttp3.Call localVarCall = createRelationTupleValidateBeforeCall(payload, _callback);
        Type localVarReturnType = new TypeToken<InternalRelationTuple>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
    /**
     * Build call for deleteRelationTuple
     * @param namespace Namespace of the Relation Tuple (required)
     * @param _object Object of the Relation Tuple (required)
     * @param relation Relation of the Relation Tuple (required)
     * @param subject Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call deleteRelationTupleCall(String namespace, String _object, String relation, String subject, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/relation-tuples";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        if (namespace != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("namespace", namespace));
        }

        if (_object != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("object", _object));
        }

        if (relation != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("relation", relation));
        }

        if (subject != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("subject", subject));
        }

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "DELETE", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call deleteRelationTupleValidateBeforeCall(String namespace, String _object, String relation, String subject, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'namespace' is set
        if (namespace == null) {
            throw new ApiException("Missing the required parameter 'namespace' when calling deleteRelationTuple(Async)");
        }
        
        // verify the required parameter '_object' is set
        if (_object == null) {
            throw new ApiException("Missing the required parameter '_object' when calling deleteRelationTuple(Async)");
        }
        
        // verify the required parameter 'relation' is set
        if (relation == null) {
            throw new ApiException("Missing the required parameter 'relation' when calling deleteRelationTuple(Async)");
        }
        

        okhttp3.Call localVarCall = deleteRelationTupleCall(namespace, _object, relation, subject, _callback);
        return localVarCall;

    }

    /**
     * Delete a Relation Tuple
     * Use this endpoint to delete a relation tuple.
     * @param namespace Namespace of the Relation Tuple (required)
     * @param _object Object of the Relation Tuple (required)
     * @param relation Relation of the Relation Tuple (required)
     * @param subject Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public void deleteRelationTuple(String namespace, String _object, String relation, String subject) throws ApiException {
        deleteRelationTupleWithHttpInfo(namespace, _object, relation, subject);
    }

    /**
     * Delete a Relation Tuple
     * Use this endpoint to delete a relation tuple.
     * @param namespace Namespace of the Relation Tuple (required)
     * @param _object Object of the Relation Tuple (required)
     * @param relation Relation of the Relation Tuple (required)
     * @param subject Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<Void> deleteRelationTupleWithHttpInfo(String namespace, String _object, String relation, String subject) throws ApiException {
        okhttp3.Call localVarCall = deleteRelationTupleValidateBeforeCall(namespace, _object, relation, subject, null);
        return localVarApiClient.execute(localVarCall);
    }

    /**
     * Delete a Relation Tuple (asynchronously)
     * Use this endpoint to delete a relation tuple.
     * @param namespace Namespace of the Relation Tuple (required)
     * @param _object Object of the Relation Tuple (required)
     * @param relation Relation of the Relation Tuple (required)
     * @param subject Subject of the Relation Tuple  The subject follows the subject string encoding format. (optional)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call deleteRelationTupleAsync(String namespace, String _object, String relation, String subject, final ApiCallback<Void> _callback) throws ApiException {

        okhttp3.Call localVarCall = deleteRelationTupleValidateBeforeCall(namespace, _object, relation, subject, _callback);
        localVarApiClient.executeAsync(localVarCall, _callback);
        return localVarCall;
    }
    /**
     * Build call for patchRelationTuples
     * @param payload  (optional)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 404 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call patchRelationTuplesCall(List<PatchDelta> payload, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = payload;

        // create path and map variables
        String localVarPath = "/relation-tuples";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "PATCH", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call patchRelationTuplesValidateBeforeCall(List<PatchDelta> payload, final ApiCallback _callback) throws ApiException {
        

        okhttp3.Call localVarCall = patchRelationTuplesCall(payload, _callback);
        return localVarCall;

    }

    /**
     * Patch Multiple Relation Tuples
     * Use this endpoint to patch one or more relation tuples.
     * @param payload  (optional)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 404 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public void patchRelationTuples(List<PatchDelta> payload) throws ApiException {
        patchRelationTuplesWithHttpInfo(payload);
    }

    /**
     * Patch Multiple Relation Tuples
     * Use this endpoint to patch one or more relation tuples.
     * @param payload  (optional)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 404 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<Void> patchRelationTuplesWithHttpInfo(List<PatchDelta> payload) throws ApiException {
        okhttp3.Call localVarCall = patchRelationTuplesValidateBeforeCall(payload, null);
        return localVarApiClient.execute(localVarCall);
    }

    /**
     * Patch Multiple Relation Tuples (asynchronously)
     * Use this endpoint to patch one or more relation tuples.
     * @param payload  (optional)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 204 </td><td> Empty responses are sent when, for example, resources are deleted. The HTTP status code for empty responses is typically 201. </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 404 </td><td> The standard error format </td><td>  -  </td></tr>
        <tr><td> 500 </td><td> The standard error format </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call patchRelationTuplesAsync(List<PatchDelta> payload, final ApiCallback<Void> _callback) throws ApiException {

        okhttp3.Call localVarCall = patchRelationTuplesValidateBeforeCall(payload, _callback);
        localVarApiClient.executeAsync(localVarCall, _callback);
        return localVarCall;
    }
}
