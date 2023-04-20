using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using UnityEngine;

namespace TLD.UI;

public class PanelReference : ScriptableObject
{
	private Panel_Base _003CPanel_003Ek__BackingField;

	public Panel_Base Panel
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PackManager), Member = "Start")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "Start")]
	[CalledBy(Type = typeof(Panel_HUD.ScentIndicator), Member = "UpdateActionsPanel")]
	[CalledBy(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	public static PanelReference Get<T>() where T : Panel_Base
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CalledBy(Type = typeof(PanelReference), Member = "Get")]
	[CalledBy(Type = typeof(Panel_AutoReferenced), Member = "Awake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static PanelReference Get(Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PackManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayNextSkippableMovie")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnMovieStop")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 86)]
	public void SetPanelReference<T>(T panel) where T : Panel_Base
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void TryEnablePanelWithAudio(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetAssetName(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	private static PanelReference FindExistingInstance(string assetKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 1)]
	private static PanelReference CreateReference(string assetKey)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void VerifyPanelTypes<T>() where T : Panel_Base
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PanelReference()
	{
	}
}
