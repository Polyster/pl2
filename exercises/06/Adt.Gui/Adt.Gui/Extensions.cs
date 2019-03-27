using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Gui
{
	public static class Extensions
	{
		public static DataTable GetTable(this DataSet dataSet, string tableName)
		{
			return dataSet.Tables[dataSet.Tables.IndexOf(tableName)];
		}
	}
}