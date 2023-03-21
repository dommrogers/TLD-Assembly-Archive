using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class DisplayNameAttribute : Attribute
{
	public readonly string displayName;

	[DeduplicatedMethod]
	[CallerCount(Count = 269)]
	public DisplayNameAttribute(string displayName)
	{
	}
}
