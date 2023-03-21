using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PurifyWater : MonoBehaviour
{
	public float m_LitersPurify;

	public float m_ProgressBarDurationSeconds;

	public LocalizedString m_LocalizedProgressBarMessage;

	public string m_PurifyAudio;

	public string m_ProgressBarMessage
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnPurifyWaterComplete")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	public float Use()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PurifyWater()
	{
	}
}
