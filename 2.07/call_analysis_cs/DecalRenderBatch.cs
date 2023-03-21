using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DecalRenderBatch
{
	public const int MAX_INSTANCES = 500;

	public MaterialPropertyBlock m_Block;

	public Matrix4x4[] m_Transforms;

	public float[] m_FadeProperties;

	public Vector4[] m_MainTexUVProperties;

	public float[] m_ClipAngles;

	public Material m_Material;

	public int m_Count;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderStaticScreenSpaceDecals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public DecalRenderBatch()
	{
	}
}
