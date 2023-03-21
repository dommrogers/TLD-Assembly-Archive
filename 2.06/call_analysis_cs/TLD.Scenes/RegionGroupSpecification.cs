using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Scenes;

public class RegionGroupSpecification : ScriptableObject
{
	private LocalizedString m_GroupName;

	public string Name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string LocalizedName
	{
		[Calls(Type = typeof(Localization), Member = "Get")]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public RegionGroupSpecification()
	{
	}
}
