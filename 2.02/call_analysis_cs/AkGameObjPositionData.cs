using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkGameObjPositionData
{
	public Vector3 forward;

	public Vector3 position;

	public Vector3 up;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AkGameObjPositionData()
	{
	}
}
