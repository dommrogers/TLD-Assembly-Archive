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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallsUnknownMethods(Count = 3)]
	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsUnknownMethods(Count = 7)]
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
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

	[CalledBy(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallerCount(Count = 4)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 11)]
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
