using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ArrowSaveData
{
	public int m_InstanceID;

	public string m_HostGuid;

	public string m_LocalName;

	public Vector3 m_LocalPosition;

	public Vector3 m_LocalAngles;

	public float m_EmbeddedDepth;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ArrowSaveData()
	{
	}
}
