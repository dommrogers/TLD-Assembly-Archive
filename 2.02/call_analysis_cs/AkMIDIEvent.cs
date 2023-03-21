using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkMIDIEvent : IDisposable
{
	public class tGen : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byParam1
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(byte);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		public byte byParam2
		{
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(byte);
			}
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			set
			{
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal tGen(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static IntPtr getCPtr(tGen obj)
		{
			return default(IntPtr);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		~tGen()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public virtual void Dispose()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		public tGen()
		{
		}
	}

	public class tNoteOnOff : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byNote
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(byte);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		public byte byVelocity
		{
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(byte);
			}
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal tNoteOnOff(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static IntPtr getCPtr(tNoteOnOff obj)
		{
			return default(IntPtr);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		~tNoteOnOff()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		public virtual void Dispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public tNoteOnOff()
		{
		}
	}

	public class tCc : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byCc
		{
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return default(byte);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		public byte byValue
		{
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(byte);
			}
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal tCc(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static IntPtr getCPtr(tCc obj)
		{
			return default(IntPtr);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		~tCc()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		public virtual void Dispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public tCc()
		{
		}
	}

	public class tPitchBend : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byValueLsb
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(byte);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		public byte byValueMsb
		{
			[CallsUnknownMethods(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(byte);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal tPitchBend(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static IntPtr getCPtr(tPitchBend obj)
		{
			return default(IntPtr);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		~tPitchBend()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		public virtual void Dispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public tPitchBend()
		{
		}
	}

	public class tNoteAftertouch : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byNote
		{
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(byte);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		public byte byValue
		{
			[CallsUnknownMethods(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(byte);
			}
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal tNoteAftertouch(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static IntPtr getCPtr(tNoteAftertouch obj)
		{
			return default(IntPtr);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		~tNoteAftertouch()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallsUnknownMethods(Count = 4)]
		public virtual void Dispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public tNoteAftertouch()
		{
		}
	}

	public class tChanAftertouch : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byValue
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(byte);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal tChanAftertouch(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static IntPtr getCPtr(tChanAftertouch obj)
		{
			return default(IntPtr);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		~tChanAftertouch()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallsUnknownMethods(Count = 4)]
		public virtual void Dispose()
		{
		}

		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public tChanAftertouch()
		{
		}
	}

	public class tProgramChange : IDisposable
	{
		private IntPtr swigCPtr;

		protected bool swigCMemOwn;

		public byte byProgramNum
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(byte);
			}
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			set
			{
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal tProgramChange(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static IntPtr getCPtr(tProgramChange obj)
		{
			return default(IntPtr);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal virtual void setCPtr(IntPtr cPtr)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		~tProgramChange()
		{
		}

		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[CallsUnknownMethods(Count = 4)]
		public virtual void Dispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public tProgramChange()
		{
		}
	}

	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public byte byChan
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public tGen Gen
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public tCc Cc
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public tNoteOnOff NoteOnOff
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public tPitchBend PitchBend
	{
		[CallsUnknownMethods(Count = 8)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public tNoteAftertouch NoteAftertouch
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public tChanAftertouch ChanAftertouch
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public tProgramChange ProgramChange
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public AkMIDIEventTypes byType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AkMIDIEventTypes);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public byte byOnOffNote
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte byVelocity
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public AkMIDICcTypes byCc
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(AkMIDICcTypes);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte byCcValue
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte byValueLsb
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public byte byValueMsb
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public byte byAftertouchNote
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public byte byNoteAftertouchValue
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(byte);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public byte byChanAftertouchValue
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public byte byProgramNum
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(byte);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal AkMIDIEvent(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMIDIEvent obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkMIDIPost), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	~AkMIDIEvent()
	{
	}

	[CalledBy(Type = typeof(AkMIDIPost), Member = "Dispose")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public virtual void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public AkMIDIEvent()
	{
	}
}
