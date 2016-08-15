#pragma once
#include "ErrorProcessor.h"

#include <exception>
#include <string>

using namespace std;

/// <summary>
/// A class used to throw errors.
/// </summary>
class PROJECTAPI Error
{
public:
	ErrorProcessor *Processor = new ErrorProcessor();

string *ErrorValueOutOfAcceptableRange = new string("The value of an integer is out of the accepted range");

	/// <summary>
	/// The constructor for the Error class.
	/// </summary>
	Error();

	/// <summary>
	/// The deconstructor for the Error class.
	/// </summary>
	~Error();

	/// <summary>
	/// Used to throw a custom exception.
	/// </summary>
	/// <param name="TheException">The message to give the exception.</param>
	void ThrowException(string *TheException)
	{
		this->Processor->Report(new exception(TheException->c_str()));
		throw new exception(TheException->c_str());
	}
};