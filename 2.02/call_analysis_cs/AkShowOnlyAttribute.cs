using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkShowOnlyAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AkShowOnlyAttribute()
	{
	}
}
