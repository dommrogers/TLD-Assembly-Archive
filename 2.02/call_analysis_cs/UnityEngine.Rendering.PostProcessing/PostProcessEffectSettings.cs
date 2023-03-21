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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		internal bool _003COnEnable_003Eb__6_0(FieldInfo t)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
		[CallerCount(Count = 81)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 41)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public int GetHash()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 42)]
	[CallsDeduplicatedMethods(Count = 1)]
	public PostProcessEffectSettings()
	{
	}
}
