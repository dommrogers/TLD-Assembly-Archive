using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ActiveEnvironment
{
	private TODStateConfig m_WorkA;

	private TODStateConfig m_WorkB;

	public TODStateConfig m_TodState;

	public float m_GrassTintScalar;

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Init")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public ActiveEnvironment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[CallsUnknownMethods(Count = 1)]
	public void Set(TODStateConfig tod)
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "UpdateLutForTimeOfDay")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 61)]
	public void Refresh(WeatherStateConfig wsA, WeatherStateConfig wsB, float weatherBlendFrac, TODBlendState todBlendState, float todBlendFrac, float todBlendBiased, bool isIndoors)
	{
	}
}
