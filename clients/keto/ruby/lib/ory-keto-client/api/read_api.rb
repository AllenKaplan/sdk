=begin
#ORY Keto

#Ory Keto is a cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.

The version of the OpenAPI document: v0.6.0-alpha.1
Contact: hi@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.0.0

=end

require 'cgi'

module OryHydraClient
  class ReadApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Check a relation tuple
    # To learn how relation tuples and the check works, head over to [the documentation](../concepts/relation-tuples.mdx).
    # @param namespace [String] Namespace of the Relation Tuple
    # @param object [String] Object of the Relation Tuple
    # @param relation [String] Relation of the Relation Tuple
    # @param [Hash] opts the optional parameters
    # @option opts [String] :subject Subject of the Relation Tuple  The subject follows the subject string encoding format.
    # @return [GetCheckResponse]
    def get_check(namespace, object, relation, opts = {})
      data, _status_code, _headers = get_check_with_http_info(namespace, object, relation, opts)
      data
    end

    # Check a relation tuple
    # To learn how relation tuples and the check works, head over to [the documentation](../concepts/relation-tuples.mdx).
    # @param namespace [String] Namespace of the Relation Tuple
    # @param object [String] Object of the Relation Tuple
    # @param relation [String] Relation of the Relation Tuple
    # @param [Hash] opts the optional parameters
    # @option opts [String] :subject Subject of the Relation Tuple  The subject follows the subject string encoding format.
    # @return [Array<(GetCheckResponse, Integer, Hash)>] GetCheckResponse data, response status code and response headers
    def get_check_with_http_info(namespace, object, relation, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ReadApi.get_check ...'
      end
      # verify the required parameter 'namespace' is set
      if @api_client.config.client_side_validation && namespace.nil?
        fail ArgumentError, "Missing the required parameter 'namespace' when calling ReadApi.get_check"
      end
      # verify the required parameter 'object' is set
      if @api_client.config.client_side_validation && object.nil?
        fail ArgumentError, "Missing the required parameter 'object' when calling ReadApi.get_check"
      end
      # verify the required parameter 'relation' is set
      if @api_client.config.client_side_validation && relation.nil?
        fail ArgumentError, "Missing the required parameter 'relation' when calling ReadApi.get_check"
      end
      # resource path
      local_var_path = '/check'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'namespace'] = namespace
      query_params[:'object'] = object
      query_params[:'relation'] = relation
      query_params[:'subject'] = opts[:'subject'] if !opts[:'subject'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'GetCheckResponse'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ReadApi.get_check",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ReadApi#get_check\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Expand a Relation Tuple
    # Use this endpoint to expand a relation tuple.
    # @param namespace [String] Namespace of the Relation Tuple
    # @param object [String] Object of the Relation Tuple
    # @param relation [String] Relation of the Relation Tuple
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :max_depth 
    # @return [ExpandTree]
    def get_expand(namespace, object, relation, opts = {})
      data, _status_code, _headers = get_expand_with_http_info(namespace, object, relation, opts)
      data
    end

    # Expand a Relation Tuple
    # Use this endpoint to expand a relation tuple.
    # @param namespace [String] Namespace of the Relation Tuple
    # @param object [String] Object of the Relation Tuple
    # @param relation [String] Relation of the Relation Tuple
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :max_depth 
    # @return [Array<(ExpandTree, Integer, Hash)>] ExpandTree data, response status code and response headers
    def get_expand_with_http_info(namespace, object, relation, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ReadApi.get_expand ...'
      end
      # verify the required parameter 'namespace' is set
      if @api_client.config.client_side_validation && namespace.nil?
        fail ArgumentError, "Missing the required parameter 'namespace' when calling ReadApi.get_expand"
      end
      # verify the required parameter 'object' is set
      if @api_client.config.client_side_validation && object.nil?
        fail ArgumentError, "Missing the required parameter 'object' when calling ReadApi.get_expand"
      end
      # verify the required parameter 'relation' is set
      if @api_client.config.client_side_validation && relation.nil?
        fail ArgumentError, "Missing the required parameter 'relation' when calling ReadApi.get_expand"
      end
      # resource path
      local_var_path = '/expand'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'namespace'] = namespace
      query_params[:'object'] = object
      query_params[:'relation'] = relation
      query_params[:'max-depth'] = opts[:'max_depth'] if !opts[:'max_depth'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'ExpandTree'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ReadApi.get_expand",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ReadApi#get_expand\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Query relation tuples
    # Get all relation tuples that match the query. Only the namespace field is required.
    # @param namespace [String] 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :object 
    # @option opts [String] :relation 
    # @option opts [String] :subject 
    # @option opts [String] :page_token 
    # @option opts [Integer] :page_size 
    # @return [GetRelationTuplesResponse]
    def get_relation_tuples(namespace, opts = {})
      data, _status_code, _headers = get_relation_tuples_with_http_info(namespace, opts)
      data
    end

    # Query relation tuples
    # Get all relation tuples that match the query. Only the namespace field is required.
    # @param namespace [String] 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :object 
    # @option opts [String] :relation 
    # @option opts [String] :subject 
    # @option opts [String] :page_token 
    # @option opts [Integer] :page_size 
    # @return [Array<(GetRelationTuplesResponse, Integer, Hash)>] GetRelationTuplesResponse data, response status code and response headers
    def get_relation_tuples_with_http_info(namespace, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ReadApi.get_relation_tuples ...'
      end
      # verify the required parameter 'namespace' is set
      if @api_client.config.client_side_validation && namespace.nil?
        fail ArgumentError, "Missing the required parameter 'namespace' when calling ReadApi.get_relation_tuples"
      end
      # resource path
      local_var_path = '/relation-tuples'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'namespace'] = namespace
      query_params[:'object'] = opts[:'object'] if !opts[:'object'].nil?
      query_params[:'relation'] = opts[:'relation'] if !opts[:'relation'].nil?
      query_params[:'subject'] = opts[:'subject'] if !opts[:'subject'].nil?
      query_params[:'page_token'] = opts[:'page_token'] if !opts[:'page_token'].nil?
      query_params[:'page_size'] = opts[:'page_size'] if !opts[:'page_size'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'GetRelationTuplesResponse'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ReadApi.get_relation_tuples",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ReadApi#get_relation_tuples\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Check a relation tuple
    # To learn how relation tuples and the check works, head over to [the documentation](../concepts/relation-tuples.mdx).
    # @param [Hash] opts the optional parameters
    # @option opts [InternalRelationTuple] :payload 
    # @return [GetCheckResponse]
    def post_check(opts = {})
      data, _status_code, _headers = post_check_with_http_info(opts)
      data
    end

    # Check a relation tuple
    # To learn how relation tuples and the check works, head over to [the documentation](../concepts/relation-tuples.mdx).
    # @param [Hash] opts the optional parameters
    # @option opts [InternalRelationTuple] :payload 
    # @return [Array<(GetCheckResponse, Integer, Hash)>] GetCheckResponse data, response status code and response headers
    def post_check_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ReadApi.post_check ...'
      end
      # resource path
      local_var_path = '/check'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(opts[:'payload'])

      # return_type
      return_type = opts[:debug_return_type] || 'GetCheckResponse'

      # auth_names
      auth_names = opts[:debug_auth_names] || []

      new_options = opts.merge(
        :operation => :"ReadApi.post_check",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: ReadApi#post_check\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
