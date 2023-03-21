using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public class GraphInfoAttribute : Attribute
{
	public string packageName;

	public string docsURL;

	public string resourcesURL;

	public string forumsURL;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public GraphInfoAttribute()
	{
	}
}
