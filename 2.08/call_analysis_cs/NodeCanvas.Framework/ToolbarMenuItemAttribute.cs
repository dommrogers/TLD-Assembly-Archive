using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public class ToolbarMenuItemAttribute : Attribute
{
	public readonly string path;

	[CallerCount(Count = 279)]
	[DeduplicatedMethod]
	public ToolbarMenuItemAttribute(string path)
	{
	}
}
