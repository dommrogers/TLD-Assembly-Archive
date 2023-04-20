using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Utility;

public class EditorReadOnlyAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public EditorReadOnlyAttribute()
	{
	}
}
