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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateFresnel(float fresnelExponent, float fresnelBias, float fresnelGain, Color fresnelColour)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TerrainFresnelControl()
	{
	}
}
