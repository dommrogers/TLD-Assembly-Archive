using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExteriorLightControl : MonoBehaviour
{
	public ScaledCurve m_TodCurve;

	private Light[] m_Lights;

	private float[] m_LightVals;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 33)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ExteriorLightControl()
	{
	}
}
