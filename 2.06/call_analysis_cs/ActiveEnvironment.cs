using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ActiveEnvironment
{
	private TODStateData m_WorkA;

	private TODStateData m_WorkB;

	public TODStateData m_TodState;

	public float m_GrassTintScalar;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public ActiveEnvironment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[CallsUnknownMethods(Count = 1)]
	public void Set(TODStateData tod)
	{
	}

	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "UpdateLutForTimeOfDay")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[CallsUnknownMethods(Count = 2)]
	public void Refresh(WeatherStatesData wsA, WeatherStatesData wsB, float weatherBlendFrac, TODBlendState todBlendState, float todBlendFrac, float todBlendBiased, bool isIndoors)
	{
	}
}
