using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace MiniEXR;

public static class MiniEXR
{
	private static byte[] kHeader;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CallsUnknownMethods(Count = 5)]
	public static void MiniEXRWrite(string _filePath, uint _width, uint _height, Color[] _colorArray)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	public static byte[] MiniEXRWrite(uint _width, uint _height, Color[] _colorArray)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	public static void MiniEXRWrite_Depth(string _filePath, uint _width, uint _height, Color[] _colorArray, float _farClip)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsUnknownMethods(Count = 2)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, Color[] _colorArray, float farClip)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	public static byte[] BuildEXRHeader(uint _width, uint _height, out int bufI)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref bufI) = null;
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	public static byte[] MiniEXRWrite(uint _width, uint _height, uint _channels, float[] _rgbaArray)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, float[] _rArray)
	{
		return null;
	}
}
