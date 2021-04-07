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

import sh.ory.keto.ApiException;
import sh.ory.keto.model.ExpandTree;
import sh.ory.keto.model.GetCheckResponse;
import sh.ory.keto.model.GetRelationTuplesResponse;
import sh.ory.keto.model.InlineResponse400;
import sh.ory.keto.model.InternalRelationTuple;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for ReadApi
 */
@Ignore
public class ReadApiTest {

    private final ReadApi api = new ReadApi();

    
    /**
     * Check a relation tuple
     *
     * To learn how relation tuples and the check works, head over to [the documentation](../concepts/relation-tuples.mdx).
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getCheckTest() throws ApiException {
        String namespace = null;
        String _object = null;
        String relation = null;
        String subject = null;
        GetCheckResponse response = api.getCheck(namespace, _object, relation, subject);

        // TODO: test validations
    }
    
    /**
     * Expand a Relation Tuple
     *
     * Use this endpoint to expand a relation tuple.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getExpandTest() throws ApiException {
        String namespace = null;
        String _object = null;
        String relation = null;
        Long maxDepth = null;
        ExpandTree response = api.getExpand(namespace, _object, relation, maxDepth);

        // TODO: test validations
    }
    
    /**
     * Query relation tuples
     *
     * Get all relation tuples that match the query. Only the namespace field is required.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getRelationTuplesTest() throws ApiException {
        String namespace = null;
        String _object = null;
        String relation = null;
        String subject = null;
        String pageToken = null;
        Long pageSize = null;
        GetRelationTuplesResponse response = api.getRelationTuples(namespace, _object, relation, subject, pageToken, pageSize);

        // TODO: test validations
    }
    
    /**
     * Check a relation tuple
     *
     * To learn how relation tuples and the check works, head over to [the documentation](../concepts/relation-tuples.mdx).
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void postCheckTest() throws ApiException {
        InternalRelationTuple payload = null;
        GetCheckResponse response = api.postCheck(payload);

        // TODO: test validations
    }
    
}
