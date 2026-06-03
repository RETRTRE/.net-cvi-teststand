#ifndef __AI_ACQUIRE_H__
#define __AI_ACQUIRE_H__

#ifdef __cplusplus
extern "C" {
#endif

#define AI_API __declspec(dllexport)

AI_API int __cdecl TestAdd(int a, int b);
AI_API double __cdecl ReadScaledVoltage(const char channelName[], double scale);

#ifdef __cplusplus
}
#endif

#endif