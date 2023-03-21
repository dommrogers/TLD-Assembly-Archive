using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkLightIntensityToEmissiveTex : MonoBehaviour
{
	public Light m_SourceLight;

	public Material m_DestinationMaterial;

	public float m_IntensityMultiplier;

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LinkLightIntensityToEmissiveTex()
	{
	}
}
