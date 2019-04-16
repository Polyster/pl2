using System;
using System.Xml.Serialization;

namespace Streams.Models
{
	public class Contact
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public double Weight { get; set; }

		[XmlIgnore]
		public MaritalStatus MaritalStatus { get; set; }

		[XmlIgnore]
		public DateTimeOffset BirthDate { get; set; }


		[XmlElement("BirthDate")]
		public string BirthDateForXml
		{
			get => BirthDate.ToString();
			set => BirthDate = DateTimeOffset.Parse(value);
		}

		[XmlElement("MaritalStatus")]
		public string MaritalStatusForXml
		{
			get => MaritalStatus.ToString();
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					MaritalStatus = default(MaritalStatus);
				}
				else
				{
					MaritalStatus = (MaritalStatus) Enum.Parse(typeof(MaritalStatus), value);
				}
			}
		}


		public override string ToString()
		{
			return $"{Name}, born {BirthDate}, status {MaritalStatus.ToString()}";
		}
	}

	public enum MaritalStatus
	{
		Married,
		Single
	}
}