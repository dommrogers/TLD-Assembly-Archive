using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ExampleCommandsUnityScript : MonoBehaviour
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void Start()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void EchoNothing()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ExampleCommandsUnityScript()
	{
	}
}
