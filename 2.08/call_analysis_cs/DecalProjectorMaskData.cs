using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DecalProjectorMaskData
{
	public Transform m_ParentTransform;

	public Vector3 m_OffsetPosition;

	public Quaternion m_OffsetRotation;

	public int m_MaskTextureIndex;

	public DecalMaskMode m_MaskMode;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public DecalProjectorMaskData()
	{
	}
}
