using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xbox;

public class GameSaveLoadedArgs : EventArgs
{
	private byte[] _003CData_003Ek__BackingField;

	public byte[] Data
	{
		[CallerCount(Count = 98)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	public GameSaveLoadedArgs(byte[] data)
	{
	}
}
