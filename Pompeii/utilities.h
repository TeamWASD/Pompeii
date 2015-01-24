//
//  utilities.h
//  DinoDodge
//
//  Created by Lewis Fox on 11/20/14.
//  Copyright (c) 2014 LRFLEW. All rights reserved.
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
