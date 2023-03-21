using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EnumFlagsAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public EnumFlagsAttribute()
	{
	}
}
