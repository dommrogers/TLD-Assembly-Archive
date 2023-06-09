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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LightFlickering()
	{
	}
}
