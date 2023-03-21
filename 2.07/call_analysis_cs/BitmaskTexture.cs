using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BitmaskTexture
{
	private const int BITS_PER_BYTE = 8;

	private const int BITS_PER_PIXEL = 32;

	private const int BYTES_PER_PIXEL = 4;

	private Texture2D m_Texture;

	private byte[] m_RawData;

	private int m_BytesPerEntry;

	private int m_ArrayStride;

	private bool m_Dirty;

	public Texture2D Texture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BreakableIce), Member = "InitializeBrokenIceTexture")]
	public BitmaskTexture(int width, int height, int bitCount)
	{
	}

	[Calls(Type = typeof(UnityException), Member = ".ctor")]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 9)]
	public void ApplyChanges()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void ClearBit(int x, int y, int bit)
	{
	}

	[CallerCount(Count = 0)]
	public int IndexOf(int x, int y)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsBitSet(int x, int y, int bit)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetBit(int x, int y, int bit)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static int RoundUpAndDivide(int x, int d)
	{
		return default(int);
	}
}
