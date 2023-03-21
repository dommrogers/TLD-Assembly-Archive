using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightFadeFire : MonoBehaviour
{
	public Fire sourceFire;

	public bool startOff;

	public bool useFireIgnitionFirst;

	public bool autoSwitchAfterIngnition;

	public float fullOnMinutes;

	public float fullOffMinutes;

	private float originalBrightness;

	private float maxTimeSec;

	private float minTimeSec;

	private float ignitionDuration;

	private float fireTime;

	private float fadeTimeNormalized;

	private float fadeTimeDifference;

	private float fadeTimeStep;

	private Light m_Light;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Fire), Member = "GetIgnitionTotalGameTimeSeconds")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public void SetNewMaxTime(float newMax)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LightFadeFire()
	{
	}
}
