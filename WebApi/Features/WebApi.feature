Feature: WebApi

Scenario: Upload

	Given We have file to upload
	When We send request to upload
	Then We get uploaded file

Scenario: Get_metadata

	Given We have file to get metadata
	When We send request to get metadata
	Then We get metadata 

Scenario: Delete

	Given We have file to delete
	When We send request to delete
	Then We responce that file delited 