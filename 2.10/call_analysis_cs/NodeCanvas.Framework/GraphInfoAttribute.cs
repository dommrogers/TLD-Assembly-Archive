using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public class GraphInfoAttribute : Attribute
{
	public string packageName;

	public string docsURL;

	public string resourcesURL;

	public string forumsURL;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public GraphInfoAttribute()
	{
	}
}
