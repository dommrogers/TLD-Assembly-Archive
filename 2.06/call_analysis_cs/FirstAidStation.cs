using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstAidStation : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
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
