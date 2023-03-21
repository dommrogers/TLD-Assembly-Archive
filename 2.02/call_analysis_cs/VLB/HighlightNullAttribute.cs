using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public sealed class HighlightNullAttribute : PropertyAttribute
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public HighlightNullAttribute()
	{
	}
}
