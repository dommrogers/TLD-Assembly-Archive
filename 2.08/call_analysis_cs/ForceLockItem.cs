using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ForceLockItem : MonoBehaviour
{
	public string m_ForceLockAudio;

	public LocalizedString m_LocalizedProgressText;

	public string m_ProgressText
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ForceLockItem()
	{
	}
}
