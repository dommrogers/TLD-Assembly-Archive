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
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool _003COnEnable_003Eb__2_0(PostProcessEffectSettings x)
		{
			return false;
		}
	}

	public List<PostProcessEffectSettings> settings;

	[NonSerialized]
	public bool isDirty;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "RemoveAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PostProcessProfile), Member = "RemoveSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	[CalledBy(Type = typeof(PostProcessProfile), Member = "RemoveSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void RemoveSettings(Type type)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasSettings<T>() where T : PostProcessEffectSettings
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "AddSettings")]
	[CalledBy(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool HasSettings(Type type)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public T GetSetting<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CameraEffects), Member = "Awake")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "EnableAO")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
	{
		outSetting = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public PostProcessProfile()
	{
	}
}
