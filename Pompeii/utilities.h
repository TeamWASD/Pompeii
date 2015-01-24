//
//  utilities.h
//  DinoDodge
//
//  Created by Lewis Fox on 11/20/14.
//  Copyright (c) 2014 LRFLEW. All rights reserved.
//

#ifndef __DinoDodge__utilities__
#define __DinoDodge__utilities__

#include <SDL2/SDL.h>

void SDL_Log(SDL_LogPriority priority, const char* fmt, ...);
void logAndCrashSDL(const char* error);

#endif /* defined(__DinoDodge__utilities__) */
