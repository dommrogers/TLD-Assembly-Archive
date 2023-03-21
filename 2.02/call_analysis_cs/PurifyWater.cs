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
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnPurifyWaterComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public float Use()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PurifyWater()
	{
	}
}
