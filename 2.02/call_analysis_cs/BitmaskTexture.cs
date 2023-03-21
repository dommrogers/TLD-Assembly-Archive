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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BreakableIce), Member = "InitializeBrokenIceTexture")]
	[CallerCount(Count = 1)]
	public BitmaskTexture(int width, int height, int bitCount)
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException")]
	[Calls(Type = typeof(UnityException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void ApplyChanges()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void ClearBit(int x, int y, int bit)
	{
	}

	[CallerCount(Count = 0)]
	public int IndexOf(int x, int y)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsBitSet(int x, int y, int bit)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void SetBit(int x, int y, int bit)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static int RoundUpAndDivide(int x, int d)
	{
		return 0;
	}
}
