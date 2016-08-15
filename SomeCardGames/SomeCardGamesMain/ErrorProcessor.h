#pragma once

#include "Export.h"

#include <exception>

using namespace std;

/// <summary>
/// This class is used to hold and report this program's errors.
/// </summary>
class PROJECTAPI ErrorProcessor
{
public:

	/// <summary>
	/// The constructor for this class.
	/// </summary>
	ErrorProcessor();

	/// <summary>
	/// The deconstructor for this class.
	/// </summary>
	~ErrorProcessor();

	/// <summary>
	/// This will report an exception that happened in this application.
	/// </summary>
	/// <param name="ReportMe">The exception to report.</param>
	void Report(exception *ReportMe);
};