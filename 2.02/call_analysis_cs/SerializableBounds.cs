using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class SerializableBounds
{
	public Vector3 m_Center;

	public Vector3 m_Size;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool Contains(Vector3 point)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SerializableBounds()
	{
	}
}
