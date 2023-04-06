using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AutoComponentAttribute : Attribute
{
	private ComponentRequirement m_Requirement;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AutoComponentAttribute(ComponentRequirement requirement)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ApplyBinding(Component target)
	{
	}
}
