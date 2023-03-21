using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Audio.Migration;

public class AudioEventMigratedStringAttribute : PropertyAttribute
{
	private string _003CFormerStringFieldName_003Ek__BackingField;

	public string FormerStringFieldName
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
	public AudioEventMigratedStringAttribute(string previousStringEventName)
	{
	}
}
