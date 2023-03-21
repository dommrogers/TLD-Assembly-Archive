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
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallerCount(Count = 0)]
	public float Use()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PurifyWater()
	{
	}
}
