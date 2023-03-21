using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class SnowImprintDef
{
	public string name;

	public int m_MaxFootstepGroupsPerTrail;

	public Vector3 m_GroupMaxBoundsSize;

	public float m_ImprintBoundsSize;

	public Vector2 m_StandardDepthRange;

	public Vector2 m_DeepDepthRange;

	public float m_EndFadeRadius;

	public bool m_ChooseVariantByDepth;

	public SnowImprintQualitySettings m_LowQualitySettings;

	public SnowImprintQualitySettings m_MediumQualitySettings;

	public SnowImprintQualitySettings m_HighQualitySettings;

	public SnowImprintQualitySettings m_UltraQualitySettings;

	public SnowImprintQualitySettings m_XboxQualitySettings;

	public SnowImprintQualitySettings m_PS4QualitySettings;

	public SnowImprintVariant[] m_ImprintVariants;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SnowImprintDef()
	{
	}
}
