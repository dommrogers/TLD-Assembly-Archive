using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI;

public class PanelReference : ScriptableObject
{
	private Panel_Base _003CPanel_003Ek__BackingField;

	public Panel_Base Panel
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[CallerCount(Count = 79)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	public static PanelReference Get<T>() where T : Panel_Base
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CalledBy(Type = typeof(Panel_AutoReferenced), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static PanelReference Get(Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 79)]
	public void SetPanelReference<T>(T panel) where T : Panel_Base
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string GetAssetName(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private static PanelReference FindExistingInstance(string assetKey)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private static PanelReference CreateReference(string assetKey)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	private void VerifyPanelTypes<T>() where T : Panel_Base
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public PanelReference()
	{
	}
}
