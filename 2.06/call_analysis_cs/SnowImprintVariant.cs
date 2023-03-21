using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class SnowImprintVariant
{
	public SnowImprintRenderType m_RenderType;

	public string m_HeightMapTexId;

	public float m_HeightMapRenderScalar;

	public string m_BumpDecalTexId;

	public float m_BumpDecalRenderScalar;

	public Vector2 m_DepthSelectionRange;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SnowImprintVariant()
	{
	}
}
