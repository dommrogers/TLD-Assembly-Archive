using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Build.Pipeline;

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
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 53)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public _003CGetAllBundles_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private IEnumerator<AssetBundleRef> System_002ECollections_002EGeneric_002EIEnumerable_003CAssetBundleRef_003E_002EGetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	private static CompatibilityAssetBundleManifest s_Manifest;

	private static string s_BundlePath;

	private static List<AssetBundleRef> s_AsyncLoads;

	private static List<AssetBundleRef> s_CompletedLoads;

	private static Dictionary<int, AssetBundleRef> s_Bundles;

	private static bool s_Verbose;

	[IteratorStateMachine(typeof(_003CGetAllBundles_003Ed__6))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static IEnumerable<AssetBundleRef> GetAllBundles()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static string GetBundlePath()
	{
		return null;
	}

	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CompatibilityAssetBundleManifest), Member = "GetAllDependencies")]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<string> GetDependencies(string bundle)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsLoading()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsVerbose()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsSimulating()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadManifest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	internal static string GetPlatformName()
	{
		return null;
	}

	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static AssetBundleRef CreateReference(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static AssetBundleRef FindBundleByName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static bool BundleExists(string bundleName, string fileName = "")
	{
		return false;
	}

	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeLoadMissionTexturesAssetBundle")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static AssetBundleRef LoadBundle(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CalledBy(TypeFullName = "DialogueModeRigFP.<LoadAnimations>d__250", Member = "MoveNext")]
	[CalledBy(TypeFullName = "CinematicTrack.<LoadAnimations>d__66", Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static AssetBundleRef LoadBundleAsync(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(AssetBundleManager), Member = "Init")]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static void LoadManifest()
	{
	}

	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnloadBundle(AssetBundleRef bundle, bool unloadAllLoadedObjects)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnloadBundle(string name, bool unloadAllLoadedObjects)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void VerboseLog(string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void VerboseLogWarning(string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void VerboseLogError(string message)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AssetBundleManager()
	{
	}
}
