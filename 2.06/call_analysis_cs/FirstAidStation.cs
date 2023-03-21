using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstAidStation : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FirstAidStation()
	{
	}
}
