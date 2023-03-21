using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public class ToolbarMenuItemAttribute : Attribute
{
	public readonly string path;

	[DeduplicatedMethod]
	[CallerCount(Count = 269)]
	public ToolbarMenuItemAttribute(string path)
	{
	}
}
