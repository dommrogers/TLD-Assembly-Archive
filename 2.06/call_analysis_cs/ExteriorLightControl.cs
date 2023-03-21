using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExteriorLightControl : MonoBehaviour
{
	public ScaledCurve m_TodCurve;

	private Light[] m_Lights;

	private float[] m_LightVals;

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ExteriorLightControl()
	{
	}
}
