// Code generated by go-swagger; DO NOT EDIT.

package admin

// This file was generated by the swagger tool.
// Editing this file might prove futile when you re-run the swagger generate command

import (
	"fmt"
	"io"

	"github.com/go-openapi/runtime"

	strfmt "github.com/go-openapi/strfmt"

	"github.com/ory/kratos-client-go/models"
)

// GetIdentityReader is a Reader for the GetIdentity structure.
type GetIdentityReader struct {
	formats strfmt.Registry
}

// ReadResponse reads a server response into the received o.
func (o *GetIdentityReader) ReadResponse(response runtime.ClientResponse, consumer runtime.Consumer) (interface{}, error) {
	switch response.Code() {
	case 200:
		result := NewGetIdentityOK()
		if err := result.readResponse(response, consumer, o.formats); err != nil {
			return nil, err
		}
		return result, nil
	case 400:
		result := NewGetIdentityBadRequest()
		if err := result.readResponse(response, consumer, o.formats); err != nil {
			return nil, err
		}
		return nil, result
	case 500:
		result := NewGetIdentityInternalServerError()
		if err := result.readResponse(response, consumer, o.formats); err != nil {
			return nil, err
		}
		return nil, result

	default:
		return nil, runtime.NewAPIError("unknown error", response, response.Code())
	}
}

// NewGetIdentityOK creates a GetIdentityOK with default headers values
func NewGetIdentityOK() *GetIdentityOK {
	return &GetIdentityOK{}
}

/*GetIdentityOK handles this case with default header values.

A single identity.

nolint:deadcode,unused
*/
type GetIdentityOK struct {
	Payload *models.Identity
}

func (o *GetIdentityOK) Error() string {
	return fmt.Sprintf("[GET /identities/{id}][%d] getIdentityOK  %+v", 200, o.Payload)
}

func (o *GetIdentityOK) GetPayload() *models.Identity {
	return o.Payload
}

func (o *GetIdentityOK) readResponse(response runtime.ClientResponse, consumer runtime.Consumer, formats strfmt.Registry) error {

	o.Payload = new(models.Identity)

	// response payload
	if err := consumer.Consume(response.Body(), o.Payload); err != nil && err != io.EOF {
		return err
	}

	return nil
}

// NewGetIdentityBadRequest creates a GetIdentityBadRequest with default headers values
func NewGetIdentityBadRequest() *GetIdentityBadRequest {
	return &GetIdentityBadRequest{}
}

/*GetIdentityBadRequest handles this case with default header values.

genericError
*/
type GetIdentityBadRequest struct {
	Payload *models.GenericError
}

func (o *GetIdentityBadRequest) Error() string {
	return fmt.Sprintf("[GET /identities/{id}][%d] getIdentityBadRequest  %+v", 400, o.Payload)
}

func (o *GetIdentityBadRequest) GetPayload() *models.GenericError {
	return o.Payload
}

func (o *GetIdentityBadRequest) readResponse(response runtime.ClientResponse, consumer runtime.Consumer, formats strfmt.Registry) error {

	o.Payload = new(models.GenericError)

	// response payload
	if err := consumer.Consume(response.Body(), o.Payload); err != nil && err != io.EOF {
		return err
	}

	return nil
}

// NewGetIdentityInternalServerError creates a GetIdentityInternalServerError with default headers values
func NewGetIdentityInternalServerError() *GetIdentityInternalServerError {
	return &GetIdentityInternalServerError{}
}

/*GetIdentityInternalServerError handles this case with default header values.

genericError
*/
type GetIdentityInternalServerError struct {
	Payload *models.GenericError
}

func (o *GetIdentityInternalServerError) Error() string {
	return fmt.Sprintf("[GET /identities/{id}][%d] getIdentityInternalServerError  %+v", 500, o.Payload)
}

func (o *GetIdentityInternalServerError) GetPayload() *models.GenericError {
	return o.Payload
}

func (o *GetIdentityInternalServerError) readResponse(response runtime.ClientResponse, consumer runtime.Consumer, formats strfmt.Registry) error {

	o.Payload = new(models.GenericError)

	// response payload
	if err := consumer.Consume(response.Body(), o.Payload); err != nil && err != io.EOF {
		return err
	}

	return nil
}
