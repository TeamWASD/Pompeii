//
//  utilities.cpp
//  Pompeii
//
//  Created by Team WASD on 1/23/15.
//  Copyright (c) 2015 Team WASD. All rights reserved.
//

#include "utilities.h"
#include <cstdlib>

void SDL_Log(SDL_LogPriority priority, const char* fmt, ...) {
	va_list ap;
	
	va_start(ap, fmt);
	SDL_LogMessageV(SDL_LOG_CATEGORY_APPLICATION, priority, fmt, ap);
	va_end(ap);
}

void logAndCrashSDL(const char* error) {
	const char* msg = SDL_GetError();
	SDL_Log(SDL_LOG_PRIORITY_CRITICAL, "%s: %s", error, msg);
	if (SDL_ShowSimpleMessageBox(SDL_MESSAGEBOX_ERROR, error, msg, NULL))
		SDL_Log(SDL_LOG_PRIORITY_CRITICAL, "Error presenting error");
	SDL_Quit();
	std::exit(-1);
}
