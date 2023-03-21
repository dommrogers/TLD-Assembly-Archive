using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Scenes;

public class RegionGroupSpecification : ScriptableObject
{
	private LocalizedString m_GroupName;

	public string Name
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public string LocalizedName
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public RegionGroupSpecification()
	{
	}
}
