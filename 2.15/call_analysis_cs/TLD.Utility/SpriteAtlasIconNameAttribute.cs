using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Utility;

public class SpriteAtlasIconNameAttribute : PropertyAttribute
{
	private const string BaseAtlas = "Base Atlas_hd";

	private string _003CAtlas_003Ek__BackingField;

	public string Atlas
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

	[CallerCount(Count = 0)]
	public SpriteAtlasIconNameAttribute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 86)]
	public SpriteAtlasIconNameAttribute(string atlas)
	{
	}
}
