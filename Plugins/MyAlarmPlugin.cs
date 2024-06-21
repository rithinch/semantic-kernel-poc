using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace semantic_kernel_poc;

public class MyAlarmPlugin(MyTimePlugin timePlugin)
{
    [KernelFunction, Description("Sets an alarm at the provided time")]
    public void SetAlarm(string time)
    {
        // Code to actually set the alarm using the time plugin would be placed here
        _ = timePlugin;
    }
}
