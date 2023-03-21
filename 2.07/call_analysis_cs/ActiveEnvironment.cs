using Cpp2ILInjected.CallAnalysis;
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "UpdateLutForTimeOfDay")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TODStateData), Member = "SetBlended")]
	public void Refresh(WeatherStatesData wsA, WeatherStatesData wsB, float weatherBlendFrac, TODBlendState todBlendState, float todBlendFrac, float todBlendBiased, bool isIndoors)
	{
	}
}
