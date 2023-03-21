using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Users;

public class PrivacyServicePlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool PrivacyService_CheckMultiplePermissionsWithMultipleTargetUsersAsync(int userId, [In] string[] permissionIds, uint numPermissionIds, [In] string[] targetXboxUserIds, uint numTargetXboxUserIds, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool PrivacyService_CheckPermissionWithTargetUserAsync(int userId, string permissionId, string targetXboxUserId, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool PrivacyService_GetAvoidListAsync(int userId, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool PrivacyService_GetMuteListAsync(int userId, ObjectResultCallback callback, IntPtr userData);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PrivacyServicePlugin()
	{
	}
}
