using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathOrientation : CameraPathPoint
{
	public Quaternion rotation;

	public Transform lookAt;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CameraPathOrientation()
	{
	}
}
