using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightLevelToParticleAlpha : MonoBehaviour
{
	public float m_DefaultAlpha;

	public bool m_EstimateColor;

	private ParticleSystemRenderer m_Renderer;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightLevelToParticleAlpha()
	{
	}
}
