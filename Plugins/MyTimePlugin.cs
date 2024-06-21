using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace semantic_kernel_poc;

public class MyTimePlugin
{
    [KernelFunction, Description("Get the current time")]
    public DateTimeOffset Time() => DateTimeOffset.Now;
}
