using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Audio.Migration;

public class AudioEventMigratedStringAttribute : PropertyAttribute
{
	private string _003CFormerStringFieldName_003Ek__BackingField;

	public string FormerStringFieldName
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 79)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 79)]
	public AudioEventMigratedStringAttribute(string previousStringEventName)
	{
	}
}
