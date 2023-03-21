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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LightLevelToParticleAlpha()
	{
	}
}
