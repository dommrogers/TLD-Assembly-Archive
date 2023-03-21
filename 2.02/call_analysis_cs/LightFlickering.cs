using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
	public float duration;

	public Color color0;

	public Color color1;

	private Light m_Light;

	private float m_CurrentTime;

	private float m_StartingValue;

	private float m_Destination;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightFlickering()
	{
	}
}
