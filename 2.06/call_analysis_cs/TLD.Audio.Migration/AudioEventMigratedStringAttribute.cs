using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Audio.Migration;

public class AudioEventMigratedStringAttribute : PropertyAttribute
{
	private string _003CFormerStringFieldName_003Ek__BackingField;

	public string FormerStringFieldName
	{
		[CallerCount(Count = 44)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 85)]
	public AudioEventMigratedStringAttribute(string previousStringEventName)
	{
	}
}
