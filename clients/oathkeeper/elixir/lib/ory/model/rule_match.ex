# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.RuleMatch do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :"methods",
    :"url"
  ]

  @type t :: %__MODULE__{
    :"methods" => [String.t] | nil,
    :"url" => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.RuleMatch do
  def decode(value, _options) do
    value
  end
end

