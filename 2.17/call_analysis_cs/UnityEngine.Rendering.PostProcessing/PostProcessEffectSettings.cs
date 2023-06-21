using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003COnEnable_003Eb__6_0(FieldInfo t)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003COnEnable_003Eb__6_1(FieldInfo t)
		{
			return 0;
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
			return false;
		}
		[CalledBy(Type = typeof(CameraEffects), Member = "Start")]
		[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "EnableAO")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(List<>), Member = "AsReadOnly")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 15)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public void SetAllOverridesTo(bool state, bool excludeEnabled = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public int GetHash()
	{
		return 0;
	}

	[CallerCount(Count = 42)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PostProcessEffectSettings()
	{
	}
}
