using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Utility;

public class MaterialTagAttribute : PropertyAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MaterialTagAttribute()
	{
	}
}
