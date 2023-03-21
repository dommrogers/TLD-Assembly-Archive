using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkShowOnlyAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AkShowOnlyAttribute()
	{
	}
}
