using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class QualityLevelSettings
{
	public bool m_ShadowsEnabled;

	public QualityShadows m_ShadowQuality;

	public ShadowResolution m_ShadowResolution;

	public QualityPostFx m_PostFxQuality;

	public QualityFootprints m_FootprintsQuality;

	public QualitySSAO m_SSAO;

	public QualityLodBias m_LodBiasQuality;

	public QualityTerrainLod m_TerrainLodQuality;

	public int m_MasterTextureLimit;

	public bool m_TextureStreamingEnabled;

	public int m_TextureStreamingBudget;

	public float m_ShadowDrawDistance;

	public float m_TreeDrawDistance;

	public float m_TreeBillboardDistance;

	public float m_GroundDetailsDrawDistance;

	public float m_GroundDetailsDensity;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public QualityLevelSettings()
	{
	}
}
