using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using Interface.PanelRequest;
using UnityEngine;

public class AssetBundleManager
{
	private sealed class _003CGetAllBundles_003Ed__6 : IEnumerable<AssetBundleRef>, IEnumerable, IEnumerator<AssetBundleRef>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private AssetBundleRef _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Dictionary<int, AssetBundleRef>.ValueCollection.Enumerator _003Cenumerator_003E5__2;

		private AssetBundleRef System_002ECollections_002EGeneric_002EIEnumerator_003CAssetBundleRef_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
		[CallsUnknownMethods(Count = 2)]
		public _003CGetAllBundles_003Ed__6(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
		[CalledBy(Type = typeof(_003CGetAllBundles_003Ed__6), Member = "System.Collections.IEnumerable.GetEnumerator")]
		[CallsUnknownMethods(Count = 13)]
		private IEnumerator<AssetBundleRef> System_002ECollections_002EGeneric_002EIEnumerable_003CAssetBundleRef_003E_002EGetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(_003CGetAllBundles_003Ed__6), Member = "System.Collections.Generic.IEnumerable<AssetBundleRef>.GetEnumerator")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	private static AssetBundleManifest s_Manifest;

	private static string s_BundlePath;

	private static List<AssetBundleRef> s_AsyncLoads;

	private static List<AssetBundleRef> s_CompletedLoads;

	private static Dictionary<int, AssetBundleRef> s_Bundles;

	private static bool s_Verbose;

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	public static IEnumerable<AssetBundleRef> GetAllBundles()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetBundlePath()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public static IEnumerable<string> GetDependencies(string bundle)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsLoading()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsVerbose()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool IsSimulating()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AssetBundleManager), Member = "GetPlatformName")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadManifest")]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Init()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	public static void Update()
	{
	}

	[CalledBy(Type = typeof(AssetBundleManager), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadManifest")]
	internal static string GetPlatformName()
	{
		return null;
	}

	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private static AssetBundleRef CreateReference(string name)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	private static AssetBundleRef FindBundleByName(string name)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = ".ctor")]
	[CalledBy(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	public static bool BundleExists(string bundleName, string fileName = "")
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(FogOfWar), Member = "OnEnable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeLoadMissionTexturesAssetBundle")]
	[CalledBy(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	[CalledBy(Type = typeof(LoadPanelRequest), Member = "LoadAssetBundle")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	public static AssetBundleRef LoadBundle(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Initialize")]
	[CalledBy(Type = typeof(Utils), Member = "InitAssetBundles")]
	[CalledBy(Type = typeof(Utils), Member = "InitAssetBundles")]
	[CalledBy(Type = typeof(Utils), Member = "InitAssetBundles")]
	[CalledBy(Type = typeof(Utils), Member = "InitAssetBundles")]
	[CalledBy(Type = typeof(TimelineRef._003CLoad_003Ed__17), Member = "MoveNext")]
	[CalledBy(Type = typeof(Utils), Member = "InitAssetBundles")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__31), Member = "MoveNext")]
	public static AssetBundleRef LoadBundleAsync(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "Init")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AssetBundleManager), Member = "GetPlatformName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private static void LoadManifest()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(TimelineRef), Member = "Unload")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[CalledBy(Type = typeof(FogOfWar), Member = "OnDisable")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundlePanelRequest")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(AsyncLoadPanelRequest), Member = "UpdateAssetBundleRequest")]
	[CallsUnknownMethods(Count = 3)]
	public static void UnloadBundle(AssetBundleRef bundle, bool unloadAllLoadedObjects)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CallsUnknownMethods(Count = 2)]
	public static void UnloadBundle(string name, bool unloadAllLoadedObjects)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void VerboseLog(string message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void VerboseLogWarning(string message)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void VerboseLogError(string message)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AssetBundleManager()
	{
	}
}
