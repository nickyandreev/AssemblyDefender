using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AssemblyDefender.Common.IO;

namespace AssemblyDefender.Net.Metadata
{
	public class CustomAttributeTableSortComparer : TableSortComparer
	{
		public CustomAttributeTableSortComparer(int[] parentArray)
			: base(parentArray)
		{
		}

		public CustomAttributeTableSortComparer(CustomAttributeTable table)
		{
			var rows = table.GetRows();
			int count = rows.Length;
			_values = new int[count];
			for (int i = 0; i < count; i++)
			{
				_values[i] = rows[i].Parent;
			}
		}
	}
}
