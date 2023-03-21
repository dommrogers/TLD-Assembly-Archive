using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AkGameObjPositionOffsetData
{
	public bool KeepMe;

	public Vector3 positionOffset;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AkGameObjPositionOffsetData(bool IReallyWantToBeConstructed = false)
	{
	}
}
