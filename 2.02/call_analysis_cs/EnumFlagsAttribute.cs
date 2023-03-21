using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EnumFlagsAttribute : PropertyAttribute
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public EnumFlagsAttribute()
	{
	}
}
