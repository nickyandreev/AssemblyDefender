using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AssemblyDefender.Common.IO;

namespace AssemblyDefender.Net.Metadata
{
	/// <summary>
	/// An event map to events lookup table, which does not exist in optimized metadata (#~ stream).
	/// </summary>
	public class EventPtrTable : MetadataPtrTable
	{
		internal EventPtrTable(MetadataTableStream stream)
			: base(MetadataTableType.EventPtr, stream)
		{
		}

		protected internal override void Read(IBinaryAccessor accessor, TableCompressionInfo compressionInfo, int count)
		{
			if (count == 0)
				return;

			var rows = new int[count];
			for (int i = 0; i < count; i++)
			{
				rows[i] = accessor.ReadCell(compressionInfo.TableRowIndexSize4[MetadataTableType.Event]);
			}

			_count = count;
			_rows = rows;
		}

		protected internal override void Write(Blob blob, ref int pos, TableCompressionInfo compressionInfo)
		{
			for (int i = 0; i < _count; i++)
			{
				blob.WriteCell(ref pos, compressionInfo.TableRowIndexSize4[MetadataTableType.Event], _rows[i]);
			}
		}
	}
}
