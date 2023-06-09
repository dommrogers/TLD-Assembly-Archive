using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathEvent : CameraPathPoint
{
	public enum Types
	{
		Broadcast,
		Call
	}

	public enum ArgumentTypes
	{
		None,
		Float,
		Int,
		String
	}

	public Types type;

	public string eventName;

	public GameObject target;

	public string methodName;

	public string methodArgument;

	public ArgumentTypes argumentType;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CameraPathEvent()
	{
	}
}
