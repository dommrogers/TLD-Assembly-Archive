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
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsUnknownMethods(Count = 43)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type, float farClip)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsUnknownMethods(Count = 17)]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	public void AddWriteRequest(string filename, byte[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsFallingBehind()
	{
		return default(bool);
	}

	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(Thread), Member = "Sleep")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(global::MiniEXR.MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void ImageWriter(object obj)
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public ThreadedImageWriter()
	{
	}
}
