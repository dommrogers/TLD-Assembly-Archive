using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessProfile : ScriptableObject
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<PostProcessEffectSettings> _003C_003E9__2_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		internal bool _003COnEnable_003Eb__2_0(PostProcessEffectSettings x)
		{
			return default(bool);
		}
	}

	public List<PostProcessEffectSettings> settings;

	[NonSerialized]
	public bool isDirty;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallsUnknownMethods(Count = 11)]
	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveSettings(Type type)
	{
	}

	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasSettings<T>() where T : PostProcessEffectSettings
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasSettings(Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public T GetSetting<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
	{
		outSetting = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public PostProcessProfile()
	{
	}
}
