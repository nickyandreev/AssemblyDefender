using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyDefender.PE
{
	/// <summary>
	/// The section Characteristics flags are defined in Winnt.h. Some of these flags are reserved,
	/// and some are relevant to object files only.
	/// </summary>
	public enum SectionCharacteristics : uint
	{
		/// <summary>
		/// TLS descriptor table index is scaled.
		/// </summary>
		ScaleIndex = 0x00000001,

		/// <summary>
		/// Section contains executable code. In IL assembler-generated PE files,
		/// only the .text section carries this flag.
		/// </summary>
		ContainsCode = 0x00000020,

		/// <summary>
		/// Section contains initialized data.
		/// </summary>
		ContainsInitializedData = 0x00000040,

		/// <summary>
		/// Section contains uninitialized data.
		/// </summary>
		ContainsUninitializedData = 0x00000080,

		/// <summary>
		/// Section contains comments or some other type of auxiliary information.
		/// </summary>
		LnkInfo = 0x000200,

		/// <summary>
		/// Reset speculative exception handling bits in the translation lookaside buffer (TLB)
		/// entries for this section.
		/// </summary>
		NoDeferSpecExc = 0x00004000,

		/// <summary>
		/// Section contains extended relocations.
		/// </summary>
		LnkNRelocOvfl = 0x01000000,

		/// <summary>
		/// Section can be discarded as needed.
		/// </summary>
		MemDiscardable = 0x02000000,

		/// <summary>
		/// Section cannot be cached.
		/// </summary>
		MemNotCached = 0x04000000,

		/// <summary>
		/// Section cannot be paged.
		/// </summary>
		MemNotPaged = 0x08000000,

		/// <summary>
		/// Section can be shared in memory.
		/// </summary>
		MemShared = 0x10000000,

		/// <summary>
		/// Section can be executed as code. In IL assembler-generated PE files,
		/// only the .text carries this flag.
		/// </summary>
		MemExecute = 0x20000000,

		/// <summary>
		/// Section can be read.
		/// </summary>
		MemoryRead = 0x40000000,

		/// <summary>
		/// Section can be written to. In PE files generated by assembler,
		/// only the .sdata and .tls sections carry this flag.
		/// </summary>
		MemoryWrite = 0x80000000,
	}
}
