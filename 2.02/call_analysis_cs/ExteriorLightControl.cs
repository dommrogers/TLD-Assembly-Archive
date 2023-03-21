using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExteriorLightControl : MonoBehaviour
{
	public ScaledCurve m_TodCurve;

	private Light[] m_Lights;

	private float[] m_LightVals;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
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
