using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class RenderBehindMoon : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RenderBehindMoon()
	{
	}
}
