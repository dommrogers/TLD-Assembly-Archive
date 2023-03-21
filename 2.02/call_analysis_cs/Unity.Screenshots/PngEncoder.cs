using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Screenshots;

public static class PngEncoder
{
	public class Crc32
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<int, uint> _003C_003E9__1_0;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public _003C_003Ec()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			internal uint _003C_002Ector_003Eb__1_0(int i)
			{
				return 0u;
			}
		}

		private static uint generator;

		private readonly uint[] checksumTable;

		[CalledBy(Type = typeof(PngEncoder), Member = ".cctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "RangeIterator")]
		[Calls(Type = typeof(Enumerable), Member = "Select")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		public Crc32()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		public uint Calculate<T>(IEnumerable<T> byteStream)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public byte[] dataRgba;

		public int stride;

		public Action<Exception, byte[]> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PngEncoder), Member = "Encode")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		internal void _003CEncodeAsync_003Eb__0(object state)
		{
		}
	}

	private static Crc32 crc32;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Crc32), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	static PngEncoder()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static uint Adler32(byte[] bytes)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static void AppendByte(this byte[] data, ref int position, byte value)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendInt")]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendUInt")]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void AppendBytes(this byte[] data, ref int position, byte[] value)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendInt")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[Calls(Type = typeof(PngEncoder), Member = "GetChunkCrc")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendUInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static void AppendChunk(this byte[] data, ref int position, string chunkType, byte[] chunkData)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(Array), Member = "Reverse")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void AppendInt(this byte[] data, ref int position, int value)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(Array), Member = "Reverse")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void AppendUInt(this byte[] data, ref int position, uint value)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 29)]
	private static byte[] Compress(byte[] bytes)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass11_0), Member = "<EncodeAsync>b__0")]
	[CalledBy(TypeFullName = "Unity.Screenshots.ScreenshotRecorder.ScreenshotOperation", Member = "EncodeCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PngEncoder), Member = "AppendInt")]
	[Calls(Type = typeof(PngEncoder), Member = "Compress")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendUInt")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 57)]
	public static byte[] Encode(byte[] dataRgba, int stride)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public static void EncodeAsync(byte[] dataRgba, int stride, Action<Exception, byte[]> callback)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private static uint GetChunkCrc(byte[] chunkTypeBytes, byte[] chunkData)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static byte[] GetChunkTypeBytes(string value)
	{
		return null;
	}
}
