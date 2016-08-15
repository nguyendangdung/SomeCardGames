#pragma once

#ifndef __PROJECT_EXPORT_H
#define __PROJECT_EXPORT_H

#ifdef USEPROJECTLIBRARY
#ifdef  PROJECTLIBRARY_EXPORTS 
#define PROJECTAPI __declspec(dllexport)
#else
#define PROJECTAPI __declspec(dllimport)
#endif
#else
#define PROJECTAPI
#endif

#endif

class Export
{
public:
	Export();
	~Export();
};

