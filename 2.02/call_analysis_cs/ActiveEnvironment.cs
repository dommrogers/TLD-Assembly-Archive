using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ActiveEnvironment
{
	private TODStateConfig m_WorkA;

	private TODStateConfig m_WorkB;

	public TODStateConfig m_TodState;

	public float m_GrassTintScalar;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Init")]
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

	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[CallsUnknownMethods(Count = 61)]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "UpdateLutForTimeOfDay")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TODStateConfig), Member = "SetBlended")]
	public void Refresh(WeatherStateConfig wsA, WeatherStateConfig wsB, float weatherBlendFrac, TODBlendState todBlendState, float todBlendFrac, float todBlendBiased, bool isIndoors)
	{
	}
}
