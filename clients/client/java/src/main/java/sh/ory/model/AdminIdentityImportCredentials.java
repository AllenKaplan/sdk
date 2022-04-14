/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.167
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import sh.ory.model.AdminCreateIdentityImportCredentialsOidc;
import sh.ory.model.AdminCreateIdentityImportCredentialsPassword;

/**
 * AdminIdentityImportCredentials
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-04-14T12:00:18.510560049Z[Etc/UTC]")
public class AdminIdentityImportCredentials {
  public static final String SERIALIZED_NAME_OIDC = "oidc";
  @SerializedName(SERIALIZED_NAME_OIDC)
  private AdminCreateIdentityImportCredentialsOidc oidc;

  public static final String SERIALIZED_NAME_PASSWORD = "password";
  @SerializedName(SERIALIZED_NAME_PASSWORD)
  private AdminCreateIdentityImportCredentialsPassword password;

  public AdminIdentityImportCredentials() { 
  }

  public AdminIdentityImportCredentials oidc(AdminCreateIdentityImportCredentialsOidc oidc) {
    
    this.oidc = oidc;
    return this;
  }

   /**
   * Get oidc
   * @return oidc
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public AdminCreateIdentityImportCredentialsOidc getOidc() {
    return oidc;
  }


  public void setOidc(AdminCreateIdentityImportCredentialsOidc oidc) {
    this.oidc = oidc;
  }


  public AdminIdentityImportCredentials password(AdminCreateIdentityImportCredentialsPassword password) {
    
    this.password = password;
    return this;
  }

   /**
   * Get password
   * @return password
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public AdminCreateIdentityImportCredentialsPassword getPassword() {
    return password;
  }


  public void setPassword(AdminCreateIdentityImportCredentialsPassword password) {
    this.password = password;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AdminIdentityImportCredentials adminIdentityImportCredentials = (AdminIdentityImportCredentials) o;
    return Objects.equals(this.oidc, adminIdentityImportCredentials.oidc) &&
        Objects.equals(this.password, adminIdentityImportCredentials.password);
  }

  @Override
  public int hashCode() {
    return Objects.hash(oidc, password);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AdminIdentityImportCredentials {\n");
    sb.append("    oidc: ").append(toIndentedString(oidc)).append("\n");
    sb.append("    password: ").append(toIndentedString(password)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

