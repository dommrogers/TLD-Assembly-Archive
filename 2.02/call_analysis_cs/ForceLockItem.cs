using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ForceLockItem : MonoBehaviour
{
	public string m_ForceLockAudio;

	public LocalizedString m_LocalizedProgressText;

	public string m_ProgressText
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ForceLockItem()
	{
	}
}
