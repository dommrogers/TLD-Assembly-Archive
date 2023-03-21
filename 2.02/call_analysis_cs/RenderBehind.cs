using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class RenderBehind : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public RenderBehind()
	{
	}
}
