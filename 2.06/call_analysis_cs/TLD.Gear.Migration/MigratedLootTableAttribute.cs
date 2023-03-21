using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear.Migration;

public class MigratedLootTableAttribute : PropertyAttribute
{
	private string _003CLegacyFieldName_003Ek__BackingField;

	public string LegacyFieldName
	{
		[CallerCount(Count = 44)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 85)]
	public MigratedLootTableAttribute(string legacyFieldName)
	{
	}
}
