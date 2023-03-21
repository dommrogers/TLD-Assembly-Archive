using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public sealed class HighlightNullAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public HighlightNullAttribute()
	{
	}
}
