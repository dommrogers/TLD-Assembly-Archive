using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class PrefabInstantiateData
{
	public GameObject m_Prefab;

	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public Vector3 m_LocalScale;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PrefabInstantiateData()
	{
	}
}
