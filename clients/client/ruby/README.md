# ory-client

OryClient - the Ruby gem for the Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed
with a valid Personal Access Token. Public APIs are mostly used in browsers.


This SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.0.1-alpha.188
- Package version: v0.0.1-alpha.188
- Build package: org.openapitools.codegen.languages.RubyClientCodegen

## Installation

### Build a gem

To build the Ruby code into a gem:

```shell
gem build ory-client.gemspec
```

Then either install the gem locally:

```shell
gem install ./ory-client-v0.0.1-alpha.188.gem
```

(for development, run `gem install --dev ./ory-client-v0.0.1-alpha.188.gem` to install the development dependencies)

or publish the gem to a gem hosting service, e.g. [RubyGems](https://rubygems.org/).

Finally add this to the Gemfile:

    gem 'ory-client', '~> v0.0.1-alpha.188'

### Install from Git

If the Ruby gem is hosted at a git repository: https://github.com/ory/sdk, then add the following in the Gemfile:

    gem 'ory-client', :git => 'https://github.com/ory/sdk.git'

### Include the Ruby code directly

Include the Ruby code directly using `-I` as follows:

```shell
ruby -Ilib script.rb
```

## Getting Started

Please follow the [installation](#installation) procedure and then run the following code:

```ruby
# Load the gem
require 'ory-client'

# Setup authorization
OryClient.configure do |config|
  # Configure Bearer authorization: oryAccessToken
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OryClient::MetadataApi.new

begin
  #Return Running Software Version.
  result = api_instance.get_version
  p result
rescue OryClient::ApiError => e
  puts "Exception when calling MetadataApi->get_version: #{e}"
end

```

## Documentation for API Endpoints

All URIs are relative to *https://playground.projects.oryapis.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*OryClient::MetadataApi* | [**get_version**](docs/MetadataApi.md#get_version) | **GET** /version | Return Running Software Version.
*OryClient::MetadataApi* | [**is_alive**](docs/MetadataApi.md#is_alive) | **GET** /health/alive | Check HTTP Server Status
*OryClient::MetadataApi* | [**is_ready**](docs/MetadataApi.md#is_ready) | **GET** /health/ready | Check HTTP Server and Database Status
*OryClient::ReadApi* | [**get_check**](docs/ReadApi.md#get_check) | **GET** /relation-tuples/check | Check a relation tuple
*OryClient::ReadApi* | [**get_expand**](docs/ReadApi.md#get_expand) | **GET** /relation-tuples/expand | Expand a Relation Tuple
*OryClient::ReadApi* | [**get_relation_tuples**](docs/ReadApi.md#get_relation_tuples) | **GET** /relation-tuples | Query relation tuples
*OryClient::ReadApi* | [**post_check**](docs/ReadApi.md#post_check) | **POST** /relation-tuples/check | Check a relation tuple
*OryClient::V0alpha2Api* | [**admin_create_identity**](docs/V0alpha2Api.md#admin_create_identity) | **POST** /admin/identities | Create an Identity
*OryClient::V0alpha2Api* | [**admin_create_self_service_recovery_link**](docs/V0alpha2Api.md#admin_create_self_service_recovery_link) | **POST** /admin/recovery/link | Create a Recovery Link
*OryClient::V0alpha2Api* | [**admin_delete_identity**](docs/V0alpha2Api.md#admin_delete_identity) | **DELETE** /admin/identities/{id} | Delete an Identity
*OryClient::V0alpha2Api* | [**admin_delete_identity_sessions**](docs/V0alpha2Api.md#admin_delete_identity_sessions) | **DELETE** /admin/identities/{id}/sessions | Calling this endpoint irrecoverably and permanently deletes and invalidates all sessions that belong to the given Identity.
*OryClient::V0alpha2Api* | [**admin_extend_session**](docs/V0alpha2Api.md#admin_extend_session) | **PATCH** /admin/sessions/{id}/extend | Calling this endpoint extends the given session ID. If `session.earliest_possible_extend` is set it will only extend the session after the specified time has passed.
*OryClient::V0alpha2Api* | [**admin_get_identity**](docs/V0alpha2Api.md#admin_get_identity) | **GET** /admin/identities/{id} | Get an Identity
*OryClient::V0alpha2Api* | [**admin_list_identities**](docs/V0alpha2Api.md#admin_list_identities) | **GET** /admin/identities | List Identities
*OryClient::V0alpha2Api* | [**admin_list_identity_sessions**](docs/V0alpha2Api.md#admin_list_identity_sessions) | **GET** /admin/identities/{id}/sessions | This endpoint returns all sessions that belong to the given Identity.
*OryClient::V0alpha2Api* | [**admin_update_identity**](docs/V0alpha2Api.md#admin_update_identity) | **PUT** /admin/identities/{id} | Update an Identity
*OryClient::V0alpha2Api* | [**create_project**](docs/V0alpha2Api.md#create_project) | **POST** /projects | Create a Project
*OryClient::V0alpha2Api* | [**create_self_service_logout_flow_url_for_browsers**](docs/V0alpha2Api.md#create_self_service_logout_flow_url_for_browsers) | **GET** /self-service/logout/browser | Create a Logout URL for Browsers
*OryClient::V0alpha2Api* | [**get_json_schema**](docs/V0alpha2Api.md#get_json_schema) | **GET** /schemas/{id} | 
*OryClient::V0alpha2Api* | [**get_project**](docs/V0alpha2Api.md#get_project) | **GET** /projects/{project_id} | Get a Project
*OryClient::V0alpha2Api* | [**get_project_members**](docs/V0alpha2Api.md#get_project_members) | **GET** /projects/{project_id}/members | Get all members associated with this project.
*OryClient::V0alpha2Api* | [**get_self_service_error**](docs/V0alpha2Api.md#get_self_service_error) | **GET** /self-service/errors | Get Self-Service Errors
*OryClient::V0alpha2Api* | [**get_self_service_login_flow**](docs/V0alpha2Api.md#get_self_service_login_flow) | **GET** /self-service/login/flows | Get Login Flow
*OryClient::V0alpha2Api* | [**get_self_service_recovery_flow**](docs/V0alpha2Api.md#get_self_service_recovery_flow) | **GET** /self-service/recovery/flows | Get Recovery Flow
*OryClient::V0alpha2Api* | [**get_self_service_registration_flow**](docs/V0alpha2Api.md#get_self_service_registration_flow) | **GET** /self-service/registration/flows | Get Registration Flow
*OryClient::V0alpha2Api* | [**get_self_service_settings_flow**](docs/V0alpha2Api.md#get_self_service_settings_flow) | **GET** /self-service/settings/flows | Get Settings Flow
*OryClient::V0alpha2Api* | [**get_self_service_verification_flow**](docs/V0alpha2Api.md#get_self_service_verification_flow) | **GET** /self-service/verification/flows | Get Verification Flow
*OryClient::V0alpha2Api* | [**get_web_authn_java_script**](docs/V0alpha2Api.md#get_web_authn_java_script) | **GET** /.well-known/ory/webauthn.js | Get WebAuthn JavaScript
*OryClient::V0alpha2Api* | [**initialize_self_service_login_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_login_flow_for_browsers) | **GET** /self-service/login/browser | Initialize Login Flow for Browsers
*OryClient::V0alpha2Api* | [**initialize_self_service_login_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_login_flow_without_browser) | **GET** /self-service/login/api | Initialize Login Flow for APIs, Services, Apps, ...
*OryClient::V0alpha2Api* | [**initialize_self_service_recovery_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_recovery_flow_for_browsers) | **GET** /self-service/recovery/browser | Initialize Recovery Flow for Browsers
*OryClient::V0alpha2Api* | [**initialize_self_service_recovery_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_recovery_flow_without_browser) | **GET** /self-service/recovery/api | Initialize Recovery Flow for APIs, Services, Apps, ...
*OryClient::V0alpha2Api* | [**initialize_self_service_registration_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_registration_flow_for_browsers) | **GET** /self-service/registration/browser | Initialize Registration Flow for Browsers
*OryClient::V0alpha2Api* | [**initialize_self_service_registration_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_registration_flow_without_browser) | **GET** /self-service/registration/api | Initialize Registration Flow for APIs, Services, Apps, ...
*OryClient::V0alpha2Api* | [**initialize_self_service_settings_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_settings_flow_for_browsers) | **GET** /self-service/settings/browser | Initialize Settings Flow for Browsers
*OryClient::V0alpha2Api* | [**initialize_self_service_settings_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_settings_flow_without_browser) | **GET** /self-service/settings/api | Initialize Settings Flow for APIs, Services, Apps, ...
*OryClient::V0alpha2Api* | [**initialize_self_service_verification_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_verification_flow_for_browsers) | **GET** /self-service/verification/browser | Initialize Verification Flow for Browser Clients
*OryClient::V0alpha2Api* | [**initialize_self_service_verification_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_verification_flow_without_browser) | **GET** /self-service/verification/api | Initialize Verification Flow for APIs, Services, Apps, ...
*OryClient::V0alpha2Api* | [**list_identity_schemas**](docs/V0alpha2Api.md#list_identity_schemas) | **GET** /schemas | 
*OryClient::V0alpha2Api* | [**list_projects**](docs/V0alpha2Api.md#list_projects) | **GET** /projects | List All Projects
*OryClient::V0alpha2Api* | [**list_sessions**](docs/V0alpha2Api.md#list_sessions) | **GET** /sessions | This endpoints returns all other active sessions that belong to the logged-in user. The current session can be retrieved by calling the `/sessions/whoami` endpoint.
*OryClient::V0alpha2Api* | [**patch_project**](docs/V0alpha2Api.md#patch_project) | **PATCH** /projects/{project_id} | Patch an Ory Cloud Project Configuration
*OryClient::V0alpha2Api* | [**purge_project**](docs/V0alpha2Api.md#purge_project) | **DELETE** /projects/{project_id} | Irrecoverably Purge a Project
*OryClient::V0alpha2Api* | [**remove_project_member**](docs/V0alpha2Api.md#remove_project_member) | **DELETE** /projects/{project_id}/members/{member_id} | Remove a member associated with this project. This also sets their invite status to `REMOVED`.
*OryClient::V0alpha2Api* | [**revoke_session**](docs/V0alpha2Api.md#revoke_session) | **DELETE** /sessions/{id} | Calling this endpoint invalidates the specified session. The current session cannot be revoked. Session data are not deleted.
*OryClient::V0alpha2Api* | [**revoke_sessions**](docs/V0alpha2Api.md#revoke_sessions) | **DELETE** /sessions | Calling this endpoint invalidates all except the current session that belong to the logged-in user. Session data are not deleted.
*OryClient::V0alpha2Api* | [**submit_self_service_login_flow**](docs/V0alpha2Api.md#submit_self_service_login_flow) | **POST** /self-service/login | Submit a Login Flow
*OryClient::V0alpha2Api* | [**submit_self_service_logout_flow**](docs/V0alpha2Api.md#submit_self_service_logout_flow) | **GET** /self-service/logout | Complete Self-Service Logout
*OryClient::V0alpha2Api* | [**submit_self_service_logout_flow_without_browser**](docs/V0alpha2Api.md#submit_self_service_logout_flow_without_browser) | **DELETE** /self-service/logout/api | Perform Logout for APIs, Services, Apps, ...
*OryClient::V0alpha2Api* | [**submit_self_service_recovery_flow**](docs/V0alpha2Api.md#submit_self_service_recovery_flow) | **POST** /self-service/recovery | Complete Recovery Flow
*OryClient::V0alpha2Api* | [**submit_self_service_registration_flow**](docs/V0alpha2Api.md#submit_self_service_registration_flow) | **POST** /self-service/registration | Submit a Registration Flow
*OryClient::V0alpha2Api* | [**submit_self_service_settings_flow**](docs/V0alpha2Api.md#submit_self_service_settings_flow) | **POST** /self-service/settings | Complete Settings Flow
*OryClient::V0alpha2Api* | [**submit_self_service_verification_flow**](docs/V0alpha2Api.md#submit_self_service_verification_flow) | **POST** /self-service/verification | Complete Verification Flow
*OryClient::V0alpha2Api* | [**to_session**](docs/V0alpha2Api.md#to_session) | **GET** /sessions/whoami | Check Who the Current HTTP Session Belongs To
*OryClient::V0alpha2Api* | [**update_project**](docs/V0alpha2Api.md#update_project) | **PUT** /projects/{project_id} | Update an Ory Cloud Project Configuration
*OryClient::WriteApi* | [**create_relation_tuple**](docs/WriteApi.md#create_relation_tuple) | **PUT** /admin/relation-tuples | Create a Relation Tuple
*OryClient::WriteApi* | [**delete_relation_tuples**](docs/WriteApi.md#delete_relation_tuples) | **DELETE** /admin/relation-tuples | Delete Relation Tuples
*OryClient::WriteApi* | [**patch_relation_tuples**](docs/WriteApi.md#patch_relation_tuples) | **PATCH** /admin/relation-tuples | Patch Multiple Relation Tuples


## Documentation for Models

 - [OryClient::ActiveProject](docs/ActiveProject.md)
 - [OryClient::AdminCreateIdentityBody](docs/AdminCreateIdentityBody.md)
 - [OryClient::AdminCreateIdentityImportCredentialsOidc](docs/AdminCreateIdentityImportCredentialsOidc.md)
 - [OryClient::AdminCreateIdentityImportCredentialsOidcConfig](docs/AdminCreateIdentityImportCredentialsOidcConfig.md)
 - [OryClient::AdminCreateIdentityImportCredentialsOidcProvider](docs/AdminCreateIdentityImportCredentialsOidcProvider.md)
 - [OryClient::AdminCreateIdentityImportCredentialsPassword](docs/AdminCreateIdentityImportCredentialsPassword.md)
 - [OryClient::AdminCreateIdentityImportCredentialsPasswordConfig](docs/AdminCreateIdentityImportCredentialsPasswordConfig.md)
 - [OryClient::AdminCreateSelfServiceRecoveryLinkBody](docs/AdminCreateSelfServiceRecoveryLinkBody.md)
 - [OryClient::AdminIdentityImportCredentials](docs/AdminIdentityImportCredentials.md)
 - [OryClient::AdminUpdateIdentityBody](docs/AdminUpdateIdentityBody.md)
 - [OryClient::ApiToken](docs/ApiToken.md)
 - [OryClient::AuthenticatorAssuranceLevel](docs/AuthenticatorAssuranceLevel.md)
 - [OryClient::CloudAccount](docs/CloudAccount.md)
 - [OryClient::CnameSettings](docs/CnameSettings.md)
 - [OryClient::CreateCustomHostnameBody](docs/CreateCustomHostnameBody.md)
 - [OryClient::CreateProjectBody](docs/CreateProjectBody.md)
 - [OryClient::CreateSubscriptionPayload](docs/CreateSubscriptionPayload.md)
 - [OryClient::ErrorAuthenticatorAssuranceLevelNotSatisfied](docs/ErrorAuthenticatorAssuranceLevelNotSatisfied.md)
 - [OryClient::ExpandTree](docs/ExpandTree.md)
 - [OryClient::GenericError](docs/GenericError.md)
 - [OryClient::GenericErrorContent](docs/GenericErrorContent.md)
 - [OryClient::GetCheckResponse](docs/GetCheckResponse.md)
 - [OryClient::GetRelationTuplesResponse](docs/GetRelationTuplesResponse.md)
 - [OryClient::HealthNotReadyStatus](docs/HealthNotReadyStatus.md)
 - [OryClient::HealthStatus](docs/HealthStatus.md)
 - [OryClient::Identity](docs/Identity.md)
 - [OryClient::IdentityCredentials](docs/IdentityCredentials.md)
 - [OryClient::IdentityCredentialsOidc](docs/IdentityCredentialsOidc.md)
 - [OryClient::IdentityCredentialsOidcProvider](docs/IdentityCredentialsOidcProvider.md)
 - [OryClient::IdentityCredentialsPassword](docs/IdentityCredentialsPassword.md)
 - [OryClient::IdentityCredentialsType](docs/IdentityCredentialsType.md)
 - [OryClient::IdentitySchema](docs/IdentitySchema.md)
 - [OryClient::IdentitySchemaLocation](docs/IdentitySchemaLocation.md)
 - [OryClient::IdentitySchemaPreset](docs/IdentitySchemaPreset.md)
 - [OryClient::IdentitySchemaValidationResult](docs/IdentitySchemaValidationResult.md)
 - [OryClient::IdentityState](docs/IdentityState.md)
 - [OryClient::InlineResponse200](docs/InlineResponse200.md)
 - [OryClient::InlineResponse2001](docs/InlineResponse2001.md)
 - [OryClient::InlineResponse503](docs/InlineResponse503.md)
 - [OryClient::InternalRelationTuple](docs/InternalRelationTuple.md)
 - [OryClient::InvitePayload](docs/InvitePayload.md)
 - [OryClient::IsOwnerForProjectBySlug](docs/IsOwnerForProjectBySlug.md)
 - [OryClient::IsOwnerForProjectBySlugPayload](docs/IsOwnerForProjectBySlugPayload.md)
 - [OryClient::JsonError](docs/JsonError.md)
 - [OryClient::JsonPatch](docs/JsonPatch.md)
 - [OryClient::KetoNamespace](docs/KetoNamespace.md)
 - [OryClient::NeedsPrivilegedSessionError](docs/NeedsPrivilegedSessionError.md)
 - [OryClient::NormalizedProject](docs/NormalizedProject.md)
 - [OryClient::NormalizedProjectRevision](docs/NormalizedProjectRevision.md)
 - [OryClient::NormalizedProjectRevisionHook](docs/NormalizedProjectRevisionHook.md)
 - [OryClient::NormalizedProjectRevisionIdentitySchema](docs/NormalizedProjectRevisionIdentitySchema.md)
 - [OryClient::NormalizedProjectRevisionThirdPartyProvider](docs/NormalizedProjectRevisionThirdPartyProvider.md)
 - [OryClient::NullPlan](docs/NullPlan.md)
 - [OryClient::Pagination](docs/Pagination.md)
 - [OryClient::PatchDelta](docs/PatchDelta.md)
 - [OryClient::Project](docs/Project.md)
 - [OryClient::ProjectHost](docs/ProjectHost.md)
 - [OryClient::ProjectInvite](docs/ProjectInvite.md)
 - [OryClient::ProjectMetadata](docs/ProjectMetadata.md)
 - [OryClient::ProjectServiceIdentity](docs/ProjectServiceIdentity.md)
 - [OryClient::ProjectServicePermission](docs/ProjectServicePermission.md)
 - [OryClient::ProjectServices](docs/ProjectServices.md)
 - [OryClient::ProvisionMockSubscriptionPayload](docs/ProvisionMockSubscriptionPayload.md)
 - [OryClient::QuotaProjectMemberSeats](docs/QuotaProjectMemberSeats.md)
 - [OryClient::RecoveryAddress](docs/RecoveryAddress.md)
 - [OryClient::RelationQuery](docs/RelationQuery.md)
 - [OryClient::RevokedSessions](docs/RevokedSessions.md)
 - [OryClient::SchemaPatch](docs/SchemaPatch.md)
 - [OryClient::SelfServiceBrowserLocationChangeRequiredError](docs/SelfServiceBrowserLocationChangeRequiredError.md)
 - [OryClient::SelfServiceError](docs/SelfServiceError.md)
 - [OryClient::SelfServiceFlowExpiredError](docs/SelfServiceFlowExpiredError.md)
 - [OryClient::SelfServiceLoginFlow](docs/SelfServiceLoginFlow.md)
 - [OryClient::SelfServiceLogoutUrl](docs/SelfServiceLogoutUrl.md)
 - [OryClient::SelfServiceRecoveryFlow](docs/SelfServiceRecoveryFlow.md)
 - [OryClient::SelfServiceRecoveryFlowState](docs/SelfServiceRecoveryFlowState.md)
 - [OryClient::SelfServiceRecoveryLink](docs/SelfServiceRecoveryLink.md)
 - [OryClient::SelfServiceRegistrationFlow](docs/SelfServiceRegistrationFlow.md)
 - [OryClient::SelfServiceSettingsFlow](docs/SelfServiceSettingsFlow.md)
 - [OryClient::SelfServiceSettingsFlowState](docs/SelfServiceSettingsFlowState.md)
 - [OryClient::SelfServiceVerificationFlow](docs/SelfServiceVerificationFlow.md)
 - [OryClient::SelfServiceVerificationFlowState](docs/SelfServiceVerificationFlowState.md)
 - [OryClient::Session](docs/Session.md)
 - [OryClient::SessionAuthenticationMethod](docs/SessionAuthenticationMethod.md)
 - [OryClient::SessionDevice](docs/SessionDevice.md)
 - [OryClient::SettingsProfileFormConfig](docs/SettingsProfileFormConfig.md)
 - [OryClient::StripeCustomerResponse](docs/StripeCustomerResponse.md)
 - [OryClient::SubjectSet](docs/SubjectSet.md)
 - [OryClient::SubmitSelfServiceFlowWithWebAuthnRegistrationMethod](docs/SubmitSelfServiceFlowWithWebAuthnRegistrationMethod.md)
 - [OryClient::SubmitSelfServiceLoginFlowBody](docs/SubmitSelfServiceLoginFlowBody.md)
 - [OryClient::SubmitSelfServiceLoginFlowWithLookupSecretMethodBody](docs/SubmitSelfServiceLoginFlowWithLookupSecretMethodBody.md)
 - [OryClient::SubmitSelfServiceLoginFlowWithOidcMethodBody](docs/SubmitSelfServiceLoginFlowWithOidcMethodBody.md)
 - [OryClient::SubmitSelfServiceLoginFlowWithPasswordMethodBody](docs/SubmitSelfServiceLoginFlowWithPasswordMethodBody.md)
 - [OryClient::SubmitSelfServiceLoginFlowWithTotpMethodBody](docs/SubmitSelfServiceLoginFlowWithTotpMethodBody.md)
 - [OryClient::SubmitSelfServiceLoginFlowWithWebAuthnMethodBody](docs/SubmitSelfServiceLoginFlowWithWebAuthnMethodBody.md)
 - [OryClient::SubmitSelfServiceLogoutFlowWithoutBrowserBody](docs/SubmitSelfServiceLogoutFlowWithoutBrowserBody.md)
 - [OryClient::SubmitSelfServiceRecoveryFlowBody](docs/SubmitSelfServiceRecoveryFlowBody.md)
 - [OryClient::SubmitSelfServiceRecoveryFlowWithLinkMethodBody](docs/SubmitSelfServiceRecoveryFlowWithLinkMethodBody.md)
 - [OryClient::SubmitSelfServiceRegistrationFlowBody](docs/SubmitSelfServiceRegistrationFlowBody.md)
 - [OryClient::SubmitSelfServiceRegistrationFlowWithOidcMethodBody](docs/SubmitSelfServiceRegistrationFlowWithOidcMethodBody.md)
 - [OryClient::SubmitSelfServiceRegistrationFlowWithPasswordMethodBody](docs/SubmitSelfServiceRegistrationFlowWithPasswordMethodBody.md)
 - [OryClient::SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody](docs/SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody.md)
 - [OryClient::SubmitSelfServiceSettingsFlowBody](docs/SubmitSelfServiceSettingsFlowBody.md)
 - [OryClient::SubmitSelfServiceSettingsFlowWithLookupMethodBody](docs/SubmitSelfServiceSettingsFlowWithLookupMethodBody.md)
 - [OryClient::SubmitSelfServiceSettingsFlowWithOidcMethodBody](docs/SubmitSelfServiceSettingsFlowWithOidcMethodBody.md)
 - [OryClient::SubmitSelfServiceSettingsFlowWithPasswordMethodBody](docs/SubmitSelfServiceSettingsFlowWithPasswordMethodBody.md)
 - [OryClient::SubmitSelfServiceSettingsFlowWithProfileMethodBody](docs/SubmitSelfServiceSettingsFlowWithProfileMethodBody.md)
 - [OryClient::SubmitSelfServiceSettingsFlowWithTotpMethodBody](docs/SubmitSelfServiceSettingsFlowWithTotpMethodBody.md)
 - [OryClient::SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody](docs/SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody.md)
 - [OryClient::SubmitSelfServiceVerificationFlowBody](docs/SubmitSelfServiceVerificationFlowBody.md)
 - [OryClient::SubmitSelfServiceVerificationFlowWithLinkMethodBody](docs/SubmitSelfServiceVerificationFlowWithLinkMethodBody.md)
 - [OryClient::Subscription](docs/Subscription.md)
 - [OryClient::SuccessfulProjectUpdate](docs/SuccessfulProjectUpdate.md)
 - [OryClient::SuccessfulSelfServiceLoginWithoutBrowser](docs/SuccessfulSelfServiceLoginWithoutBrowser.md)
 - [OryClient::SuccessfulSelfServiceRegistrationWithoutBrowser](docs/SuccessfulSelfServiceRegistrationWithoutBrowser.md)
 - [OryClient::UiContainer](docs/UiContainer.md)
 - [OryClient::UiNode](docs/UiNode.md)
 - [OryClient::UiNodeAnchorAttributes](docs/UiNodeAnchorAttributes.md)
 - [OryClient::UiNodeAttributes](docs/UiNodeAttributes.md)
 - [OryClient::UiNodeImageAttributes](docs/UiNodeImageAttributes.md)
 - [OryClient::UiNodeInputAttributes](docs/UiNodeInputAttributes.md)
 - [OryClient::UiNodeMeta](docs/UiNodeMeta.md)
 - [OryClient::UiNodeScriptAttributes](docs/UiNodeScriptAttributes.md)
 - [OryClient::UiNodeTextAttributes](docs/UiNodeTextAttributes.md)
 - [OryClient::UiText](docs/UiText.md)
 - [OryClient::UpdateCustomHostnameBody](docs/UpdateCustomHostnameBody.md)
 - [OryClient::UpdateProject](docs/UpdateProject.md)
 - [OryClient::UpdateSubscriptionPayload](docs/UpdateSubscriptionPayload.md)
 - [OryClient::VerifiableIdentityAddress](docs/VerifiableIdentityAddress.md)
 - [OryClient::Version](docs/Version.md)
 - [OryClient::Warning](docs/Warning.md)


## Documentation for Authorization


### oryAccessToken

- **Type**: Bearer authentication

