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

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public _003C_003Ec()
			{
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			internal uint _003C_002Ector_003Eb__1_0(int i)
			{
				return default(uint);
			}
		}

		private static uint generator;

		private readonly uint[] checksumTable;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "RangeIterator")]
		[CalledBy(Type = typeof(PngEncoder), Member = ".cctor")]
		[CallsUnknownMethods(Count = 10)]
		public Crc32()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		public uint Calculate<T>(IEnumerable<T> byteStream)
		{
			return default(uint);
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public byte[] dataRgba;

		public int stride;

		public Action<Exception, byte[]> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(PngEncoder), Member = "Encode")]
		[CallsUnknownMethods(Count = 5)]
		internal void _003CEncodeAsync_003Eb__0(object state)
		{
		}
	}

	private static Crc32 crc32;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Crc32), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	static PngEncoder()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static uint Adler32(byte[] bytes)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static void AppendByte(this byte[] data, ref int position, byte value)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendUInt")]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendInt")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	private static void AppendBytes(this byte[] data, ref int position, byte[] value)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[Calls(Type = typeof(PngEncoder), Member = "GetChunkCrc")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendUInt")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendInt")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	private static void AppendChunk(this byte[] data, ref int position, string chunkType, byte[] chunkData)
	{
	}

	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(Array), Member = "Reverse")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	private static void AppendInt(this byte[] data, ref int position, int value)
	{
	}

	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[Calls(Type = typeof(Array), Member = "Reverse")]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	private static void AppendUInt(this byte[] data, ref int position, uint value)
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(PngEncoder), Member = "Encode")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor")]
	[CallerCount(Count = 1)]
	private static byte[] Compress(byte[] bytes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 57)]
	[CalledBy(Type = typeof(ScreenshotRecorder.ScreenshotOperation), Member = "EncodeCallback")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass11_0), Member = "<EncodeAsync>b__0")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendBytes")]
	[Calls(Type = typeof(PngEncoder), Member = "Compress")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendInt")]
	[Calls(Type = typeof(PngEncoder), Member = "AppendInt")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PngEncoder), Member = "AppendUInt")]
	public static byte[] Encode(byte[] dataRgba, int stride)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void EncodeAsync(byte[] dataRgba, int stride, Action<Exception, byte[]> callback)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(PngEncoder), Member = "AppendChunk")]
	[CallsUnknownMethods(Count = 11)]
	private static uint GetChunkCrc(byte[] chunkTypeBytes, byte[] chunkData)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static byte[] GetChunkTypeBytes(string value)
	{
		return null;
	}
}
