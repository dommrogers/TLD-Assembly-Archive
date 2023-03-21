using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HorizonCloudsBand : MonoBehaviour
{
	public enum HorizonBandId
	{
		Band1,
		Band2,
		Band3,
		Grad,
		SkyCloudEdge1,
		SkyCloudEdge2
	}

	public HorizonBandId m_HorizonBandId;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand2Renderer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand2Renderer")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HorizonCloudsBand()
	{
	}
}
