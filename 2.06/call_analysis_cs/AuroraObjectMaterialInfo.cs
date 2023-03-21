using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AuroraObjectMaterialInfo
{
	public Renderer m_Renderer;

	public Material m_AuroraMaterial;

	public Material m_NormalMaterial;

	private Material m_OriginalMaterial;

	[DeduplicatedMethod]
	[CallerCount(Count = 36)]
	public void SetOriginalMaterial(Material mat)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 58)]
	public Material GetOriginalMaterial()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AuroraObjectMaterialInfo()
	{
	}
}
