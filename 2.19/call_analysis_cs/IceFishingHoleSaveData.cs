using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class IceFishingHoleSaveData
{
	public Vector3 m_Position;

	public string m_Guid;

	public AssetReference m_AssetReference;

	public float m_HoursPlayed;

	public float m_MinutesSinceLastClearing;

	public float m_NormalizedFrozen;

	public FishingState m_FishingState;

	public CatchParameters m_NextCatch;

	public float m_CatchMaxTimeModifier;

	public SerializedTackle m_SerializedBait;

	public SerializedTackle m_SerializedLure;

	public SerializedTackle m_SerializedTipup;

	[CallerCount(Count = 0)]
	public IceFishingHoleSaveData()
	{
	}
}
