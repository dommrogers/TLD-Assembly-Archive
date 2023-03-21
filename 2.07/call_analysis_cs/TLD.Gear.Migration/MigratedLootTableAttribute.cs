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
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 79)]
		private set
		{
		}
	}

	[CallerCount(Count = 79)]
	[DeduplicatedMethod]
	public MigratedLootTableAttribute(string legacyFieldName)
	{
	}
}
