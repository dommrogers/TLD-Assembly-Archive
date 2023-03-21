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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetSkyCloudEdge2Renderer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetSkyCloudEdge2Renderer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
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
