using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightRandomColor : MonoBehaviour
{
	public MinMax m_Hue;

	public MinMax m_Saturation;

	public MinMax m_Value;

	public float m_LerpSpeed;

	public float m_IntervalSeconds;

	private Color m_TargetColor;

	private Light m_Light;

	private float m_CurrentTime;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Random), Member = "ColorHSV")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "ColorHSV")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightRandomColor()
	{
	}
}
