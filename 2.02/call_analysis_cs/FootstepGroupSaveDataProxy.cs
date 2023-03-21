using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FootstepGroupSaveDataProxy
{
	public Vector3 m_Pos;

	public Vector3 m_BoundsSize;

	public float m_BaseSnowDepth;

	public float m_ExpireSnowDepth;

	public int m_BaseIndex;

	public int m_Num;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public FootstepGroupSaveDataProxy()
	{
	}
}
