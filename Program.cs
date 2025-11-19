//*****************************************************************************
//** 2154. Keep Multiplying Found Values by Two                     leetcode **
//*****************************************************************************
//** A number hides within the list, a seed you seek to find,                **
//** Every time you catch it, twill doubles in its mind.                     **
//** You chase its echoes through the array, until no match is true          **
//** And when the trail at last runs out, its final form comes through.      **
//*****************************************************************************

int findFinalValue(int* nums, int numsSize, int original) {
    int coffee[3001] = {0};
    int output = original;
    for(int i = 0; i < numsSize; i++)
    {
        coffee[nums[i]]++;
    }
    int found = 1;
    while(found == 1)
    {
        if(coffee[output] > 0)
        {
            output = output * 2;
        }
        else
            found = 0;
    }
    return output;
}