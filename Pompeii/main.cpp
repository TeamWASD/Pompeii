//
//  main.cpp
//  Pompeii
//
//  Created by Team WASD on 1/23/15.
//  Copyright (c) 2015 Team WASD. All rights reserved.
//

#include "utilities.h"

int main(int argc, char *argv[]) {
    
    if (SDL_Init(SDL_INIT_EVERYTHING)) logAndCrashSDL("SDL_Init");
    
    SDL_Window *win = SDL_CreateWindow("Pompeii", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 640, 480, 0);
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
