using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Users;

public class MultiplePermissionsCheckResult : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private PermissionCheckResultList m_Items;

	private string m_XboxUserId;

	public PermissionCheckResultList Items
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public string XboxUserId
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MultiplePermissionsCheckResult(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MultiplePermissionsCheckResult()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
