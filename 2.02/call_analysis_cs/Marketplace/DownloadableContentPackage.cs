using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class DownloadableContentPackage : IWrappedObject, IDisposable
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public IntPtr mountPoint;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		internal IntPtr _003CMount_003Eb__0()
		{
			return default(IntPtr);
		}
	}

	private IntPtr m_Self;

	private string m_ContentId;

	private string m_Description;

	private string m_DisplayName;

	private string m_MountPath;

	private string m_PackageFullName;

	private string m_ProductId;

	private string m_Publisher;

	private string m_TitleId;

	private string m_Version;

	public string ContentId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public uint ContentType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public string Description
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string DisplayName
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool IsMounted
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(DownloadableContentPackage), Member = "Mount")]
		[CalledBy(Type = typeof(DownloadableContentPackage), Member = "UnMount")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public string MountPath
	{
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CalledBy(Type = typeof(DownloadableContentPackage), Member = "Mount")]
		get
		{
			return null;
		}
	}

	public string PackageFullName
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string ProductId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Publisher
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string TitleId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Version
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DownloadableContentPackage), Member = "get_IsMounted")]
	[Calls(Type = typeof(DownloadableContentPackage), Member = "get_MountPath")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
	[CallsUnknownMethods(Count = 16)]
	public string Mount()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadableContentPackage), Member = "get_IsMounted")]
	[CallsUnknownMethods(Count = 1)]
	public void UnMount()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CheckLicense(out bool isTrial)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isTrial) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DownloadableContentPackage(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DownloadableContentPackage()
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
