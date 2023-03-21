using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ExampleCommandsUnityScript : MonoBehaviour
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void EchoNothing()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ExampleCommandsUnityScript()
	{
	}
}
