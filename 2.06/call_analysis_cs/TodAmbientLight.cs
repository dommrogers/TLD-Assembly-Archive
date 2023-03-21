using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TodAmbientLight : MonoBehaviour
{
	public Color m_AmbientIndoorsDay;

	public Color m_AmbientIndoorsNight;

	public float m_FineTuneDay;

	public float m_FineTuneNight;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(InteriorLightingManager), Member = "UpdateLights")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateAmbient")]
	[Calls(Type = typeof(Utils), Member = "SetAmbientLightScaled")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	public void SetAmbientLightValue(float todValue, float multiplier)
	{
	}

	[CallerCount(Count = 0)]
	private Color FineTune(Color c, float a)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TodAmbientLight()
	{
	}
}
