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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateFresnel(float fresnelExponent, float fresnelBias, float fresnelGain, Color fresnelColour)
	{
	}

	[CallerCount(Count = 0)]
	public TerrainFresnelControl()
	{
	}
}
