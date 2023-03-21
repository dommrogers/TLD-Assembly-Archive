using Cpp2ILInjected.CallAnalysis;

namespace TLD.ModularElectrolizer;

public class DistanceFadeControl
{
	private DistanceParameters m_OutdoorDistance;

	private DistanceParameters m_IndoorDistance;

	private float m_MaxCullDistSqr;

	private float m_MaxFadeDistSqr;

	private float m_DistanceIntensity;

	private QualityLodBias m_CachedQualitySetting;

	public float DistanceIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public float MaxDistanceSqr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public float MaxFadeSqr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 224)]
	public DistanceFadeControl(DistanceParameters outdoor, DistanceParameters indoor)
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CallerCount(Count = 4)]
	public void SetLocationDistances(bool useOutdoorValues, QualityLodBias quality, bool forceUpdate = false)
	{
	}

	[CallerCount(Count = 0)]
	public void CalculateDistanceIntensity(float camDistSqr)
	{
	}
}
