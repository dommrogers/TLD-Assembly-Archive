using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class SerializableBounds
{
	public Vector3 m_Center;

	public Vector3 m_Size;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Contains(Vector3 point)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SerializableBounds()
	{
	}
}
