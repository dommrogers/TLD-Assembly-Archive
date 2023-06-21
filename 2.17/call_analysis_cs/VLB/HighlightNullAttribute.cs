using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public sealed class HighlightNullAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HighlightNullAttribute()
	{
	}
}
