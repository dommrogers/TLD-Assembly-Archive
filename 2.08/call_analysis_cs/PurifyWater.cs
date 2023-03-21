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
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	public float Use()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PurifyWater()
	{
	}
}
