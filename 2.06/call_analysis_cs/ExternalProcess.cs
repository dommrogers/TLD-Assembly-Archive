using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

public static class ExternalProcess
{
	private struct PROCESS_INFORMATION
	{
		internal IntPtr hProcess;

		internal IntPtr hThread;

		internal uint dwProcessId;

		internal uint dwThreadId;
	}

	private struct STARTUPINFO
	{
		internal uint cb;

		internal IntPtr lpReserved;

		internal IntPtr lpDesktop;

		internal IntPtr lpTitle;

		internal uint dwX;

		internal uint dwY;

		internal uint dwXSize;

		internal uint dwYSize;

		internal uint dwXCountChars;

		internal uint dwYCountChars;

		internal uint dwFillAttribute;

		internal uint dwFlags;

		internal ushort wShowWindow;

		internal ushort cbReserved2;

		internal IntPtr lpReserved2;

		internal IntPtr hStdInput;

		internal IntPtr hStdOutput;

		internal IntPtr hStdError;
	}

	private enum ProcessCreationFlags : uint
	{
		NONE = 0u,
		CREATE_BREAKAWAY_FROM_JOB = 16777216u,
		CREATE_DEFAULT_ERROR_MODE = 67108864u,
		CREATE_NEW_CONSOLE = 16u,
		CREATE_NEW_PROCESS_GROUP = 512u,
		CREATE_NO_WINDOW = 134217728u,
		CREATE_PROTECTED_PROCESS = 262144u,
		CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 33554432u,
		CREATE_SECURE_PROCESS = 4194304u,
		CREATE_SEPARATE_WOW_VDM = 2048u,
		CREATE_SHARED_WOW_VDM = 4096u,
		CREATE_SUSPENDED = 4u,
		CREATE_UNICODE_ENVIRONMENT = 1024u,
		DEBUG_ONLY_THIS_PROCESS = 2u,
		DEBUG_PROCESS = 1u,
		DETACHED_PROCESS = 8u,
		EXTENDED_STARTUPINFO_PRESENT = 524288u,
		INHERIT_PARENT_AFFINITY = 65536u
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static extern bool CreateProcessW(string lpApplicationName, [In] string lpCommandLine, IntPtr procSecAttrs, IntPtr threadSecAttrs, bool bInheritHandles, ProcessCreationFlags dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[CalledBy(Type = typeof(Utils), Member = "QuitAndRunApplication")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public static bool RunCommand(string command, string args, string workingDirectory)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public static bool RunCommand(string command, string workingDirectory)
	{
		return false;
	}
}
