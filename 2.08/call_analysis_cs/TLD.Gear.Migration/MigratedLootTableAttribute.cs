using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear.Migration;

public class MigratedLootTableAttribute : PropertyAttribute
{
	private string _003CLegacyFieldName_003Ek__BackingField;

	public string LegacyFieldName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 79)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 79)]
	public MigratedLootTableAttribute(string legacyFieldName)
	{
	}
}
