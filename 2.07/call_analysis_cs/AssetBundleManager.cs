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
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private IEnumerator<AssetBundleRef> System_002ECollections_002EGeneric_002EIEnumerable_003CAssetBundleRef_003E_002EGetEnumerator()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(_003CGetAllBundles_003Ed__6))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<AssetBundleRef> GetAllBundles()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static string GetBundlePath()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CompatibilityAssetBundleManifest), Member = "GetAllDependencies")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 3)]
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

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
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
	[CallsUnknownMethods(Count = 1)]
	private static AssetBundleRef CreateReference(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static AssetBundleRef FindBundleByName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultAssetBundleRef), Member = "GetFullBundlePath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static bool BundleExists(string bundleName, string fileName = "")
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundle")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeLoadMissionTexturesAssetBundle")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	public static AssetBundleRef LoadBundle(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP._003CLoadAnimations_003Ed__250), Member = "MoveNext")]
	[CalledBy(Type = typeof(AssetBundleRef), Member = "LoadBundleAsync")]
	[CalledBy(Type = typeof(CinematicTrack._003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[Calls(Type = typeof(AssetBundleManager), Member = "FindBundleByName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AssetBundleManager), Member = "CreateReference")]
	public static AssetBundleRef LoadBundleAsync(string name)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CalledBy(Type = typeof(AssetBundleManager), Member = "Init")]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CallsUnknownMethods(Count = 2)]
	private static void LoadManifest()
	{
	}

	[CalledBy(Type = typeof(AssetBundleRef), Member = "UnloadBundle")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UnloadAnimations")]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadStringTable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void UnloadBundle(AssetBundleRef bundle, bool unloadAllLoadedObjects)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public AssetBundleManager()
	{
	}
}
