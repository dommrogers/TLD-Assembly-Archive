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
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "ColorHSV")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LightRandomColor()
	{
	}
}
