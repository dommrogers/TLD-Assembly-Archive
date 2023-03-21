using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TerrainFresnelControl : MonoBehaviour
{
	public float m_FresnelExponent;

	public float m_FresnelBias;

	public float m_FresnelGain;

	public Color m_FresnelColour;

	private Terrain m_Terrain;

	private Material m_TerrainMat;

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	public void UpdateFresnel(float fresnelExponent, float fresnelBias, float fresnelGain, Color fresnelColour)
	{
	}

	[CallerCount(Count = 0)]
	public TerrainFresnelControl()
	{
	}
}
