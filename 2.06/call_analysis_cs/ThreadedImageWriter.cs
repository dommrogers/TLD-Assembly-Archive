using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using MiniEXR;
using UnityEngine;

public class ThreadedImageWriter : MonoBehaviour
{
	private Thread[] writerThreads;

	private Queue<ImageWriteRequest>[] writerQueues;

	private int nextWriterQueue;

	private const int NUM_WRITER_THREADS = 4;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsUnknownMethods(Count = 22)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsUnknownMethods(Count = 25)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type, float farClip)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsUnknownMethods(Count = 25)]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	public void AddWriteRequest(string filename, byte[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsFallingBehind()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void ImageWriter(object obj)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ThreadedImageWriter()
	{
	}
}
