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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Fire), Member = "GetIgnitionTotalGameTimeSeconds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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
