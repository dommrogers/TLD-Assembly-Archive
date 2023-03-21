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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetSkyCloudEdge2Renderer")]
	[CallsUnknownMethods(Count = 11)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetSkyCloudEdge2Renderer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HorizonCloudsBand()
	{
	}
}
