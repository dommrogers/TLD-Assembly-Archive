using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightLevelToParticleAlpha : MonoBehaviour
{
	public float m_DefaultAlpha;

	public bool m_EstimateColor;

	private ParticleSystemRenderer m_Renderer;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LightLevelToParticleAlpha()
	{
	}
}
