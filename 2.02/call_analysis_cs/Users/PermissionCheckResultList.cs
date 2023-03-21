using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Users;

public class PermissionCheckResultList : WrappedCachedList<PermissionCheckResult>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public PermissionCheckResultList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector((IntPtr)0);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedCachedList<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public PermissionCheckResultList()
	{
		((WrappedCachedList<>)(object)this)._002Ector((IntPtr)0);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~PermissionCheckResultList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	protected override PermissionCheckResult CreateIthElement(int i)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetupLength()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void DisposeChild()
	{
	}
}
