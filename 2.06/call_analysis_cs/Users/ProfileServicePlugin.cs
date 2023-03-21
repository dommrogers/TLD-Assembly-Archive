using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Users;

public class ProfileServicePlugin
{
	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static extern bool ProfileService_GetUserProfileAsync(int requestingUserId, string xboxUserId, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ProfileService_GetUserProfilesAsync(int requestingUserId, [In] string[] xboxUserIds, uint numXboxUserIds, ObjectResultCallback callback, IntPtr userData);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ProfileServicePlugin()
	{
	}
}
