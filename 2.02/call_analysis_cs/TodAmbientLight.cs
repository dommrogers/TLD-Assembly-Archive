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
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetAmbientLight")]
	public void SetAmbientLightValue(float todValue, float multiplier)
	{
	}

	[CallerCount(Count = 0)]
	private Color FineTune(Color c, float a)
	{
		return default(Color);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TodAmbientLight()
	{
	}
}
