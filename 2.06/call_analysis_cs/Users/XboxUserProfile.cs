using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Users;

public class XboxUserProfile : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private string m_ApplicationDisplayName;

	private Uri m_ApplicationDisplayPictureResizeUri;

	private string m_GameDisplayName;

	private Uri m_GameDisplayPictureResizeUri;

	private string m_Gamerscore;

	private string m_Gamertag;

	private string m_XboxUserId;

	public string ApplicationDisplayName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public Uri ApplicationDisplayPictureResizeUri
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string GameDisplayName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public Uri GameDisplayPictureResizeUri
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public string Gamerscore
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string Gamertag
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public string XboxUserId
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public XboxUserProfile(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public XboxUserProfile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	~XboxUserProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_AbsoluteUri")]
	public string GetGameDisplayPictureResizeUriForSize(Picture.Size size)
	{
		return null;
	}
}
