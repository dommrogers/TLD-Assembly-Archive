using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightLevelToParticleAlpha : MonoBehaviour
{
	public float m_DefaultAlpha;

	public bool m_EstimateColor;

	private ParticleSystemRenderer m_Renderer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightLevelToParticleAlpha()
	{
	}
}
