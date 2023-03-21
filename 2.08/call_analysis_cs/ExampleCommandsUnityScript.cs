using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ExampleCommandsUnityScript : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void EchoNothing()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ExampleCommandsUnityScript()
	{
	}
}
