using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace MiniEXR;

public static class MiniEXR
{
	private static byte[] kHeader;

	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[CallerCount(Count = 1)]
	public static void MiniEXRWrite(string _filePath, uint _width, uint _height, Color[] _colorArray)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallsUnknownMethods(Count = 5)]
	public static byte[] MiniEXRWrite(uint _width, uint _height, Color[] _colorArray)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 17)]
	public static void MiniEXRWrite_Depth(string _filePath, uint _width, uint _height, Color[] _colorArray, float _farClip)
	{
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, Color[] _colorArray, float farClip)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsUnknownMethods(Count = 2)]
	public static byte[] BuildEXRHeader(uint _width, uint _height, out int bufI)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref bufI) = null;
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	public static byte[] MiniEXRWrite(uint _width, uint _height, uint _channels, float[] _rgbaArray)
	{
		return null;
	}

	[Calls(Type = typeof(Array), Member = "Copy")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, float[] _rArray)
	{
		return null;
	}
}
