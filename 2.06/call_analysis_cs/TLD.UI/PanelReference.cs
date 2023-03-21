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
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		set
		{
		}
	}

	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static PanelReference Get<T>() where T : Panel_Base
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_AutoReferenced), Member = "Awake")]
	[CalledBy(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static PanelReference Get(Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 85)]
	public void SetPanelReference<T>(T panel) where T : Panel_Base
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetAssetName(Type type)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	private void VerifyPanelTypes<T>() where T : Panel_Base
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PanelReference()
	{
	}
}
