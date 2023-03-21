using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct SnowImprintExpanded
{
	public Vector3 m_Position;

	public Vector4 m_HeightMapUvInfo;

	public Vector4 m_DecalMainTexUvInfo;

	public Vector4 m_DecalBumpMapUvInfo;

	public Vector3 m_HeightMapRenderScalar;

	public Vector3 m_NormalMapRenderScalar;

	public Quaternion m_UpRot;

	public Quaternion m_NormRot;

	public Vector3 m_Normal;

	public float m_Depth;

	public float m_InitialSnowDepth;

	public float m_Flip;

	public bool m_HasHeightMap;

	public bool m_HasBumpDecal;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[CalledBy(Type = typeof(SnowImprintExpanded), Member = "op_Explicit")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	[Calls(Type = typeof(SnowImprint), Member = "get_Position")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UvList), Member = "GetUvs")]
	[CallsDeduplicatedMethods(Count = 3)]
	public SnowImprintExpanded(SnowImprint im)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowImprintExpanded), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public static explicit operator SnowImprintExpanded(SnowImprint im)
	{
		return default(SnowImprintExpanded);
	}
}
