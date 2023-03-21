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
		[CallerCount(Count = 53)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 93)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 93)]
	public MigratedLootTableAttribute(string legacyFieldName)
	{
	}
}
