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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallsUnknownMethods(Count = 9)]
	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PostProcessProfile), Member = "RemoveSettings")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "RemoveSettings")]
	[CallsUnknownMethods(Count = 6)]
	public void RemoveSettings(Type type)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool HasSettings<T>() where T : PostProcessEffectSettings
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasSettings(Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T GetSetting<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 8)]
	public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
	{
		outSetting = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public PostProcessProfile()
	{
	}
}
