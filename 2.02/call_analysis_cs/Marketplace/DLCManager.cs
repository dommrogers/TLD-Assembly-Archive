using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class DLCManager : IDisposable
{
	public delegate void OnInstalledDelegate();

	public delegate void OnInstalledWithDetailsDelegate(DownloadableContentPackageInstallCompletedEventArgs details);

	private static DLCManager gInstance;

	public static event OnInstalledWithDetailsDelegate OnInstalledWithDetails
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public static event OnInstalledDelegate OnInstalled
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DLCManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public static void Create()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void Destroy()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static DownloadableContentPackageList FindPackages(InstalledPackagesFilter filter)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(DLCManager), Member = "Create")]
	[CallsUnknownMethods(Count = 18)]
	public DLCManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void OnInstalledThunk(IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 8)]
	public static void OnInstalledWithDetailsThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
