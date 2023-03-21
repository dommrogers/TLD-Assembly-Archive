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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public static event OnInstalledDelegate OnInstalled
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DLCManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public static void Create()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void Destroy()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static DownloadableContentPackageList FindPackages(InstalledPackagesFilter filter)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(DLCManager), Member = "Create")]
	[CallsUnknownMethods(Count = 17)]
	public DLCManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose()
	{
	}

	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(DLCPlugin.DownloadableContentPackageInstallCompletedCallback))]
	public static void OnInstalledThunk(IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 7)]
	public static void OnInstalledWithDetailsThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
