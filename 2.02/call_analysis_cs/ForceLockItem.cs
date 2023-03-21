using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ForceLockItem : MonoBehaviour
{
	public string m_ForceLockAudio;

	public LocalizedString m_LocalizedProgressText;

	public string m_ProgressText
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ForceLockItem()
	{
	}
}
