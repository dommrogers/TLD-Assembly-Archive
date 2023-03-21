using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AutoComponentAttribute : Attribute
{
	private ComponentRequirement m_Requirement;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AutoComponentAttribute(ComponentRequirement requirement)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ApplyBinding(Component target)
	{
	}
}
