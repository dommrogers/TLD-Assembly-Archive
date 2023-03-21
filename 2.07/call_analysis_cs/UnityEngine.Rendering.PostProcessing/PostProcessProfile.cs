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
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallsUnknownMethods(Count = 10)]
	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 8)]
	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveSettings(Type type)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	public bool HasSettings<T>() where T : PostProcessEffectSettings
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	public bool HasSettings(Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	public T GetSetting<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
	{
		outSetting = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PostProcessProfile()
	{
	}
}
