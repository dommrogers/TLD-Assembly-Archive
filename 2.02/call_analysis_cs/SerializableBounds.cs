using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class SerializableBounds
{
	public Vector3 m_Center;

	public Vector3 m_Size;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool Contains(Vector3 point)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SerializableBounds()
	{
	}
}
