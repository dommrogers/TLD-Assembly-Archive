using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EnumFlagsAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public EnumFlagsAttribute()
	{
	}
}
