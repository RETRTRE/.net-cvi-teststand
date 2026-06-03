#include "AiAcquire.h"
#include <NIDAQmx.h>

AI_API int __cdecl TestAdd(int a, int b)
{
    return a + b;
}

AI_API double __cdecl ReadScaledVoltage(const char channelName[], double scale)
{
    int32 error = 0;
    TaskHandle taskHandle = 0;
    float64 rawValue = 0.0;

    if (channelName == NULL)
        return -99999.0;

    error = DAQmxCreateTask("", &taskHandle);
    if (error < 0) goto Error;

    error = DAQmxCreateAIVoltageChan(
        taskHandle,
        channelName,
        "",
        DAQmx_Val_Cfg_Default,
        -10.0,
        10.0,
        DAQmx_Val_Volts,
        NULL
    );
    if (error < 0) goto Error;

    error = DAQmxStartTask(taskHandle);
    if (error < 0) goto Error;

    error = DAQmxReadAnalogScalarF64(taskHandle, 10.0, &rawValue, NULL);
    if (error < 0) goto Error;

    DAQmxStopTask(taskHandle);
    DAQmxClearTask(taskHandle);

    return rawValue * scale;

Error:
    if (taskHandle != 0)
    {
        DAQmxStopTask(taskHandle);
        DAQmxClearTask(taskHandle);
    }

    return -99999.0;
}