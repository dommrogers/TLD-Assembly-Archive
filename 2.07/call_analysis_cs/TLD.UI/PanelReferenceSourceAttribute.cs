using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI;

public class PanelReferenceSourceAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PanelReferenceSourceAttribute()
	{
	}
}
