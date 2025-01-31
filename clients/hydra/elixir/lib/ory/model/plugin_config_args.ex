# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.PluginConfigArgs do
  @moduledoc """
  PluginConfigArgs plugin config args
  """

  @derive [Poison.Encoder]
  defstruct [
    :"Description",
    :"Name",
    :"Settable",
    :"Value"
  ]

  @type t :: %__MODULE__{
    :"Description" => String.t,
    :"Name" => String.t,
    :"Settable" => [String.t],
    :"Value" => [String.t]
  }
end

defimpl Poison.Decoder, for: Ory.Model.PluginConfigArgs do
  def decode(value, _options) do
    value
  end
end

