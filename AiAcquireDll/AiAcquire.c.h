#ifndef __AI_ACQUIRE_H__
#define __AI_ACQUIRE_H__

#ifdef __cplusplus
extern "C" {
#endif

#ifdef AIACQUIRE_EXPORTS
    #define AI_API __declspec(dllexport)
#else
    #define AI_API __declspec(dllimport)
#endif

AI_API int ReadScaledVoltage(const char* channelName, double scale, double* measuredValue);

#ifdef __cplusplus
}
#endif

#endif