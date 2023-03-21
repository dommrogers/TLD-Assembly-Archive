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

	[Calls(Type = typeof(Fire), Member = "GetIgnitionTotalGameTimeSeconds")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public void SetNewMaxTime(float newMax)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightFadeFire()
	{
	}
}
