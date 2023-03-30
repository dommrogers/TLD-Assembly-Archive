using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightLevelToParticleAlpha : MonoBehaviour
{
	public float m_DefaultAlpha;

	public bool m_EstimateColor;

	private ParticleSystemRenderer m_Renderer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LightLevelToParticleAlpha()
	{
	}
}
