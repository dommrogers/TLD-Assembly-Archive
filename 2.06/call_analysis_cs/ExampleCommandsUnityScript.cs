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

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ExampleCommandsUnityScript()
	{
	}
}
