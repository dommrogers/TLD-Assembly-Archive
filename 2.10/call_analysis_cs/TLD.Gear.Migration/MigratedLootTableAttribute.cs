using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear.Migration;

public class MigratedLootTableAttribute : PropertyAttribute
{
	private string _003CLegacyFieldName_003Ek__BackingField;

	public string LegacyFieldName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 86)]
	public MigratedLootTableAttribute(string legacyFieldName)
	{
	}
}
