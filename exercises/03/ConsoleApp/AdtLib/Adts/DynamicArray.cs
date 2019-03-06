using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdtLib.Enums;

namespace AdtLib.Adts
{
	public class DynamicArray
	{
		private int?[] _data;

		public int MaxSize
		{
			get => _data.Length;
			set
			{
				if (value < _data.Length)
				{
					throw new ApplicationException($"Can't shrink the size.");
				}

				var tmpData = new int?[value];
				Array.Copy(_data, 0, tmpData, 0, _data.Length);
				_data = tmpData;
			}
		}

		public int? this[int index]
		{
			get => _data[index];
			set
			{
				if (index >= _data.Length)
				{
					var tmpData = new int?[index + 1];
					Array.Copy(_data, 0, tmpData, 0, _data.Length);
					tmpData[index] = value;
					_data = tmpData;
				}
				else
				{
					_data[index] = value;
				}
			}
		}

		public int CurrentSize => _data.Count(i => i.HasValue);

		public DynamicArrayState State
		{
			get
			{
				if (_data.All(i => !i.HasValue))
				{
					return DynamicArrayState.Empty;
				}

				if (_data.All(i => i.HasValue))
				{
					return DynamicArrayState.Full;
				}

				return DynamicArrayState.PartiallyFilled;
			}
		}

		public DynamicArray(int maxSize = 5)
		{
			_data = new int?[maxSize];
		}

		public void Sum(out int sum)
		{
			sum = _data.Where(i => i.HasValue).Sum(i => i.Value);
		}

		public void AddValueFrom(ref int item, int index)
		{
			item += _data[index] ?? throw new ApplicationException($"Null at index: {index}");
		}

		public override string ToString()
		{
			var result = new StringBuilder();
			foreach (var item in _data)
			{
				string value = item.HasValue ? item.Value.ToString() : "NULL";
				result.Append(value);
				result.Append(", ");
			}

			return result.ToString();
		}
	}
}