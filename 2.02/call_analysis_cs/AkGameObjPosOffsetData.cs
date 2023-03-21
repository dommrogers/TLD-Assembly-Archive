using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkGameObjPosOffsetData : ScriptableObject
{
	public Vector3 positionOffset;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public AkGameObjPosOffsetData()
	{
	}
}
