using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public class PostProcessEffectSettings : ScriptableObject
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<FieldInfo, bool> _003C_003E9__6_0;

		public static Func<FieldInfo, int> _003C_003E9__6_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003COnEnable_003Eb__6_0(FieldInfo t)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int _003COnEnable_003Eb__6_1(FieldInfo t)
		{
			return default(int);
		}
	}

	private bool m_Active;

	public BoolParameter enabled;

	internal ReadOnlyCollection<ParameterOverride> parameters;

	public bool active
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CalledBy(Type = typeof(PostProcessManager), Member = "EnableAO")]
		[CalledBy(Type = typeof(CameraEffects), Member = "Start")]
		[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(CameraEffects), Member = "Start")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 35)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetAllOverridesTo(bool state, bool excludeEnabled = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public int GetHash()
	{
		return default(int);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 42)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public PostProcessEffectSettings()
	{
	}
}
