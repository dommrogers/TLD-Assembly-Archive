using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstAidStation : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstAidStation()
	{
	}
}
