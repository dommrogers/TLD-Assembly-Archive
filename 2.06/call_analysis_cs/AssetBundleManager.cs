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
	private sealed class _003CGetAllBundles_003Ed__6 : IEnumerator<AssetBundleRef>, IEnumerable, IDisposable, IEnumerator, IEnumerable<AssetBundleRef>
	{
		private int _003C_003E1__state;

		private AssetBundleRef _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Dictionary<int, AssetBundleRef>.ValueCollection.Enumerator _003Cenumerator_003E5__2;

		private AssetBundleRef System_002ECollections_002EGeneric_002EIEnumerator_003CAssetBundleRef_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 44)]
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

		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
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

	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CompatibilityAssetBundleManifest), Member = "GetAllDependencies")]
	public static IEnumerable<string> GetDependencies(string bundle)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsLoading()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsVerbose()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsSimulating()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadManifest")]
	[CallsUnknownMethods(Count = 1)]
	public static void Init()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	internal static string GetPlatformName()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 6)]
	private static AssetBundleRef CreateReference(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	private static AssetBundleRef FindBundleByName(string name)
	{
		return null;
	}

	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[CallerCount(Count = 0)]
	public static bool BundleExists(string bundleName, string fileName = "")
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeLoadMissionTexturesAssetBundle")]
	[CallsUnknownMethods(Count = 1)]
	public static AssetBundleRef LoadBundle(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	public static AssetBundleRef LoadBundleAsync(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "Init")]
	[Calls(Type = typeof(AssetBundle), Member = "LoadAsset")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private static void LoadManifest()
	{
	}

	[CalledBy(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	public static void UnloadBundle(AssetBundleRef bundle, bool unloadAllLoadedObjects)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
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

	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	public static void VerboseLogError(string message)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AssetBundleManager()
	{
	}
}
