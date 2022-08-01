# -*- encoding: utf-8 -*-

=begin
#Ory Keto API

#Documentation for all of Ory Keto's REST APIs. gRPC is documented separately. 

The version of the OpenAPI document: v0.9.0-alpha.0
Contact: hi@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

$:.push File.expand_path("../lib", __FILE__)
require "ory-keto-client/version"

Gem::Specification.new do |s|
  s.name        = "ory-keto-client"
  s.version     = OryKetoClient::VERSION
  s.platform    = Gem::Platform::RUBY
  s.authors     = ["ORY GmbH"]
  s.email       = ["opensource@ory.sh"]
  s.homepage    = "https://www.ory.sh"
  s.summary     = "Ory Keto API Ruby Gem"
  s.description = "Documentation for all of Ory Keto's REST APIs. gRPC is documented separately. "
  s.license     = "Apache-2.0"
  s.required_ruby_version = ">= 2.4"

  s.add_runtime_dependency 'typhoeus', '~> 1.0', '>= 1.0.1'

  s.add_development_dependency 'rspec', '~> 3.6', '>= 3.6.0'

  s.files         = `find *`.split("\n").uniq.sort.select { |f| !f.empty? }
  s.test_files    = `find spec/*`.split("\n")
  s.executables   = []
  s.require_paths = ["lib"]
end
