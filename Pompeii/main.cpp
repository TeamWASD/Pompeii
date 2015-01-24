//
//  main.cpp
//  GLTest
//
//  Created by Lewis Fox on 1/5/15.
//  Copyright (c) 2015 LRFLEW. All rights reserved.
//

#include "utilities.h"

int main(int argc, char *argv[]) {
    
    if (SDL_Init(SDL_INIT_EVERYTHING)) logAndCrashSDL("SDL_Init");
    SDL_LogSetAllPriority(SDL_LOG_PRIORITY_VERBOSE);
    
    SDL_Window *win = SDL_CreateWindow("Pompeii", 0, 0, 640, 480, 0);
    if (win == NULL) logAndCrashSDL("SDL_CreateWindow");
    
    bool run = true;
    while (run) {
        SDL_Event event;
        if (SDL_WaitEvent(&event)) {
            switch (event.type) {
                case SDL_QUIT:
                    run = false;
                    break;
                    
                default:
                    break;
            }
        }
    }
    
    SDL_DestroyWindow(win);
    SDL_Quit();
    
    return 0;
}
