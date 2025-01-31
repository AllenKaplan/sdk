# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Keto.Model.DeleteRelationTuplesBadRequestBody do
  @moduledoc """
  DeleteRelationTuplesBadRequestBody DeleteRelationTuplesBadRequestBody DeleteRelationTuplesBadRequestBody DeleteRelationTuplesBadRequestBody DeleteRelationTuplesBadRequestBody DeleteRelationTuplesBadRequestBody delete relation tuples bad request body
  """

  @derive [Poison.Encoder]
  defstruct [
    :"code",
    :"details",
    :"message",
    :"reason",
    :"request",
    :"status"
  ]

  @type t :: %__MODULE__{
    :"code" => integer() | nil,
    :"details" => [map()] | nil,
    :"message" => String.t | nil,
    :"reason" => String.t | nil,
    :"request" => String.t | nil,
    :"status" => String.t | nil
  }
end

defimpl Poison.Decoder, for: Keto.Model.DeleteRelationTuplesBadRequestBody do
  def decode(value, _options) do
    value
  end
end

