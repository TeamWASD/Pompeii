//
//  utilities.h
//  Pompeii
//
//  Created by Team WASD on 1/23/15.
//  Copyright (c) 2015 Team WASD. All rights reserved.
//

#ifndef __Pompeii__utilities__
#define __Pompeii__utilities__

#ifdef SDL_STATIC_IMPORT
#include <SDL2/SDL.h>
#else
#include "SDL.h"
#endif

void SDL_Log(SDL_LogPriority priority, const char* fmt, ...);
void logAndCrashSDL(const char* error);

#endif /* defined(__Pompeii__utilities__) */
